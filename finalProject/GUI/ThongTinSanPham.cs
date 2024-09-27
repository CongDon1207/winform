using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class ptbPicture : Form
    {
        public string TenDangNhap {  get; set; }
        public string Ten { get; set; }
        public int GiaLucMua { get; set; }
        public int GiaBan { get; set; }
        public string TinhTrang { get; set; }
        public string ThoiGian { get; set; }
        public string MoTaTinhTrang { get; set; }
        public string MoTa { get; set; }
        public string DiaChi { get; set; }
        public string ThongTinLH { get; set; }
        public string TenTaiKhoan { get; set; }
        public List<Image> PicList { get; set; } 
        //
        private MainForm mainForm;
        private MuaHang muaHang;
        TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
        DonHangDao donHangDao = new DonHangDao();
        SanPhamDao sanPhamDao = new SanPhamDao();
        KhachHangDao khachHangDao = new KhachHangDao();
        NapRutDao napRutDao = new NapRutDao();

        public ptbPicture(MainForm main, MuaHang muaHang)
        {
            InitializeComponent();
            this.mainForm = main;
            this.muaHang = muaHang;
        }
        private int currentImageIndex = 0;
        
        private void ThongTinSanPham_Load(object sender, EventArgs e)
        {
            txtTenSP.Text = Ten;
            txtGiaLucMua.Text = GiaLucMua.ToString();
            txtGiaBan.Text = GiaBan.ToString();
            txtTinhTrang.Text = TinhTrang;
            txtThoiGian.Text = ThoiGian;
            txtMoTaTinhTrang.Text = MoTaTinhTrang;
            txtMoTa.Text = MoTa;
            txtDiaChi.Text = DiaChi;
            txtThongTinLH.Text = ThongTinLH;
            if (PicList != null && PicList.Count > 0)
            {
                ptbPic.Image = PicList[currentImageIndex];
            }
            
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có hình ảnh tiếp theo trong danh sách không
            if (PicList != null && currentImageIndex < PicList.Count - 1)
            {
                // Chuyển sang hình ảnh tiếp theo
                currentImageIndex++;
                ptbPic.Image = PicList[currentImageIndex];
            }
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có hình ảnh trước đó trong danh sách không
            if (PicList != null && currentImageIndex > 0)
            {
                // Chuyển về hình ảnh trước đó
                currentImageIndex--;
                ptbPic.Image = PicList[currentImageIndex];
            }
        }

        public string GetTenNguoiDung(string tenTaiKhoan)
        {
            return taiKhoanDao.LayTenNguoiDung(tenTaiKhoan);
             
        }

        private void btnMuaDo_Click(object sender, EventArgs e)
        {
            if (GiaBan > napRutDao.GetCurrentBalance(TenDangNhap))
            {
                MessageBox.Show("Không thể mua sản phẩm có giá lớn hơn giá xu hiện có!");
                return;
            }
            // Trừ xu khỏi tài khoản mua
            taiKhoanDao.CapNhatXuMua(TenDangNhap, GiaBan);

            // Cộng xu vào tài khoản người bán
            taiKhoanDao.CapNhatXuBan(TenTaiKhoan, GiaBan);

            // Lấy ma sản phẩm 
            int maSanPham = sanPhamDao.LayMaSanPham(Ten, TenTaiKhoan, GiaBan);

            // Lưu Lịch Sử
            string tenNguoiBan = taiKhoanDao.LayTenNguoiDung(TenTaiKhoan);
            string tenSanPham = Ten;
            DateTime thoiGian = DateTime.Now;
            donHangDao.LuuLichSu(TenDangNhap, TenTaiKhoan, tenNguoiBan, tenSanPham, GiaBan, thoiGian);

            // Lưu khách hàng 
            khachHangDao.LuuKhachHang(TenTaiKhoan, TenDangNhap);

            //Xóa sản phẩm 
            sanPhamDao.XoaSanPham(maSanPham);

            //Cập nhật số xu
            mainForm.CapNhatSoXu();

            //Thông báo
            MessageBox.Show("Mua hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            muaHang.HienThiMacDinh(); //load lai trang
            this.Close();
        }

        

        private void btnNguoiBan_Click(object sender, EventArgs e)
        {
            XemDanhGia xemDanhGia = new XemDanhGia()
            {
                TenDangNhap = TenDangNhap,
                TenTaiKhoan = TenTaiKhoan
            };
            xemDanhGia.Show();
        }

        private void btnQuanTam_Click(object sender, EventArgs e)
        {
            
            int maSP = sanPhamDao.LayMaSanPham(Ten, TenTaiKhoan, GiaBan); // Giả sử này là mã sản phẩm bạn muốn thêm
            string tenTaiKhoan =TenDangNhap; // Tên tài khoản người dùng

            if (maSP != -1 && sanPhamDao.ThemSanPhamQuanTam(maSP, tenTaiKhoan))
            {
                MessageBox.Show("Sản phẩm đã được thêm vào mục quan tâm.");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm vào mục quan tâm.");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string maGiamGia = txtMaGiamGia.Text;
            var ketQua = sanPhamDao.KiemTraVoucher(maGiamGia);
            if (ketQua.hopLe)
            {
                GiaBan = GiaBan * (100 - ketQua.phanTramGiam) / 100;
                txtGiaBan.Text = GiaBan.ToString();
                MessageBox.Show(ketQua.thongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ketQua.thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoThich_Click(object sender, EventArgs e)
        {
            int maSP = sanPhamDao.LayMaSanPham(Ten, TenTaiKhoan, GiaBan);
            string tenTaiKhoan = TenDangNhap;

            bool result = sanPhamDao.BoSanPhamQuanTam(maSP, tenTaiKhoan);

            if (result)
            {   
                MessageBox.Show("Sản phẩm đã được xóa khỏi danh sách yêu thích của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                muaHang.HienThiSanPham("QuanTam", "ALL"); // load lại trang
            }
            else
            {
                MessageBox.Show("Không thể xóa sản phẩm khỏi danh sách yêu thích. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
