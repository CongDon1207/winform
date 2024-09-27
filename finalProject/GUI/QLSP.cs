using finalProject.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace finalProject
{
    public partial class QLSP : Form
    {
        private SanPhamDao sanPhamDao;
        public string TenDangNhap {get; set;}
        SqlConnection conn1 = new SqlConnection("Data Source=LAPTOP-M10LPRA9\\CONGDON;Initial Catalog=QLSanPham;Integrated Security=True;Encrypt=false");

        public QLSP()
        {
            InitializeComponent();
            sanPhamDao = new SanPhamDao();
        }

        private void Load_Table()
        {
            DataTable dt = sanPhamDao.LoadSanPham(TenDangNhap);
            dtQLSP.DataSource = dt;
        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            conn1.Open();
            Load_Table();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dtQLSP.Columns["MaSP"].Visible = true;
            dtQLSP.Columns["TenSP"].Visible = true;
            dtQLSP.Columns["LoaiSP"].Visible = true;
            dtQLSP.Columns["GiaLucMua"].Visible = true;
            dtQLSP.Columns["GiaBan"].Visible = true;

            // Ẩn các cột không cần hiển thị
            dtQLSP.Columns["TinhTrang"].Visible = false;
            dtQLSP.Columns["ThoiGian"].Visible = false;
            dtQLSP.Columns["MoTaTinhTrang"].Visible = false;
            dtQLSP.Columns["MoTa"].Visible = false;
            dtQLSP.Columns["DiaChi"].Visible = false;
            dtQLSP.Columns["ThongTinLH"].Visible = false;
            dtQLSP.Columns["TenTaiKhoan"].Visible = false;

            // Cấu hình tiêu đề cột sang tiếng Việt
            dtQLSP.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dtQLSP.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dtQLSP.Columns["LoaiSP"].HeaderText = "Loại Sản Phẩm";
            dtQLSP.Columns["GiaLucMua"].HeaderText = "Giá Lúc Mua";
            dtQLSP.Columns["GiaBan"].HeaderText = "Giá Bán";
            dtQLSP.Columns["ThoiGianDang"].HeaderText = "Thời Gian Đăng";
            dtQLSP.Columns["LuotTimKiem"].HeaderText = "Lượt Tìm Kiếm";

            // Thiết lập font và màu sắc
            dtQLSP.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dtQLSP.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Đặt phông chữ in đậm cho nội dung của hàng
            dtQLSP.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 240); // Floral White
            dtQLSP.DefaultCellStyle.ForeColor = Color.DarkBlue; // Màu chữ xanh đậm
            dtQLSP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 149, 237); // Cornflower Blue
            dtQLSP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Tạo màu xen kẽ cho các hàng
            dtQLSP.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255); // Azure

            // Tùy chỉnh khác
            dtQLSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtQLSP.EnableHeadersVisualStyles = false;
            dtQLSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtQLSP.AllowUserToAddRows = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtQLSP.CurrentRow != null)
            {
                int maSP = Convert.ToInt32(dtQLSP.CurrentRow.Cells["MaSP"].Value);
                sanPhamDao.XoaSanPham(maSP);
                Load_Table();
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtQLSP.CurrentRow != null)
            {
                int maSP = Convert.ToInt32(dtQLSP.CurrentRow.Cells["MaSP"].Value);
                // Trích xuất dữ liệu sản phẩm bằng maSP từ cơ sở dữ liệu hoặc thông qua đối tượng
                SanPham sanPham = sanPhamDao.GetSanPhamById(maSP);

                ChinhSuaTT chinhSuaTT = new ChinhSuaTT()
                {
                    MaSP = sanPham.MaSP,
                    Ten = sanPham.TenSP,
                    LoaiSP = sanPham.LoaiSP,
                    GiaLucMua = sanPham.GiaLucMua,
                    GiaBan = sanPham.GiaBan,
                    TinhTrang = sanPham.TinhTrang,
                    ThoiGian = sanPham.ThoiGian,
                    MoTaTinhTrang = sanPham.MoTaTinhTrang,
                    MoTa = sanPham.MoTa,
                    DiaChi = sanPham.DiaChi,
                    ThongTinLH = sanPham.ThongTinLH
                };
                chinhSuaTT.ShowDialog();

                // Gọi hàm để tải lại dữ liệu cho dtQLSP
                Load_Table();
            }
        }

        private void btnDonHangBiHuy_Click(object sender, EventArgs e)
        {
            DonHangHuy donHangHuy = new DonHangHuy() {TenDangNhap = this.TenDangNhap };
            donHangHuy.ShowDialog();
        }
    }
}
