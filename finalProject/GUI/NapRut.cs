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
    public partial class NapRut : Form
    {
        private MainForm mainForm;
        private NapRutDao napRutDao = new NapRutDao();
        public string TenDangNhap { get; set; }
        public NapRut(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            this.txtSoTaiKhoan.TextChanged += new System.EventHandler(this.txtSoTaiKhoan_TextChanged);
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBranch = cbChiNhanh.SelectedItem.ToString();
            var imageBytes = napRutDao.GetBankBranchImage(selectedBranch);

            if (imageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    ptbChiNhanh.Image = Image.FromStream(ms);
                }
            }
            else
            {
                ptbChiNhanh.Image = null; // Hiển thị một hình ảnh mặc định hoặc để trống
            }
        }

        private void txtSoTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            string chiNhanh = cbChiNhanh.Text;
            string soTaiKhoan = txtSoTaiKhoan.Text;
            string tenTaiKhoan = napRutDao.GetAccountNameByAccountNumber(chiNhanh, soTaiKhoan);
            txtTenTaiKhoan.Text = tenTaiKhoan;
        }

        private string ValidateInputs()
        {
            string soTaiKhoan = txtSoTaiKhoan.Text;
            string chiNhanh = cbChiNhanh.SelectedItem?.ToString();  // Sử dụng ? để tránh NullReferenceException
            string tinhTrang = cbChon.SelectedItem?.ToString();
            string tenTaiKhoan = txtTenTaiKhoan.Text;// Tương tự như trên

            // Kiểm tra xem các trường có null hay không
            if (string.IsNullOrWhiteSpace(soTaiKhoan) || chiNhanh == null || tinhTrang == null)
            {
                return "Vui lòng điền đầy đủ thông tin.";
            }

            if (string.IsNullOrWhiteSpace(tenTaiKhoan))
            {
                return "Số tài khoản hoặc chi nhánh chưa đúng";
            }

            // Kiểm tra xem số tài khoản chỉ chứa số
            if (!soTaiKhoan.All(char.IsDigit))
            {
                return "Số tài khoản phải là số.";
            }

            // Kiểm tra và chuyển đổi số Xu
            if (!int.TryParse(txtXu.Text, out int soXu))
            {
                return "Số Xu phải là số nguyên.";
            }

            if (tinhTrang == "Rút tiền" && soXu > napRutDao.GetCurrentBalance(TenDangNhap))
            {
                return "Số xu rút không thể lớn hơn số xu hiện có!";
            }

            return "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string errorMsg = ValidateInputs();
            if (!string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(errorMsg);
                return;
            }

            DateTime thoiGianGiaoDich = DateTime.Now;
            int soXu = int.Parse(txtXu.Text); // Nếu đến đây, ta đã chắc chắn txtXu.Text có thể được chuyển đổi thành int
            bool success = napRutDao.ProcessTransaction(TenDangNhap, txtSoTaiKhoan.Text, cbChiNhanh.SelectedItem.ToString(), cbChon.SelectedItem.ToString(), soXu, thoiGianGiaoDich);
            if (success)
            {
                mainForm?.CapNhatSoXu();
                mainForm.ViTriXu();
                MessageBox.Show("Giao dịch và cập nhật Xu thành công!");
            }
            else
            {
                MessageBox.Show("Giao dịch thất bại hoặc Số tài khoản không tồn tại!");
            }
        }

        private void btnLSGD_Click(object sender, EventArgs e)
        {
            LSGiaoDich lsgd = new LSGiaoDich();
            lsgd.ShowDialog();
        }
    }
}
