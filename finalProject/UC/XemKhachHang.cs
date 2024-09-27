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
    public partial class UCKhachHang : UserControl
    {
        public UCKhachHang()
        {
            InitializeComponent();
        }
        public string TenKhachHang
        {
            get { return lblTenKhachHang.Text; }
            set { lblTenKhachHang.Text = value; }
        }

        public int SoLanMua
        {
            get { return int.Parse(lblSoLanMua.Text); }
            set { lblSoLanMua.Text = value.ToString(); }
        }


        public Image AnhDaiDien
        {
            get { return ptbAnhDaiDien.Image; }
            set { ptbAnhDaiDien.Image = value; }
        }

        public string SoDienThoai
        {
            get { return lblSoDienThoai.Text; }
            set { lblSoDienThoai.Text = value.ToString(); }
        }
    }
}
