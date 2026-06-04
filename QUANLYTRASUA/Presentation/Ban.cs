using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Presentation
{
    public partial class Ban : Form
    {

        // Biến toàn cục dùng chung để ghi nhớ bàn nào đang được click chọn
        private QLBan banDangChonHienTai = null;

        public Ban()
        {
            InitializeComponent();
        }

        // Luồng tự động sinh 20 bàn trống khi mở giao diện lên
        private void Ban_Load(object sender, EventArgs e)
        {
            flpBan.Controls.Clear(); // Xóa sạch để tránh trùng lặp bàn

            for (int i = 1; i <= 20; i++)
            {
                QLBan banNew = new QLBan();

                banNew.ThietLapBan(i, "Trống"); // Mặc định tất cả đều trống
                banNew.DangKySuKienClick(BanAn_Click); // Gán sự kiện click

                flpBan.Controls.Add(banNew);
            }

            CapNhatThongKeBan(); // Đếm số lượng
        }

        // Luồng đếm số lượng và hiển thị lên bảng thống kê bên phải
        private void CapNhatThongKeBan()
        {
            int soBanTrong = 0;
            int soBanDangDung = 0;
            int soBanBiHuy = 0;

            foreach (Control item in flpBan.Controls)
            {
                if (item is QLBan)
                {
                    QLBan ban = (QLBan)item;

                    if (ban.TrangThai == "Trống")
                    {
                        soBanTrong = soBanTrong + 1;
                    }
                    else if (ban.TrangThai == "Đang dùng")
                    {
                        soBanDangDung = soBanDangDung + 1;
                    }
                    else if (ban.TrangThai == "Trống")
                    {
                        soBanBiHuy = soBanBiHuy + 1;
                    }
                }
            }

            lblSoBanTrong.Text = soBanTrong.ToString();
            lblSoBanDangDung.Text = soBanDangDung.ToString();
            lblSoBanCanPhucVu.Text = soBanBiHuy.ToString(); 
        }

        // Luồng xử lý khi người dùng nhấn chuột chọn 1 bàn ăn
        private void BanAn_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            while (ctrl != null && !(ctrl is QLBan))
            {
                ctrl = ctrl.Parent;
            }

            banDangChonHienTai = (QLBan)ctrl;

            if (banDangChonHienTai != null)
            {
                MessageBox.Show("Đã chọn: Bàn số " + banDangChonHienTai.SoThuTuBan + " (Trạng thái: " + banDangChonHienTai.TrangThai + ")");
            }
        }

        // Luồng xử lý khi bấm nút "Thêm bàn mới" (Đổi trạng thái sang Đang dùng)
        private void btnThemBanMoi_Click(object sender, EventArgs e)
        {
            if (banDangChonHienTai == null)
            {
                MessageBox.Show("Vui lòng click chọn 1 cái bàn trước!");
                return;
            }

            if (banDangChonHienTai.TrangThai == "Trống")
            {
                banDangChonHienTai.ThietLapBan(banDangChonHienTai.SoThuTuBan, "Đang dùng");
                CapNhatThongKeBan(); // Cập nhật lại số lượng đếm bên phải
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn trống!");
            }
        }

        // Luồng xử lý khi bấm nút "Khóa bàn" (Đổi trạng thái sang Bị Khóa)
        private void btnKhoaBan_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyDatBan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã click chọn cái bàn nào chưa
            if (banDangChonHienTai == null)
            {
                MessageBox.Show("Vui lòng click chọn 1 cái bàn trước!");
                return;
            }

            // 2. SỬA TẠI ĐÂY: Truyền vào chữ "Trống" thay vì "Hủy Đặt Bàn"
            // Hàm ThietLapBan sẽ tự động đổi chữ hiển thị thành "Trống" và đổi màu nền sang màu xanh lá (Color.ForestGreen)
            banDangChonHienTai.ThietLapBan(banDangChonHienTai.SoThuTuBan, "Trống");

            // 3. Chạy lại hàm thống kê để cập nhật lại các con số đếm ở bảng bên phải
            CapNhatThongKeBan();

            MessageBox.Show("Đã hủy trạng thái bàn số " + banDangChonHienTai.SoThuTuBan + " về Trống thành công!");
        }
    }

}
