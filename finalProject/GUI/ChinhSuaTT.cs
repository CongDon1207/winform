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
    public partial class ChinhSuaTT : Form
    {
        public int MaSP {  get; set; }
        public string Ten { get; set; }
        public string LoaiSP { get; set; }
        public int GiaLucMua { get; set; }
        public int GiaBan { get; set; }
        public string TinhTrang { get; set; }
        public string ThoiGian { get; set; }
        public string MoTaTinhTrang { get; set; }
        public string MoTa { get; set; }
        public string DiaChi { get; set; }
        public string ThongTinLH { get; set; }
        private SanPhamDao sanPhamDao;

        public ChinhSuaTT()
        {
            InitializeComponent();
            sanPhamDao = new SanPhamDao();
        }

        private void ChinhSuaTT_Load(object sender, EventArgs e)
        {
            List<Image> listHinhAnh = sanPhamDao.LoadHinhAnh(MaSP);
            if (listHinhAnh.Count > 0)
            {
                pictureBox1.Image = listHinhAnh[0]; // Hiển thị hình ảnh đầu tiên
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            // Thiết lập các trường thông tin sản phẩm từ các thuộc tính đã được truyền vào
            txtMaSP.Text = MaSP.ToString();
            txtTenSP.Text = Ten;
            txtLoaiSP.Text = LoaiSP;
            txtGiaLucMua.Text = GiaLucMua.ToString();
            txtGiaBan.Text = GiaBan.ToString();
            txtTinhTrang.Text = TinhTrang;
            txtThoiGian.Text = ThoiGian;
            txtMTTinhTrang.Text = MoTaTinhTrang;
            txtMoTaSP.Text = MoTa;
            txtDiaChi.Text = DiaChi;
            txtThongTinLH.Text = ThongTinLH;

        }
        List<string> selectedFiles = new List<string>();
        private void gunaButton1_Click(object sender, EventArgs e)
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham()
            {
                MaSP = int.Parse(txtMaSP.Text),
                TenSP = txtTenSP.Text,
                LoaiSP = txtLoaiSP.Text,
                GiaLucMua = int.Parse(txtGiaLucMua.Text),
                GiaBan = int.Parse(txtGiaBan.Text),
                TinhTrang = txtTinhTrang.Text,
                ThoiGian = txtThoiGian.Text,
                MoTaTinhTrang = txtMTTinhTrang.Text,
                MoTa = txtMoTaSP.Text,
                DiaChi = txtDiaChi.Text,
                ThongTinLH = txtThongTinLH.Text
            };

            List<byte[]> hinhAnhs = new List<byte[]>();
            foreach (string filePath in selectedFiles)
            {
                byte[] hinhAnh = File.ReadAllBytes(filePath); // Chuyển file ảnh thành mảng byte
                hinhAnhs.Add(hinhAnh);
            }

            // Cập nhật sản phẩm và thêm hình ảnh mới vào cơ sở dữ liệu
            bool isSuccess = sanPhamDao.UpdateSanPham(sanPham, hinhAnhs);
            if (isSuccess)
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm và hình ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật thông tin sản phẩm và hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
