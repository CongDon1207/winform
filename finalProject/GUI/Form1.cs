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
    public partial class LoginForm : Form
    {
        private TaiKhoanDao taiKhoanDao;

        public LoginForm()
        {
            InitializeComponent();
            taiKhoanDao = new TaiKhoanDao();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            if (taiKhoanDao.KiemTraDangNhap(tenDangNhap, matKhau))
            {
                MainForm mf = new MainForm
                {
                    TenDangNhap = tenDangNhap
                };
                this.Hide();
                mf.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDangKi_Click(object sender, EventArgs e)
        {
            DangKi dangKi = new DangKi();
            dangKi.ShowDialog();
            this.Hide();
        }
    }
}
