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
    public partial class CaNhan : Form
    {
        private TaiKhoanDao taiKhoanDao;
        public string TenDangNhap { get; set; }
        private MainForm mainForm;
        public CaNhan(MainForm main)
        {
            InitializeComponent();

            taiKhoanDao = new TaiKhoanDao();
            this.mainForm = main;
        }

        private void CaNhan_Load(object sender, EventArgs e)
        {
            HienThiTT(TenDangNhap);
            HienThiAnh(TenDangNhap);
        }

        public void HienThiTT(string tenDangNhap)
        {
            TaiKhoan taiKhoan = taiKhoanDao.LayThongTinTaiKhoan(TenDangNhap);
            if (taiKhoan != null)
            {
                // Hiển thị thông tin cơ bản
                txtTen.Text = taiKhoan.TenNguoiDung;
                txtTenTaiKhoan.Text = taiKhoan.TenTaiKhoan;
                txtCMND.Text = taiKhoan.CMND;
                txtSoDT.Text = taiKhoan.SoDT;
                txtGioiTinh.SelectedItem = taiKhoan.GioiTinh; 
                dtpNgaySinh.Value = taiKhoan.NgaySinh;

                // Hiển thị ảnh đại diện
                if (taiKhoan.AnhDaiDien != null && taiKhoan.AnhDaiDien.Length > 0)
                {
                    using (var ms = new MemoryStream(taiKhoan.AnhDaiDien))
                    {
                        ptbAnhDaiDien.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbAnhDaiDien.Image = null; 
                }
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tải ảnh lên PictureBox
                ptbAnhDaiDien.Image = Image.FromFile(openFileDialog.FileName);

                // Chuyển ảnh từ PictureBox thành mảng byte
                MemoryStream ms = new MemoryStream();
                ptbAnhDaiDien.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] anh = ms.ToArray();
                ms.Close();

                // Cập nhật ảnh vào cơ sở dữ liệu
                taiKhoanDao.CapNhatAnh(TenDangNhap, anh);
            }
            mainForm.HienThiAnh(TenDangNhap);
        }

        private void HienThiAnh(string tenDangNhap)
        {
            byte[] anh = taiKhoanDao.HienThiAnh(tenDangNhap);
            ptbAnhDaiDien.Image = taiKhoanDao.ByteThanhImage(anh);
            
        }

        

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                TenTaiKhoan = txtTenTaiKhoan.Text,
                TenNguoiDung = txtTen.Text,
                CMND = txtCMND.Text,
                GioiTinh = txtGioiTinh.SelectedItem.ToString(),
                SoDT = txtSoDT.Text,
                NgaySinh = dtpNgaySinh.Value,
            };

            if (taiKhoanDao.CapNhatTaiKhoan(taiKhoan))
            {
                MessageBox.Show("Cập nhật thông tin thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.");
            }
        }

        private void lblDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            taiKhoanDao.XoaAnh(TenDangNhap);
            ptbAnhDaiDien.Image = null; // Xóa ảnh hiện tại trên PictureBox
        }
    }
}
