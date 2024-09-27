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
    public partial class DoiMatKhau : Form
    {
        private TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
        public DoiMatKhau()
        {
            InitializeComponent();
            this.btnXacNhan.Click += new EventHandler(this.btnXacNhan_Click);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenDangNhap = this.txtTenDangNhap2.Text;
            string matKhauHienTai = this.txtMatKhauHienTai.Text;
            string matKhauMoi = this.txtMatKhauMoi.Text;
            string nhapLaiMatKhauMoi = this.txtNhapMatKhauMoi.Text;

            if (matKhauMoi != nhapLaiMatKhauMoi)
            {
                MessageBox.Show("Mật khẩu mới nhập lại không khớp.");
                return;
            }

            if (taiKhoanDao.KiemTraMatKhau(tenDangNhap, matKhauHienTai))
            {
                if (taiKhoanDao.CapNhatMatKhau(tenDangNhap, matKhauMoi))
                {
                    MessageBox.Show("Đổi mật khẩu thành công.");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình đổi mật khẩu.");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu hiện tại không đúng.");
            }
        }
    }
}
