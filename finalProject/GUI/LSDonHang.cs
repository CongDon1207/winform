using finalProject.RTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class gvLSDonHang : Form
    {
        public string TenDangNhap { get; set; }
        DonHangDao donHangDao = new DonHangDao();
        TaiKhoanDao taiKhoanDao = new TaiKhoanDao();

        public gvLSDonHang()
        {
            InitializeComponent();
        }

        private void gvLSDonHang_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void dvLSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvLSDonHang.Columns[e.ColumnIndex].Name == "colDanhGia")
            {
                string tenNguoiBan = dvLSDonHang.Rows[e.RowIndex].Cells["colNguoiBan"].Value.ToString();
                string tenSanPham = dvLSDonHang.Rows[e.RowIndex].Cells["colTenSanPham"].Value.ToString();
                DanhGia dg = new DanhGia()
                {
                    TenNguoiBan = tenNguoiBan,
                    TenSanPham = tenSanPham,
                    TenDangNhap = this.TenDangNhap,
                };
                dg.ShowDialog();
            }
            else if (dvLSDonHang.Columns[e.ColumnIndex].Name == "colHuy")
            {
                string tenNguoiBan = dvLSDonHang.Rows[e.RowIndex].Cells["colNguoiBan"].Value.ToString();
                string tenSanPham = dvLSDonHang.Rows[e.RowIndex].Cells["colTenSanPham"].Value.ToString();
                int giaBan = Convert.ToInt32(dvLSDonHang.Rows[e.RowIndex].Cells["colGiaBan"].Value);
                DateTime thoiGianDat = Convert.ToDateTime(dvLSDonHang.Rows[e.RowIndex].Cells["colThoiGian"].Value);

                // Kiểm tra thời gian hiện tại so với thời gian đặt hàng
                if (DateTime.Now > thoiGianDat.AddHours(3)) // Nếu thời gian hiện tại vượt quá 3 giờ kể từ khi đặt hàng
                {
                    MessageBox.Show("Không thể hủy đơn hàng này vì đã quá 3 giờ kể từ khi đặt đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LiDoHuy liDoHuy = new LiDoHuy() 
                    { 
                        MaNguoiBan = donHangDao.LayMaNguoiBan(tenNguoiBan, tenSanPham),
                        TenNguoiMua = taiKhoanDao.LayTenNguoiDung(this.TenDangNhap),
                        TenSanPham = tenSanPham,
                        GiaBan = giaBan
                    };
                    liDoHuy.ShowDialog();
                    donHangDao.XoaDonHang(tenNguoiBan, tenSanPham);
                    dvLSDonHang.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void LoadDataIntoDataGridView()
        {
            DataTable dataTable = donHangDao.LayLichSuDonHang(TenDangNhap);
            dvLSDonHang.Rows.Clear(); 

            foreach (DataRow row in dataTable.Rows)
            {
                dvLSDonHang.Rows.Add(
                    row["TenNguoiBan"],
                    row["TenSanPham"],
                    row["GiaBan"],
                    row["ThoiGian"].ToString() 
                );
            }
        }

    }
}
