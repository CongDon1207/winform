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
    public partial class LSGiaoDich : Form
    {
        private NapRutDao napRutDao = new NapRutDao();
        public LSGiaoDich()
        {
            InitializeComponent();
        }
        
        private void LSGiaoDich_Load(object sender, EventArgs e)
        {
            try
            {   
                gvLSGiaoDich.DataSource = napRutDao.GetAllGiaoDich();
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load transaction records: " + ex.Message);
            }
            
        }

        private void ConfigureDataGridView()
        {
            // Thiết lập font chung
            gvLSGiaoDich.DefaultCellStyle.Font = new Font("Arial", 10);
            gvLSGiaoDich.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Thiết lập in đậm cho nội dung các hàng
            gvLSGiaoDich.DefaultCellStyle.Font = new Font(gvLSGiaoDich.Font, FontStyle.Bold);

            // Màu nền dịu cho hàng
            gvLSGiaoDich.DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 238); // Màu Seashell
            gvLSGiaoDich.DefaultCellStyle.ForeColor = Color.FromArgb(105, 105, 105); // Màu DimGray

            // Màu nền và màu chữ cho tiêu đề cột
            gvLSGiaoDich.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(176, 224, 230);
            gvLSGiaoDich.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                                                                                           

            // Tự động điều chỉnh độ rộng cột
            gvLSGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tạo dòng tiêu đề bảng
            gvLSGiaoDich.EnableHeadersVisualStyles = false;
            gvLSGiaoDich.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Cài đặt khác
            gvLSGiaoDich.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvLSGiaoDich.AllowUserToAddRows = false;

            // Đổi tên tiêu đề cột sang tiếng Việt
            gvLSGiaoDich.Columns["IDGiaoDich"].HeaderText = "ID Giao Dịch";
            gvLSGiaoDich.Columns["SoTaiKhoan"].HeaderText = "Số Tài Khoản";
            gvLSGiaoDich.Columns["ChiNhanh"].HeaderText = "Chi Nhánh";
            gvLSGiaoDich.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            gvLSGiaoDich.Columns["SoXu"].HeaderText = "Số Xu";
            gvLSGiaoDich.Columns["ThoiGianGiaoDich"].HeaderText = "Thời Gian";
        }
    }
}
