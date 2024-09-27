using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public class DonHangDao
    {
        private string connectionString = Properties.Settings.Default.conn.ToString();

        public DataTable LayLichSuDonHang(string tenDangNhap)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenNguoiBan, TenSanPham, GiaBan, ThoiGian FROM LSDonHang WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void LuuLichSu(string tenDangNhap, string maNguoiBan, string tenNguoiBan, string tenSanPham, int giaBan, DateTime thoiGian)
        {
            string query = @"INSERT INTO LSDonHang (TenDangNhap, MaNguoiBan, TenNguoiBan, TenSanPham, GiaBan, ThoiGian) 
                             VALUES (@TenDangNhap, @MaNguoiBan, @TenNguoiBan, @TenSanPham, @GiaBan, @ThoiGian)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                    cmd.Parameters.AddWithValue("@TenNguoiBan", tenNguoiBan);
                    cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                    cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                    cmd.Parameters.AddWithValue("@ThoiGian", thoiGian);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Mua hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, không thể mua hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public string LayMaNguoiBan(string tenNguoiBan, string tenSanPham)
        {
            string maNguoiBan = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNguoiBan FROM LSDonHang WHERE TenNguoiBan = @TenNguoiBan AND TenSanPham = @TenSanPham";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenNguoiBan", tenNguoiBan ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham ?? (object)DBNull.Value);

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        maNguoiBan = result.ToString();
                    }
                }
            }
            return maNguoiBan;
        }

        public void XoaDonHang(string tenNguoiBan, string tenSanPham)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM LSDonHang WHERE TenNguoiBan = @TenNguoiBan AND TenSanPham = @TenSanPham";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenNguoiBan", tenNguoiBan);
                    cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable LoadDonHangHuy(string maNguoiBan)
        {
            DataTable dtDonHangHuy = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaNguoiMua, TenSanPham, GiaBan, ThoiGianHuy, NoiDungHuy FROM DonHangHuy WHERE MaNguoiBan = @MaNguoiBan";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtDonHangHuy); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi tải dữ liệu từ DonHangHuy: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return dtDonHangHuy;
        }



        public void ThemDonHangHuy(string maNguoiBan, string maNguoiMua, string tenSanPham, int giaBan, string noiDungHuy)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"
INSERT INTO DonHangHuy (MaNguoiBan, MaNguoiMua, TenSanPham, GiaBan, ThoiGianHuy, NoiDungHuy)
VALUES (@MaNguoiBan, @MaNguoiMua, @TenSanPham, @GiaBan, @ThoiGianHuy, @NoiDungHuy)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                        cmd.Parameters.AddWithValue("@MaNguoiMua", maNguoiMua);
                        cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                        cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                        cmd.Parameters.AddWithValue("@ThoiGianHuy", DateTime.Now);
                        cmd.Parameters.AddWithValue("@NoiDungHuy", noiDungHuy);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Đơn hàng đã được hủy thành công.", "Hủy Đơn Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có đơn hàng nào được hủy.", "Hủy Đơn Hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình hủy đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
