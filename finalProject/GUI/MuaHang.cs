using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class MuaHang : Form
    {
        private SanPhamDao sanPhamDao;
        public string TenDangNhap { get; set; }
        private MainForm mainForm;
        public MuaHang(MainForm main)
        {
            InitializeComponent();
            sanPhamDao = new SanPhamDao();
            mainForm = main;
        }

        public void ThemSP(string ten, int gia, List<Image> hinh, int giaLucMua, string tinhTrang, string tgMua, string motaTinhTrang, string moTa, string diaChi, string thongTinLH, string tenTaiKhoan, DateTime thoiGianDang, int maSP)
        {
            ImageUC imageUC = new ImageUC(gia, giaLucMua)
            {
                Ten = ten,
                GiaBan = gia,
                Pic = hinh.Count > 0 ? hinh[0] : null,
                PicList = hinh,
                GiaLucMua = giaLucMua,
                TinhTrang = tinhTrang,
                TGMua = tgMua,
                MoTaTinhTrang = motaTinhTrang,
                MoTa = moTa,
                DiaChi = diaChi,
                ThongTinLH = thongTinLH,
                TenTaiKhoan = tenTaiKhoan,
                ThoiGianDang = thoiGianDang,
                MaSP = maSP
            };
            // Tạo một Label mới với hình ảnh đồng xu
           
            // Thêm sự kiện click cho ImageUC
            imageUC.OnSelect += (sender, e) =>
            {
                // Hiển thị thông tin sản phẩm trong các ô bên cạnh
                ptbPicture ttsp = new ptbPicture(mainForm, this)
                {
                    TenDangNhap = TenDangNhap,
                    Ten = imageUC.Ten,
                    GiaBan = imageUC.GiaBan,
                    PicList = imageUC.PicList,
                    GiaLucMua = imageUC.GiaLucMua,
                    TinhTrang = imageUC.TinhTrang,
                    ThoiGian = imageUC.TGMua,
                    MoTaTinhTrang = imageUC.MoTaTinhTrang,
                    MoTa = imageUC.MoTa,
                    DiaChi = imageUC.DiaChi,
                    ThongTinLH = imageUC.ThongTinLH,
                    TenTaiKhoan = imageUC.TenTaiKhoan
                    
                };
                sanPhamDao.UpdateLuotTimKiem(imageUC.MaSP);
                ttsp.Show();
            };

            fpnlMain.Controls.Add(imageUC);
        }



        public void HienThiSanPham(string dieuKien, string giaTri)
        {
            fpnlMain.Controls.Clear();
            var sanPhams = sanPhamDao.HienThiSanPham(dieuKien, giaTri, TenDangNhap);

            foreach (var sanPham in sanPhams)
            {
                var hinhAnhs = sanPhamDao.LayHinhAnhSanPham(sanPham.MaSP);
                // Assume ThoiGianDang is being fetched properly along with other properties
                ThemSP(sanPham.TenSP, sanPham.GiaBan, hinhAnhs, sanPham.GiaLucMua, sanPham.TinhTrang, sanPham.ThoiGian, sanPham.MoTaTinhTrang, sanPham.MoTa, sanPham.DiaChi, sanPham.ThongTinLH, sanPham.TenTaiKhoan, sanPham.ThoiGianDang, sanPham.MaSP);
            }
        }
        
        public void HienThiMacDinh()
        {
            var sortedProducts = sanPhamDao.HienThiSPTheoTieuChiSapXep("Mặc định", TenDangNhap);
            DisplaySortedProducts(sortedProducts);
        }

        private void MuaHang_Shown(object sender, EventArgs e)
        {
            HienThiMacDinh();   
        }
        private void btnCongNghe_Click(object sender, EventArgs e)
        {
            HienThiSanPham("LoaiSP", "Công Nghệ");
        }

        private void btnDoGiaDung_Click(object sender, EventArgs e)
        {
            HienThiSanPham("LoaiSP", "Đồ Gia Dụng");
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            HienThiSanPham("LoaiSP", "Khác");
        }

        private void btnQuanAo_Click_1(object sender, EventArgs e)
        {
            HienThiSanPham("LoaiSP", "Quần áo");
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            HienThiSanPham("TenSP", txtTim.Text);
        }

        private void btnGiayDep_Click(object sender, EventArgs e)
        {
            HienThiSanPham("LoaiSP", "Giày dép");
        }

        private void btnLSMuaHang_Click(object sender, EventArgs e)
        {
            gvLSDonHang ls = new gvLSDonHang() {TenDangNhap = TenDangNhap };
            ls.ShowDialog();
        }

        private void btnSPQuanTam_Click(object sender, EventArgs e)
        {
            HienThiSanPham("QuanTam", "ALL");
        }

        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSapXep.SelectedItem == null) return;

            string selectedOption = cbbSapXep.SelectedItem.ToString();
            var sortedProducts = sanPhamDao.HienThiSPTheoTieuChiSapXep(selectedOption, TenDangNhap);
            DisplaySortedProducts(sortedProducts);
        }

        private void DisplaySortedProducts(List<SanPham> products)
        {
            fpnlMain.Controls.Clear();  // Xóa các controls hiện tại trong FlowLayoutPanel
            
            foreach (var sanPham in products)
            {
                var hinhAnhs = sanPhamDao.LayHinhAnhSanPham(sanPham.MaSP);
                // Gọi phương thức ThemSP để thêm từng sản phẩm vào FlowLayoutPanel
                ThemSP(sanPham.TenSP, sanPham.GiaBan, hinhAnhs, sanPham.GiaLucMua, sanPham.TinhTrang, sanPham.ThoiGian, sanPham.MoTaTinhTrang, sanPham.MoTa, sanPham.DiaChi, sanPham.ThongTinLH, sanPham.TenTaiKhoan, sanPham.ThoiGianDang, sanPham.MaSP);
            }
        }
    }

}
