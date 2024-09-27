using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*string connectionString = "Data Source=LAPTOP-M10LPRA9\\CONGDON;Initial Catalog=QLSanPham;Integrated Security=True;Encrypt=False";
            string bankName = "VietinBank";
            string imagePath = @"C:/Users/PC/Pictures/Ảnh ngânnhangf/386358792_625725979766219_9115486532034454313_n.jpg";

            // Gọi phương thức lưu thông tin ngân hàng
            DatabaseHelper.SaveBankInfo(connectionString, bankName, imagePath);

            Console.WriteLine("Thông tin ngân hàng đã được lưu thành công.");*/

            // Chạy ứng dụng GUI như bình thường
            Application.Run(new LoginForm());
            //Application.Run(new XemDanhGia());



        }
    }
}
