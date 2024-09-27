using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class UCTheDanhGia : UserControl
    {
        public UCTheDanhGia()
        {
            InitializeComponent();
        }
        public string TenNguoiDanhGia
        {
            get { return lblTen.Text; }
            set { lblTen.Text = value; }
        }

        // Thuộc tính cho số Sao đánh giá
        public decimal SoSaoDanhGia
        {
            get { return (decimal)rtsSao.Value; } // Chuyển đổi từ kiểu dữ liệu của Value sang float
            set { rtsSao.Value = (float)value; } // Chuyển đổi từ float sang decimal nếu cần
        }


        // Thuộc tính cho Nội dung đánh giá
        public string NoiDungDanhGia
        {
            get { return txtNoiDung.Text; }
            set { txtNoiDung.Text = value; }
        }

        public Image AnhDaiDien
        {
            get { return ptbAnhDaiDien.Image; }
            set { ptbAnhDaiDien.Image = value; }
        }
    }
}
