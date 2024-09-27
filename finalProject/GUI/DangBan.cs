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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalProject
{
    public partial class DangBan : Form
    {
        public string TenDangNhap { get; set; }
        

        private SanPhamDao sanPhamDao;
        private List<string> selectedFiles = new List<string>();

        public DangBan()
        {
            InitializeComponent();
            sanPhamDao = new SanPhamDao();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            QLSP ql = new QLSP() {TenDangNhap = this.TenDangNhap };
            ql.ShowDialog();
        }

        private bool ValidateInput()
        {
            // Kiểm tra xem các trường có null hay rỗng không
            if (string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiSP.Text) ||
                string.IsNullOrWhiteSpace(txtGiaLucMua.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                string.IsNullOrWhiteSpace(txtTinhTrang.Text) ||
                string.IsNullOrWhiteSpace(txtThoiGian.Text) ||
                string.IsNullOrWhiteSpace(txtMTTinhTrang.Text) ||
                string.IsNullOrWhiteSpace(txtMoTaSP.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtThongTinLH.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return false;
            }

            // Kiểm tra và chuyển đổi GiaLucMua
            if (!int.TryParse(txtGiaLucMua.Text, out int giaLucMua))
            {
                MessageBox.Show("Giá lúc mua phải là số nguyên.");
                return false;
            }

            // Kiểm tra và chuyển đổi GiaBan
            if (!int.TryParse(txtGiaBan.Text, out int giaBan))
            {
                MessageBox.Show("Giá bán phải là số nguyên.");
                return false;
            }

            return true; // Tất cả điều kiện đều hợp lệ
        }

        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return; // Có lỗi xảy ra, không tiếp tục xử lý
            }

            SanPham sanPham = new SanPham()
            {
                TenSP = txtTenSP.Text,
                LoaiSP = txtLoaiSP.Text,
                GiaLucMua = int.Parse(txtGiaLucMua.Text),
                GiaBan = int.Parse(txtGiaBan.Text),
                TinhTrang = txtTinhTrang.Text,
                ThoiGian = txtThoiGian.Text,
                MoTaTinhTrang = txtMTTinhTrang.Text,
                MoTa = txtMoTaSP.Text,
                DiaChi = txtDiaChi.Text,
                ThongTinLH = txtThongTinLH.Text,
                TenTaiKhoan = TenDangNhap,
                ThoiGianDang = DateTime.Now  
            };

            List<byte[]> hinhAnhs = new List<byte[]>();
            foreach (string filePath in selectedFiles)
            {
                byte[] hinhAnh = File.ReadAllBytes(filePath);
                hinhAnhs.Add(hinhAnh);
            }

            bool isSuccess = sanPhamDao.AddSanPham(sanPham, hinhAnhs);
            if (isSuccess)
            {
                MessageBox.Show("Thêm sản phẩm và hình ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm và hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            NavigateImage(1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            NavigateImage(-1);
        }

        private void NavigateImage(int step)
        {
            if (selectedFiles.Count > 0)
            {
                int newIndex = (selectedFiles.IndexOf(pictureBox1.ImageLocation) + step + selectedFiles.Count) % selectedFiles.Count;
                pictureBox1.ImageLocation = selectedFiles[newIndex];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFiles = openFileDialog.FileNames.ToList();
                pictureBox1.ImageLocation = selectedFiles[0];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
