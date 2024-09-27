using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class DanhGiaDao
    {
        private string connectionString = Properties.Settings.Default.conn.ToString();
        public int DemSoLuongDanhGia(string tenTaiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM DanhGia WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public Dictionary<int, int> LaySoLuongDanhGiaTheoSao(string tenTaiKhoan)
        {
            var ketQua = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT SoSao, COUNT(*) as SoLuong 
            FROM DanhGia 
            WHERE TenTaiKhoan = @TenTaiKhoan
            GROUP BY SoSao 
            ORDER BY SoSao";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int soSao = (int)Math.Floor(reader.GetDecimal(0));
                            int soLuong = reader.GetInt32(1);
                            ketQua[soSao] = soLuong;
                        }
                    }
                }
            }
            return ketQua;
        }

        public List<DanhGiaClass> LayDanhGia(string tenTaiKhoan)
        {
            List<DanhGiaClass> danhGias = new List<DanhGiaClass>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TKDanhGia, SoSao, NoiDung FROM DanhGia WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DanhGiaClass danhGia = new DanhGiaClass
                            {
                                TKDanhGia = reader["TKDanhGia"].ToString(),
                                SoSao = Convert.ToDecimal(reader["SoSao"]),
                                NoiDung = reader["NoiDung"].ToString()
                            };
                            danhGias.Add(danhGia);
                        }
                    }
                }
            }
            return danhGias;
        }

        public void LuuDanhGia(string maNguoiBan, string tenNguoiBan, string tkDanhGia, decimal soSao, string noiDung)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DanhGia (TenTaiKhoan, TenNguoiDung, TKDanhGia, SoSao, NoiDung) VALUES (@TenTaiKhoan, @TenNguoiDung, @TKDanhGia, @SoSao, @NoiDung)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", maNguoiBan);
                    cmd.Parameters.AddWithValue("@TenNguoiDung", tenNguoiBan);
                    cmd.Parameters.AddWithValue("@TKDanhGia", tkDanhGia);
                    cmd.Parameters.AddWithValue("@SoSao", soSao);
                    cmd.Parameters.AddWithValue("@NoiDung", noiDung);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
