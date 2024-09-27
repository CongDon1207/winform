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
using System.Windows.Forms.DataVisualization.Charting;

namespace finalProject
{
    public partial class XemDanhGia : Form
    {
        public string TenDangNhap { get; set; }
        public string TenTaiKhoan { get; set; }
        private TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
        private DanhGiaDao danhGiaDao = new DanhGiaDao();

        public XemDanhGia()
        {
            InitializeComponent();
        }

        private void XemDanhGia_Load(object sender, EventArgs e)
        {
            ptbAnh.Image = taiKhoanDao.ByteThanhImage(taiKhoanDao.HienThiAnh(TenTaiKhoan));
            lblTen.Text = taiKhoanDao.LayTenNguoiDung(TenTaiKhoan);
            lblLuot.Text = danhGiaDao.DemSoLuongDanhGia(TenTaiKhoan).ToString();
            CauHinhBieuDo();
            LoadDanhGia();
        }

        private void CauHinhBieuDo()
        {
            // Lấy dữ liệu thống kê
            Dictionary<int, int> thongKeDanhGia = danhGiaDao.LaySoLuongDanhGiaTheoSao(TenTaiKhoan);
            //chartDanhGia.BackColor = Color.LightGray;
            chartDanhGia.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Gold;
            //chartDanhGia.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.LightYellow;
            //chartDanhGia.ChartAreas[0].AxisX.LineColor = Color.LightYellow;
            chartDanhGia.ChartAreas[0].AxisY.LineColor = Color.DarkGray;
            // Xóa các series trước đó để không bị chồng chéo khi cập nhật dữ liệu mới
            chartDanhGia.Series.Clear();
            chartDanhGia.Legends.Clear();
            chartDanhGia.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartDanhGia.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartDanhGia.ChartAreas[0].RecalculateAxesScale();

            // Tạo mới series cho biểu đồ
            Series series = chartDanhGia.Series.Add("Số Lượt Đánh Giá");
            series.ChartType = SeriesChartType.Bar; // Kiểu biểu đồ cột
            series.Color = Color.Gold; // Thiết lập màu sắc cho series

            // Hiển thị giá trị số trên mỗi cột
            series.IsValueShownAsLabel = true; // Hiển thị giá trị trên mỗi cột

            // Thêm dữ liệu vào series
            foreach (var item in thongKeDanhGia)
            {
                string label = item.Key + " ★";
                series.Points.AddXY(label, item.Value);
            }

            // Cấu hình tiêu đề trục X
            chartDanhGia.ChartAreas[0].AxisX.Title = "Số Sao";
            chartDanhGia.ChartAreas[0].AxisX.TitleFont = new Font("Tahoma", 10, FontStyle.Bold);

            // Cấu hình tiêu đề trục Y
            chartDanhGia.ChartAreas[0].AxisY.Title = "Số Lượt Đánh Giá";
            chartDanhGia.ChartAreas[0].AxisY.TitleFont = new Font("Tahoma", 10, FontStyle.Bold);
            chartDanhGia.ChartAreas[0].RecalculateAxesScale();
        }

        public Image LayAnhDaiDien(string tenTaiKhoan)
        {
            byte[] bytes = taiKhoanDao.HienThiAnh(tenTaiKhoan);
            return taiKhoanDao.ByteThanhImage(bytes);
        }

        private void LoadDanhGia()
        {
            fpnlBinhLuan.Controls.Clear(); 
            var danhGias = danhGiaDao.LayDanhGia(TenTaiKhoan);

            foreach (var danhGia in danhGias)
            {
                UCTheDanhGia theDanhGia = new UCTheDanhGia
                {
                    TenNguoiDanhGia = taiKhoanDao.LayTenNguoiDung(danhGia.TKDanhGia),
                    SoSaoDanhGia = danhGia.SoSao,
                    NoiDungDanhGia = danhGia.NoiDung,
                    AnhDaiDien = taiKhoanDao.ByteThanhImage(taiKhoanDao.HienThiAnh(danhGia.TKDanhGia)) // Giả định rằng HienThiAnh trả về byte[] và ByteThanhImage chuyển đổi nó thành Image
                };

                fpnlBinhLuan.Controls.Add(theDanhGia);
            }
        }
    }
}
