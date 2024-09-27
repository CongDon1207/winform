using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace finalProject
{
    public class TaiKhoan
    {
        public string TenTaiKhoan { get; set; }
        public string TenNguoiDung { get; set; }
        public string MatKhau { get; set; }
        public int Xu { get; set; }
        public string CMND { get; set; }
        public string SoDT { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte[] AnhDaiDien { get; set; }
    }
}
