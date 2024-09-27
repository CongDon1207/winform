using Guna.UI.WinForms;
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
    public partial class MainForm : Form
    {
        TaiKhoanDao taiKhoanDao = new TaiKhoanDao();

        public string TenDangNhap { get; set; }
        private Form curForm;

        public MainForm()
        {
            InitializeComponent();
        }
        

        public void OpenChildForm(Form childForm)
        {
            if (curForm != null)
            {
                curForm.Close();
            }
            curForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MuaHang(this) { TenDangNhap = this.TenDangNhap });
        }



        private void Button_Click(object sender, EventArgs e)
        {
            // Xác định và mở form tương ứng với nút được nhấn
            
            if (sender == btnMuaHang)
            {
                OpenChildForm(new MuaHang(this) { TenDangNhap = this.TenDangNhap });
            }
            else if (sender == btnDangBan)
            {
                OpenChildForm(new DangBan() { TenDangNhap = this.TenDangNhap });
            }
            else if (sender == btnNapRut)
            {
                OpenChildForm(new NapRut(this) { TenDangNhap = this.TenDangNhap });
            }
            else if (sender == btnThongTin)
            {
                OpenChildForm(new CaNhan(this) { TenDangNhap = this.TenDangNhap });
            }
            else if (sender == btnDanhGia)
            {
                OpenChildForm(new XemDanhGia() { TenTaiKhoan = this.TenDangNhap });
            }
            else if (sender == btnKhachHang)
            {
                OpenChildForm(new DSNguoiMua() { TenDangNhap = this.TenDangNhap });
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new MuaHang(this) { TenDangNhap = this.TenDangNhap });
            lblTenNguoiDung.Text = taiKhoanDao.LayTenNguoiDung(TenDangNhap);
            lblXu.Text = taiKhoanDao.LaySoXu(TenDangNhap).ToString();
            ViTriXu();
            HienThiAnh(TenDangNhap);
        }

        public void CapNhatSoXu()
        {
            // Gọi phương thức Lấy số xu từ TaiKhoanDao
            int soXuMoi = taiKhoanDao.LaySoXu(TenDangNhap);
            lblXu.Text = soXuMoi.ToString(); // Cập nhật số xu trên giao diện
        }

        public void HienThiAnh(string tenDangNhap)
        {
            byte[] anh = taiKhoanDao.HienThiAnh(tenDangNhap);
            ptbAnhDaiDien.Image = taiKhoanDao.ByteThanhImage(anh);
        }

        public void ViTriXu()
        {
            ptbCoin.Location = new Point(lblXu.Location.X + lblXu.Width + 10, lblXu.Location.Y);
        }

        private void lblXu_TextChanged(object sender, EventArgs e)
        {
            ViTriXu();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
