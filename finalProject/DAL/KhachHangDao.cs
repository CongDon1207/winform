using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class KhachHangDao
    {
        private TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
        private string connectionString = Properties.Settings.Default.conn.ToString();

        public List<KhachHang> HienThiKhachHang(string tenDangNhap)
        {
            List<KhachHang> khachHangs = new List<KhachHang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE TenTaiKhoan = @TenDangNhap ORDER BY SoLanMua DESC", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    KhachHang kh = new KhachHang()
                    {
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        SoLanMua = int.Parse(reader["SoLanMua"].ToString()),
                        AnhDaiDien = taiKhoanDao.ByteThanhImage(taiKhoanDao.HienThiAnh(reader["TenKhachHang"].ToString())),
                        SoDienThoai = taiKhoanDao.TimSDT(reader["TenKhachHang"].ToString())
                    };
                    khachHangs.Add(kh);
                }
            }
            return khachHangs;
        }

        public void LuuKhachHang(string tenTaiKhoan, string tenKhachHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand updateCmd = new SqlCommand("UPDATE KhachHang SET SoLanMua = SoLanMua + 1 WHERE TenTaiKhoan = @TenTaiKhoan and TenKhachHang = @TenKhachHang", conn);
                updateCmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                updateCmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);

                // Thực thi lệnh cập nhật và lấy số hàng bị ảnh hưởng
                int rowsAffected = updateCmd.ExecuteNonQuery();

                // Nếu không có hàng nào bị ảnh hưởng, tạo bản ghi khách hàng mới
                if (rowsAffected == 0)
                {
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO KhachHang (TenTaiKhoan, TenKhachHang, SoLanMua) VALUES (@TenTaiKhoan, @TenKhachHang, 1)", conn);
                    insertCmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    insertCmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);

                    insertCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
