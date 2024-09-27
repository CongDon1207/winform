using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public static class DatabaseHelper
{
    public static void SaveBankInfo(string connectionString, string bankName, string imagePath)
    {
        byte[] imageBytes = ConvertImageToBytes(imagePath);

        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var sql = "INSERT INTO NganHang (TenChiNhanh, AnhChiNhanh) VALUES (@TenChiNhanh, @AnhChiNhanh)";
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenChiNhanh", bankName);
                cmd.Parameters.AddWithValue("@AnhChiNhanh", imageBytes);
                cmd.ExecuteNonQuery();
            }
        }
    }

    private static byte[] ConvertImageToBytes(string imagePath)
    {
        using (var ms = new MemoryStream())
        {
            Image image = Image.FromFile(imagePath);
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
