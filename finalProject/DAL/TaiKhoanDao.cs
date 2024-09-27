using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public class TaiKhoanDao
    {
        private string connectionString = Properties.Settings.Default.conn.ToString();

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO QLTaiKhoan (TenTaiKhoan, TenNguoiDung, MatKhau, Xu, CMND, SoDT, GioiTinh, NgaySinh) VALUES (@TenTaiKhoan, @TenNguoiDung, @MatKhau, @Xu, @CMND, @SoDT, @GioiTinh, @NgaySinh)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenTaiKhoan", taiKhoan.TenTaiKhoan);
                        cmd.Parameters.AddWithValue("@TenNguoiDung", taiKhoan.TenNguoiDung);
                        cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                        cmd.Parameters.AddWithValue("@Xu", taiKhoan.Xu);
                        cmd.Parameters.AddWithValue("@CMND", taiKhoan.CMND);
                        cmd.Parameters.AddWithValue("@SoDT", taiKhoan.SoDT);
                        cmd.Parameters.AddWithValue("@GioiTinh", taiKhoan.GioiTinh);
                        cmd.Parameters.AddWithValue("@NgaySinh", taiKhoan.NgaySinh);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
                return false;
            }
        }

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM QLTaiKhoan WHERE TenTaiKhoan = @tenDangNhap AND MatKhau = @matKhau";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@matKhau", matKhau);

                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
                
            }
        }

        public TaiKhoan LayThongTinTaiKhoan(string tenDangNhap)
        {
            TaiKhoan taiKhoan = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenTaiKhoan, TenNguoiDung, MatKhau, Xu, CMND, SoDT, GioiTinh, NgaySinh, AnhDaiDien FROM QLTaiKhoan WHERE TenTaiKhoan = @tenDangNhap";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            taiKhoan = new TaiKhoan
                            {
                                TenTaiKhoan = reader["TenTaiKhoan"].ToString(),
                                TenNguoiDung = reader["TenNguoiDung"].ToString(),
                                MatKhau = reader["MatKhau"].ToString(),
                                Xu = reader["Xu"] != DBNull.Value ? Convert.ToInt32(reader["Xu"]) : 0,
                                CMND = reader["CMND"].ToString(),
                                SoDT = reader["SoDT"].ToString(),
                                GioiTinh = reader["GioiTinh"].ToString(),
                                NgaySinh = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"]) : DateTime.Now,
                                AnhDaiDien = reader["AnhDaiDien"] != DBNull.Value ? (byte[])reader["AnhDaiDien"] : null
                            };
                        }
                    }
                }
            }

            return taiKhoan;
        }

        public bool CapNhatTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE QLTaiKhoan SET TenNguoiDung = @tenNguoiDung, CMND = @cmnd, GioiTinh = @gioiTinh, SoDT = @soDT, NgaySinh = @ngaySinh WHERE TenTaiKhoan = @tenTaiKhoan";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenTaiKhoan", taiKhoan.TenTaiKhoan);
                        cmd.Parameters.AddWithValue("@tenNguoiDung", taiKhoan.TenNguoiDung);
                        cmd.Parameters.AddWithValue("@cmnd", taiKhoan.CMND);
                        cmd.Parameters.AddWithValue("@gioiTinh", taiKhoan.GioiTinh);
                        cmd.Parameters.AddWithValue("@soDT", taiKhoan.SoDT);
                        cmd.Parameters.AddWithValue("@ngaySinh", taiKhoan.NgaySinh);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

        public void CapNhatAnh(string tenDangNhap, byte[] anh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE QLTaiKhoan SET AnhDaiDien = @anh WHERE TenTaiKhoan = @tenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@anh", anh);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public byte[] HienThiAnh(string tenDangNhap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT AnhDaiDien FROM QLTaiKhoan WHERE TenTaiKhoan = @tenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return (byte[])result;
                    }
                }
            }
            return null;
        }

        public Image ByteThanhImage(byte[] bytes)
        {
            if (bytes != null)
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        public void XoaAnh(string tenDangNhap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE QLTaiKhoan SET AnhDaiDien = NULL WHERE TenTaiKhoan = @tenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string LayTenNguoiDung(string tenDangNhap)
        {
            string query = "SELECT TenNguoiDung FROM QLTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            return ExecuteScalarQuery(connectionString, query, "@TenTaiKhoan", tenDangNhap);
        }

        public int LaySoXu(string tenDangNhap)
        {
            string query = "SELECT Xu FROM QLTaiKhoan WHERE TenTaiKhoan = @TenDangNhap";
            string result = ExecuteScalarQuery(connectionString, query, "@TenDangNhap", tenDangNhap);
            return int.TryParse(result, out int soXu) ? soXu : 0;
        }

        private string ExecuteScalarQuery(string connectionString, string query, string parameterName, object parameterValue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(parameterName, parameterValue);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? string.Empty;
                }
            }
        }

        public bool KiemTraMatKhau(string tenDangNhap, string matKhauHienTai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM QLTaiKhoan WHERE TenTaiKhoan=@tenDangNhap AND MatKhau=@matKhauHienTai";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@matKhauHienTai", matKhauHienTai);
                    int count = (int)cmd.ExecuteScalar();
                    return count == 1;
                }
            }
        }

        // Cập nhật mật khẩu mới
        public bool CapNhatMatKhau(string tenDangNhap, string matKhauMoi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE QLTaiKhoan SET MatKhau=@matKhauMoi WHERE TenTaiKhoan=@tenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@matKhauMoi", matKhauMoi);
                    return cmd.ExecuteNonQuery() == 1;
                }
            }
        }

        public void CapNhatXuMua(string tenDangNhap, int giaBan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE QLTaiKhoan SET Xu = Xu - @GiaBan WHERE TenTaiKhoan = @TenDangNhap";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CapNhatXuBan(string tenTaiKhoan, int giaBan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE QLTaiKhoan SET Xu = Xu + @GiaBan WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string TimSDT(string tenTaiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SoDT FROM QLTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan", conn);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["SoDT"].ToString();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
