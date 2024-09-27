using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace finalProject
{
    public partial class DSNguoiMua : Form
    {
        public string TenDangNhap { get; set; }
        KhachHangDao khachHangDao = new KhachHangDao();

        public DSNguoiMua()
        {
            InitializeComponent();
        }
        
        private void DSNguoiMua_Load(object sender, EventArgs e)
        {
            HienThiKH();
        }
        
        private void HienThiKH()
        {
            var khachHangs = khachHangDao.HienThiKhachHang(TenDangNhap);
            fpnlMain.Controls.Clear(); // Clear existing controls

            foreach (var kh in khachHangs)
            {
                UCKhachHang uCKhachHang = new UCKhachHang()
                {
                    TenKhachHang = kh.TenKhachHang,
                    SoLanMua = kh.SoLanMua,
                    AnhDaiDien = kh.AnhDaiDien,
                    SoDienThoai = kh.SoDienThoai
                };
                fpnlMain.Controls.Add(uCKhachHang);
            }
        }
    }
}
