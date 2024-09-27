using Guna.UI.Animation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class ImageUC : UserControl
    {
        // Khai bao thuoc tinh
        public event EventHandler OnSelect = null;
        public string TinhTrang,TGMua, MoTaTinhTrang, MoTa, ThongTinLH, TenTaiKhoan;
        public int GiaLucMua;
        public int MaSP;
        public string Ten { get => lblTen.Text; set => lblTen.Text = value; }
        public int GiaBan;
        public string DiaChi { get => lblDiaChi.Text; set => lblDiaChi.Text = value; }
        public DateTime ThoiGianDang
        {
            get
            {
                // Sử dụng định dạng "dd/MM/yyyy hh:mm tt" để phân tích chuỗi ngày giờ
                if (DateTime.TryParseExact(lblThoiGian.Text, "dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                {
                    return result;
                }
                return DateTime.MinValue; // Trả về giá trị mặc định nếu không phân tích được
            }
            set
            {
                // Cập nhật định dạng của chuỗi ngày giờ khi thiết lập giá trị
                lblThoiGian.Text = value.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
            }
        }



        public (int GiaBan, int GiaMua) Gia
        {
            get
            {
                string[] parts = lblGia.Text.Split('/');
                if (parts.Length == 2 &&
                    int.TryParse(parts[0], out int giaBan) &&
                    int.TryParse(parts[1], out int giaMua))
                {
                    return (giaBan, giaMua);
                }
                return (0, 0); // Trả về tuple với giá trị mặc định nếu có lỗi
            }
            set
            {
                // Cập nhật giá trị của lblGia dưới dạng "giaBan/giaMua"
                lblGia.Text = $"{value.GiaBan}/{value.GiaMua}";
            }
        }
        
        public List<Image> PicList { get; set; }

        public Image Pic
        {
            get
            {
                if (PicList != null && PicList.Count > 0)
                {
                    // Trả về hình ảnh đầu tiên trong danh sách
                    return PicList[0];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (PicList == null)
                {
                    PicList = new List<Image>();
                }
                PicList.Insert(0, value);
                imgPic.Image = PicList[0];
            }
        }



        public ImageUC(int giaBan, int giaLucMua)
        {
            InitializeComponent();
            Gia = (giaBan, giaLucMua);
            CreatePicCoin();
            CreatePicTime();
            CreatePicLocation();
        }


        // Tạo một Label mới với hình ảnh đồng xu
        private void CreatePicCoin()
        {
            PictureBox picCoin = new PictureBox
            {
                Image = Image.FromFile("C:/Users/PC/OneDrive/Pictures/icon/dollar.png"), // Đường dẫn đến file hình ảnh đồng xu
                SizeMode = PictureBoxSizeMode.Zoom, // Điều chỉnh kích thước hình ảnh để vừa với PictureBox
                Size = new Size(20, 20), // Kích thước của icon
                Location = new Point(lblGia.Right, lblGia.Top + (lblGia.Height - 20) / 2) // Vị trí của icon
            };

            // Thêm PictureBox vào UserControl
            this.Controls.Add(picCoin);

            // Đặt PictureBox lên trên Label
            picCoin.BringToFront();
        }

        private void CreatePicLocation()
        {
            PictureBox picLoc = new PictureBox
            {
                Image = Image.FromFile("C:/Users/PC/OneDrive/Pictures/icon3/placeholder.png"), // Đường dẫn đến file hình ảnh đồng xu
                SizeMode = PictureBoxSizeMode.Zoom, // Điều chỉnh kích thước hình ảnh để vừa với PictureBox
                Size = new Size(15, 15), // Kích thước của icon
                Location = new Point(lblDiaChi.Location.X - 18, lblDiaChi.Location.Y + (lblDiaChi.Height - 45) / 2) // Vị trí của icon
            };

            // Thêm PictureBox vào UserControl
            this.Controls.Add(picLoc);

            // Đặt PictureBox lên trên Label
            picLoc.BringToFront();
        }

        private void CreatePicTime()
        {
            PictureBox picTime = new PictureBox
            {
                Image = Image.FromFile("C:/Users/PC/OneDrive/Pictures/icon3/clock.png"), // Đường dẫn đến file hình ảnh đồng xu
                SizeMode = PictureBoxSizeMode.Zoom, // Điều chỉnh kích thước hình ảnh để vừa với PictureBox
                Size = new Size(15, 15), // Kích thước của icon
                Location = new Point(lblThoiGian.Location.X - 15, lblThoiGian.Location.Y + (lblThoiGian.Height - 23) / 2) // Vị trí của icon
            };

            // Thêm PictureBox vào UserControl
            this.Controls.Add(picTime);

            // Đặt PictureBox lên trên Label
            picTime.BringToFront();
        }

        private static ImageUC selectedImageUC = null;

        private void HandleClick(object sender, EventArgs e)
        {
            // Đặt lại màu nền của ImageUC được chọn trước đó
            if (selectedImageUC != null)
            {
                selectedImageUC.BackColor = Color.White; // hoặc màu mặc định của bạn
            }

            // Cập nhật ImageUC được chọn hiện tại
            selectedImageUC = this;

            // Thay đổi màu nền của ImageUC được chọn hiện tại
            this.BackColor = Color.LightGray;

            // Gọi sự kiện OnSelect
            OnSelect?.Invoke(this, e);
        }

        private void ImageUC_Click(object sender, EventArgs e)
        {
            HandleClick(sender, e);
        }

        private void imgPic_Click(object sender, EventArgs e)
        {
            HandleClick(sender, e);
        }

        private void lblTen_Click(object sender, EventArgs e)
        {
            HandleClick(sender, e);
        }

        private void lblGia_Click(object sender, EventArgs e)
        {
            HandleClick(sender, e);
        }
    }
}
