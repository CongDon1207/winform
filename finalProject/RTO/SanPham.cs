using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public int GiaLucMua { get; set; }
        public int GiaBan { get; set; }
        public string TinhTrang { get; set; }
        public string ThoiGian { get; set; }
        public string MoTaTinhTrang { get; set; }
        public string MoTa { get; set; }
        public string DiaChi { get; set; }
        public string ThongTinLH { get; set; }
        public string TenTaiKhoan { get; set; }
        public DateTime ThoiGianDang { get; set; }
        public List<byte[]> HinhAnh { get; set; } = new List<byte[]>();

    }
}
