using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class NapRutDao
    {
        private string connectionString = Properties.Settings.Default.conn.ToString();

        public DataTable GetAllGiaoDich()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM LSGiaoDich", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public byte[] GetBankBranchImage(string bankBranchName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AnhChiNhanh FROM NganHang WHERE TenChiNhanh = @TenChiNhanh";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenChiNhanh", bankBranchName);

                try
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? (byte[])result : null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public string GetAccountNameByAccountNumber(string branchBank, string accountNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TenChuTaiKhoan FROM TKNganHang WHERE TenChiNhanh = @TenChiNhanh and SoTaiKhoan = @SoTaiKhoan";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenChiNhanh", branchBank);
                cmd.Parameters.AddWithValue("@SoTaiKhoan", accountNumber);

                try
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return "";
                }
            }
        }

        public bool ProcessTransaction(string tenDangNhap,string soTaiKhoan, string chiNhanh, string tinhTrang, int soXu, DateTime thoiGianGiaoDich)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO LSGiaoDich(SoTaiKhoan, ChiNhanh, TinhTrang, SoXu, ThoiGianGiaoDich) VALUES(@SoTaiKhoan, @ChiNhanh, @TinhTrang, @SoXu, @ThoiGianGiaoDich)", conn))
                {
                    cmd.Parameters.AddWithValue("@SoTaiKhoan", soTaiKhoan);
                    cmd.Parameters.AddWithValue("@ChiNhanh", chiNhanh);
                    cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                    cmd.Parameters.AddWithValue("@SoXu", soXu);
                    cmd.Parameters.AddWithValue("@ThoiGianGiaoDich", thoiGianGiaoDich);

                    cmd.ExecuteNonQuery();
                }

                string sqlUpdate = tinhTrang == "Nạp tiền" ?
                "UPDATE QLTaiKhoan SET Xu = Xu + @SoXu WHERE TenTaiKhoan = @TenTaiKhoan" :
                "UPDATE QLTaiKhoan SET Xu = Xu - @SoXu WHERE TenTaiKhoan = @TenTaiKhoan AND Xu >= @SoXu";

                using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@SoXu", soXu);
                    cmdUpdate.Parameters.AddWithValue("@TenTaiKhoan", tenDangNhap);

                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public int GetCurrentBalance(string tenTaiKhoan)
        {
            int soXuHienCo = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Xu FROM QLTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            soXuHienCo = reader.GetInt32(reader.GetOrdinal("Xu"));
                        }
                    }
                }
            }
            return soXuHienCo;
        }
    }
}
