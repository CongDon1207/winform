using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;


namespace finalProject
{
    public class SanPhamDao
    {
        private SqlConnection conn;
        private string connection= Properties.Settings.Default.conn.ToString();
        public SanPhamDao()
        {
            conn = new SqlConnection(connection);
        }

        public DataTable LoadSanPham(string TenDangNhap)
        {
            DataTable dataTable = new DataTable();

            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            string sqlQuery = "SELECT * FROM QLSanPham WHERE TenTaiKhoan = @TenDangNhap";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
            }

            conn.Close();
            return dataTable;
        }


        public bool AddSanPham(SanPham sanPham, List<byte[]> hinhAnhs)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO QLSanPham (TenSP, LoaiSP, GiaLucMua, GiaBan, TinhTrang, ThoiGian, MoTaTinhTrang, MoTa, DiaChi, ThongTinLH, TenTaiKhoan, ThoiGianDang) OUTPUT INSERTED.MaSP VALUES (@TenSP, @LoaiSP, @GiaLucMua, @GiaBan, @TinhTrang, @ThoiGian, @MoTaTinhTrang, @MoTa, @DiaChi, @ThongTinLH, @TenTaiKhoan, @ThoiGianDang)", conn);

                // Thiết lập các tham số như trước
                command.Parameters.AddWithValue("@TenSP", sanPham.TenSP);
                command.Parameters.AddWithValue("@LoaiSP", sanPham.LoaiSP);
                command.Parameters.AddWithValue("@GiaLucMua", sanPham.GiaLucMua);
                command.Parameters.AddWithValue("@GiaBan", sanPham.GiaBan);
                command.Parameters.AddWithValue("@TinhTrang", sanPham.TinhTrang);
                command.Parameters.AddWithValue("@ThoiGian", sanPham.ThoiGian);
                command.Parameters.AddWithValue("@MoTaTinhTrang", sanPham.MoTaTinhTrang);
                command.Parameters.AddWithValue("@MoTa", sanPham.MoTa);
                command.Parameters.AddWithValue("@DiaChi", sanPham.DiaChi);
                command.Parameters.AddWithValue("@ThongTinLH", sanPham.ThongTinLH);
                command.Parameters.AddWithValue("@TenTaiKhoan", sanPham.TenTaiKhoan);
                command.Parameters.AddWithValue("@ThoiGianDang", DateTime.Now); // Thêm thời gian đăng hiện tại

                int idSanPham = (int)command.ExecuteScalar();

                foreach (byte[] hinhAnh in hinhAnhs)
                {
                    SqlCommand command2 = new SqlCommand("INSERT INTO QLHinhAnh (SanPhamID, HinhAnh) VALUES (@SanPhamID, @HinhAnh)", conn);
                    command2.Parameters.AddWithValue("@SanPhamID", idSanPham);
                    command2.Parameters.AddWithValue("@HinhAnh", hinhAnh);

                    command2.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; // Trả về false nếu có lỗi
            }
            finally
            {
                conn.Close();
            }
        }


        public bool UpdateSanPham(SanPham sanPham, List<byte[]> hinhAnhs)
        {
            
                try
                {
                    conn.Open();
                    string query = @"UPDATE QLSanPham 
                                 SET TenSP = @TenSP, LoaiSP = @LoaiSP, GiaLucMua = @GiaLucMua, GiaBan = @GiaBan, 
                                     TinhTrang = @TinhTrang, ThoiGian = @ThoiGian, MoTaTinhTrang = @MoTaTinhTrang, 
                                     MoTa = @MoTa, DiaChi = @DiaChi, ThongTinLH = @ThongTinLH 
                                 WHERE MaSP = @MaSP";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", sanPham.MaSP);
                        cmd.Parameters.AddWithValue("@TenSP", sanPham.TenSP);
                        cmd.Parameters.AddWithValue("@LoaiSP", sanPham.LoaiSP);
                        cmd.Parameters.AddWithValue("@GiaLucMua", sanPham.GiaLucMua);
                        cmd.Parameters.AddWithValue("@GiaBan", sanPham.GiaBan);
                        cmd.Parameters.AddWithValue("@TinhTrang", sanPham.TinhTrang);
                        cmd.Parameters.AddWithValue("@ThoiGian", sanPham.ThoiGian);
                        cmd.Parameters.AddWithValue("@MoTaTinhTrang", sanPham.MoTaTinhTrang);
                        cmd.Parameters.AddWithValue("@MoTa", sanPham.MoTa);
                        cmd.Parameters.AddWithValue("@DiaChi", sanPham.DiaChi);
                        cmd.Parameters.AddWithValue("@ThongTinLH", sanPham.ThongTinLH);

                        cmd.ExecuteNonQuery();
                    }
                    int idSanPham = sanPham.MaSP;

                    foreach (byte[] hinhAnh in hinhAnhs)
                    {
                        SqlCommand command2 = new SqlCommand("INSERT INTO QLHinhAnh (SanPhamID, HinhAnh) VALUES (@SanPhamID, @HinhAnh)", conn);
                        command2.Parameters.AddWithValue("@SanPhamID", idSanPham);
                        command2.Parameters.AddWithValue("@HinhAnh", hinhAnh);

                        command2.ExecuteNonQuery();
                    }
                return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
                    return false;
                }
            
        }

        public List<Image> LoadHinhAnh(int sanPhamID)
        {
            List<Image> listHinhAnh = new List<Image>();
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-M10LPRA9\\CONGDON;Initial Catalog=QLSanPham;Integrated Security=True;Encrypt=false"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT HinhAnh FROM QLHinhAnh WHERE SanPhamID = @SanPhamID", conn))
                {
                    cmd.Parameters.AddWithValue("@SanPhamID", sanPhamID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] hinhAnhBytes = (byte[])reader["HinhAnh"];
                            using (MemoryStream ms = new MemoryStream(hinhAnhBytes))
                            {
                                Image image = Image.FromStream(ms);
                                listHinhAnh.Add(image);
                            }
                        }
                    }
                }
            }
            return listHinhAnh;
        }

        public List<SanPham> HienThiSanPham(string dieuKien, string giaTri, string tenDangNhap)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            string sqlQuery = string.Empty;
            if (dieuKien == "LoaiSP")
            {
                sqlQuery = "SELECT MaSP, TenSP, GiaLucMua, GiaBan, TinhTrang, ThoiGian, MoTaTinhTrang, MoTa, DiaChi, ThongTinLH, TenTaiKhoan, ThoiGianDang FROM QLSanPham WHERE LoaiSP = @GiaTri AND TenTaiKhoan <> @TenDangNhap";
            }
            else if (dieuKien == "TenSP")
            {
                sqlQuery = "SELECT MaSP, TenSP, GiaLucMua, GiaBan, TinhTrang, ThoiGian, MoTaTinhTrang, MoTa, DiaChi, ThongTinLH, TenTaiKhoan, ThoiGianDang FROM QLSanPham WHERE TenSP LIKE @GiaTri + '%' AND TenTaiKhoan <> @TenDangNhap";
            }
            else if (dieuKien == "QuanTam")
            {
                sqlQuery = "SELECT MaSP, TenSP, GiaLucMua, GiaBan, TinhTrang, ThoiGian, MoTaTinhTrang, MoTa, DiaChi, ThongTinLH, TenTaiKhoan, ThoiGianDang FROM QLSanPham WHERE MaSP in (Select MaSP From SanPhamQuanTam WHERE TenTaiKhoan = @TenDangNhap)";
            }

            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                command.Parameters.AddWithValue("@GiaTri", giaTri);
                command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap); // Thêm tham số TenDangNhap

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sanPham = new SanPham
                        {
                            MaSP = reader.GetInt32(reader.GetOrdinal("MaSP")),
                            TenSP = reader.GetString(reader.GetOrdinal("TenSP")),
                            GiaLucMua = reader.GetInt32(reader.GetOrdinal("GiaLucMua")),
                            GiaBan = reader.GetInt32(reader.GetOrdinal("GiaBan")),
                            TinhTrang = reader.GetString(reader.GetOrdinal("TinhTrang")),
                            ThoiGian = reader.GetString(reader.GetOrdinal("ThoiGian")),
                            MoTaTinhTrang = reader.GetString(reader.GetOrdinal("MoTaTinhTrang")),
                            MoTa = reader.GetString(reader.GetOrdinal("MoTa")),
                            DiaChi = reader.GetString(reader.GetOrdinal("DiaChi")),
                            ThongTinLH = reader.GetString(reader.GetOrdinal("ThongTinLH")),
                            TenTaiKhoan = reader.GetString(reader.GetOrdinal("TenTaiKhoan")),
                            ThoiGianDang = reader.GetDateTime(reader.GetOrdinal("ThoiGianDang")) // Cập nhật để bao gồm ThoiGianDang
                        };
                        sanPhams.Add(sanPham);
                    }
                }
            }
            conn.Close();

            return sanPhams;
        }

        public List<SanPham> HienThiSPTheoTieuChiSapXep(string tieuChi, string tenDangNhap)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            string sqlQuery = "SELECT * FROM QLSanPham WHERE TenTaiKhoan <> @TenDangNhap";
            
            switch (tieuChi)
            {
                case "Mặc định":
                    // Không thêm điều kiện sắp xếp nào, giữ nguyên truy vấn
                    break;
                case "Giá":
                    sqlQuery += " ORDER BY GiaBan ASC";
                    break;
                case "Thời gian đăng":
                    sqlQuery += " ORDER BY ThoiGianDang DESC";
                    break;
                case "Lượt tìm kiếm":
                    sqlQuery += " ORDER BY LuotTimKiem DESC";
                    break;
            }

            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SanPham sanPham = new SanPham
                        {
                            MaSP = reader.GetInt32(reader.GetOrdinal("MaSP")),
                            TenSP = reader.GetString(reader.GetOrdinal("TenSP")),
                            GiaLucMua = reader.GetInt32(reader.GetOrdinal("GiaLucMua")),
                            GiaBan = reader.GetInt32(reader.GetOrdinal("GiaBan")),
                            TinhTrang = reader.GetString(reader.GetOrdinal("TinhTrang")),
                            ThoiGian = reader.GetString(reader.GetOrdinal("ThoiGian")),
                            MoTaTinhTrang = reader.GetString(reader.GetOrdinal("MoTaTinhTrang")),
                            MoTa = reader.GetString(reader.GetOrdinal("MoTa")),
                            DiaChi = reader.GetString(reader.GetOrdinal("DiaChi")),
                            ThongTinLH = reader.GetString(reader.GetOrdinal("ThongTinLH")),
                            TenTaiKhoan = reader.GetString(reader.GetOrdinal("TenTaiKhoan")),
                            ThoiGianDang = reader.GetDateTime(reader.GetOrdinal("ThoiGianDang"))
                        };
                        sanPhams.Add(sanPham);
                    }
                }
            }
            conn.Close();

            return sanPhams;
        }


        public List<Image> LayHinhAnhSanPham(int sanPhamID)
        {
            List<Image> hinhAnhs = new List<Image>();


            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string query = "SELECT HinhAnh FROM QLHinhAnh WHERE SanPhamID = @SanPhamID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SanPhamID", sanPhamID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] bytes = (byte[])reader["HinhAnh"];
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                hinhAnhs.Add(Image.FromStream(ms));
                            }
                        }
                    }
                }
            conn.Close();
            return hinhAnhs;
        }

        public void UpdateLuotTimKiem(int maSP)
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            
            string sqlUpdate =  "UPDATE QLSanPham SET LuotTimKiem = ISNULL(LuotTimKiem, 0) + 1 WHERE MaSP = @MaSP";
            using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.ExecuteNonQuery();
            }

            conn.Close();
            
        }

        public void XoaSanPham(int maSP)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("DELETE FROM QLHinhAnh WHERE SanPhamID = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", maSP);
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand("DELETE FROM QLSanPham WHERE MaSP = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", maSP);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public SanPham GetSanPhamById(int maSP)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            SanPham sanPham = null;
            string query = "SELECT * FROM QLSanPham WHERE MaSP = @MaSP";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Chỉ đọc bản ghi đầu tiên vì MaSP là duy nhất
                    {
                        sanPham = new SanPham()
                        {
                            MaSP = reader.GetInt32(reader.GetOrdinal("MaSP")),
                            TenSP = reader["TenSP"].ToString(),
                            LoaiSP = reader["LoaiSP"].ToString(),
                            GiaLucMua = reader.GetInt32(reader.GetOrdinal("GiaLucMua")),
                            GiaBan = reader.GetInt32(reader.GetOrdinal("GiaBan")),
                            TinhTrang = reader["TinhTrang"].ToString(),
                            ThoiGian = reader["ThoiGian"].ToString(),
                            MoTaTinhTrang = reader["MoTaTinhTrang"].ToString(),
                            MoTa = reader["MoTa"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            ThongTinLH = reader["ThongTinLH"].ToString(),
                            TenTaiKhoan = reader["TenTaiKhoan"].ToString(),
                            ThoiGianDang = reader.GetDateTime(reader.GetOrdinal("ThoiGianDang"))
                        };
                    }
                }
            }

            conn.Close();
            return sanPham;
        }

        public int LayMaSanPham(string tenSanPham, string tenTaiKhoan, int giaBan)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string sqlGetMaSP = "SELECT MaSP FROM QLSanPham WHERE TenSP = @Ten AND TenTaiKhoan = @TenTaiKhoan AND GiaBan = @GiaBan";
            using (SqlCommand cmd = new SqlCommand(sqlGetMaSP, conn))
            {
                cmd.Parameters.AddWithValue("@Ten", tenSanPham);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                cmd.Parameters.AddWithValue("@GiaBan", giaBan);

                object result = cmd.ExecuteScalar();
                conn.Close();
                if (result != null)
                    return Convert.ToInt32(result);
                return -1;
            }
        }

        public bool ThemSanPhamQuanTam(int maSP, string tenTaiKhoan)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string query = "INSERT INTO SanPhamQuanTam (MaSP, TenTaiKhoan) VALUES (@MaSP, @TenTaiKhoan)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
        }

        public bool BoSanPhamQuanTam(int maSP, string tenTaiKhoan)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM SanPhamQuanTam WHERE MaSP = @MaSP AND TenTaiKhoan = @TenTaiKhoan", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0 ? true : false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }

        public (bool hopLe, int phanTramGiam, string thongBao) KiemTraVoucher(string maVoucher)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string cauTruyVan = "SELECT PhanTramGiam, NgayHetHan, KichHoat FROM MaGiamGia WHERE MaVoucher = @MaVoucher";
                using (SqlCommand cmd = new SqlCommand(cauTruyVan, conn))
                {
                    cmd.Parameters.AddWithValue("@MaVoucher", maVoucher);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool kichHoat = reader.GetBoolean(reader.GetOrdinal("KichHoat"));
                            DateTime ngayHetHan = reader.GetDateTime(reader.GetOrdinal("NgayHetHan"));
                            if (kichHoat && ngayHetHan >= DateTime.Now)
                            {
                                int phanTramGiam = reader.GetInt32(reader.GetOrdinal("PhanTramGiam"));

                                // Voucher hợp lệ, tiến hành cập nhật trạng thái kích hoạt
                                reader.Close(); // Đóng SqlDataReader trước khi thực hiện cập nhật
                                cmd.CommandText = "UPDATE MaGiamGia SET KichHoat = 0 WHERE MaVoucher = @MaVoucher";
                                cmd.ExecuteNonQuery();

                                return (true, phanTramGiam, "Voucher hợp lệ. Bạn được giảm " + phanTramGiam.ToString() + "%.");
                            }
                            else if (!kichHoat)
                            {
                                return (false, 0, "Mã voucher không còn kích hoạt.");
                            }
                            else
                            {
                                return (false, 0, "Mã voucher đã hết hạn.");
                            }
                        }
                        else
                        {
                            return (false, 0, "Mã voucher không hợp lệ.");
                        }
                    }
                }
            }
        }

    }
}
