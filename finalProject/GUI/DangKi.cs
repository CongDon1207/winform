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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }
        private string KiemTraDuLieu()
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) ||
                string.IsNullOrEmpty(txtTen.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) ||
                string.IsNullOrEmpty(txtCMND.Text) ||
                string.IsNullOrEmpty(txtSoDT.Text) ||
                txtGioiTinh.SelectedItem == null)
            {
                return "Vui lòng điền đầy đủ thông tin.";
            }

            // Kiểm tra tên tài khoản phải ghi liền, không có khoảng trắng
            if (txtTenDangNhap.Text.Contains(" "))
            {
                return "Tên tài khoản không được chứa khoảng trắng.";
            }

            // Kiểm tra CMND phải toàn số
            if (!txtCMND.Text.All(char.IsDigit))
            {
                return "CMND phải là số.";
            }

            // Kiểm tra số điện thoại phải toàn số và đủ 10 số
            if (!txtSoDT.Text.All(char.IsDigit) || txtSoDT.Text.Length != 10)
            {
                return "Số điện thoại phải là 10 chữ số.";
            }

            return ""; // Trả về chuỗi rỗng nếu không có lỗi
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string result = KiemTraDuLieu();

            if (!String.IsNullOrEmpty(result)) // Nếu có lỗi
            {
                MessageBox.Show(result);
                return;
            }

            TaiKhoan taiKhoan = new TaiKhoan()
            {
                TenTaiKhoan = txtTenDangNhap.Text,
                TenNguoiDung = txtTen.Text,
                MatKhau = txtMatKhau.Text,
                Xu = 0, // Giả sử Xu mặc định là 0 khi tạo mới tài khoản
                CMND = txtCMND.Text,
                SoDT = txtSoDT.Text,
                GioiTinh = txtGioiTinh.SelectedItem.ToString(),
                NgaySinh = dtpNgaySinh.Value
            };

            TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
            bool isSuccess = taiKhoanDao.ThemTaiKhoan(taiKhoan);

            if (isSuccess)
            {
                MessageBox.Show("Đăng ký tài khoản thành công.");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.");
            }
        }

    }
}
