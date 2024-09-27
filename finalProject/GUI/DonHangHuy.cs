using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject.GUI
{
    public partial class DonHangHuy : Form
    {
        public string TenDangNhap { get; set; }
        DonHangDao donHangDao = new DonHangDao();
        public DonHangHuy()
        {
            InitializeComponent();
        }

        private void DonHangHuy_Load(object sender, EventArgs e)
        {
            dtDonHangHuy.DataSource = donHangDao.LoadDonHangHuy(TenDangNhap);
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // Thiết lập font và màu sắc
            dtDonHangHuy.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dtDonHangHuy.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Đặt phông chữ in đậm cho nội dung của hàng
            dtDonHangHuy.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 240); // Floral White
            dtDonHangHuy.DefaultCellStyle.ForeColor = Color.DarkBlue; // Màu chữ xanh đậm
            dtDonHangHuy.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 149, 237); // Cornflower Blue
            dtDonHangHuy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Tạo màu xen kẽ cho các hàng
            dtDonHangHuy.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255); // Azure

            // Tự động điều chỉnh độ rộng cột
            dtDonHangHuy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tự động điều chỉnh chiều cao hàng để hiển thị hết nội dung
            dtDonHangHuy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Tạo dòng tiêu đề bảng không theo kiểu mặc định
            dtDonHangHuy.EnableHeadersVisualStyles = false;
            dtDonHangHuy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtDonHangHuy.AllowUserToAddRows = false;

            // Đổi tên tiêu đề cột sang tiếng Việt
            dtDonHangHuy.Columns["MaNguoiMua"].HeaderText = "Mã Người Mua";
            dtDonHangHuy.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dtDonHangHuy.Columns["GiaBan"].HeaderText = "Giá Bán";
            dtDonHangHuy.Columns["ThoiGianHuy"].HeaderText = "Thời Gian Hủy";
            dtDonHangHuy.Columns["NoiDungHuy"].HeaderText = "Lý Do Hủy";

            // Đảm bảo các ô wrap text nếu nội dung quá dài
            dtDonHangHuy.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
