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
    public partial class DanhGia : Form
    {
        public string TenNguoiBan { get; set; }
        public string TenSanPham { get; set; }
        public string TenDangNhap { get; set; }
        private DonHangDao donHangDao = new DonHangDao();
        private TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
        private DanhGiaDao danhGiaDao = new DanhGiaDao();

        public DanhGia()
        {
            InitializeComponent();
            
        }

        private void HienThiAnhDaiDien()
        {
            string tenTaiKhoan = donHangDao.LayMaNguoiBan(TenNguoiBan, TenSanPham); 
            byte[] anhDaiDien = taiKhoanDao.HienThiAnh(tenTaiKhoan); 

            if (anhDaiDien != null)
            {
                ptbAnhDaiDien.Image = taiKhoanDao.ByteThanhImage(anhDaiDien); // Chuyển đổi byte[] thành Image
            }
            else
            {
                ptbAnhDaiDien.Image = null; // Xóa ảnh hiện tại nếu không có ảnh đại diện
            }
        }

        private void DanhGia_Load(object sender, EventArgs e)
        {
            HienThiAnhDaiDien();
            lblTenNguoiBan.Text = TenNguoiBan;
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            decimal soSao = Convert.ToDecimal(rtsSoSao.Value); // Giả sử rtsSoSao là control RatingStar
            string noiDung = txtNoiDung.Text;
            string maNguoiBan = donHangDao.LayMaNguoiBan(TenNguoiBan, TenSanPham); 

            danhGiaDao.LuuDanhGia(maNguoiBan, TenNguoiBan, TenDangNhap, soSao, noiDung);
            MessageBox.Show("Đánh giá đã được lưu.");
        }
    }
}
