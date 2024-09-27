using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject.RTO
{
    public partial class LiDoHuy : Form
    {
        public string MaNguoiBan { get; set; }
        public string TenNguoiMua { get; set; }
        public string TenSanPham { get; set; }
        public int GiaBan { get; set; }
        DonHangDao donHangDao = new DonHangDao();

        public LiDoHuy()
        {
            InitializeComponent();
        }

        private void btnGuiDi_Click(object sender, EventArgs e)
        {
            string noiDung = txtNoiDung.Text;
            donHangDao.ThemDonHangHuy(this.MaNguoiBan, this.TenNguoiMua, this.TenSanPham, this.GiaBan, noiDung);
            this.Close();
        }

    }
}
