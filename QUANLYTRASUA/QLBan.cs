using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QLBan : UserControl
    {
        // Hai thuộc tính cơ bản để quản lý thông tin của từng ô bàn
        public int SoThuTuBan { get; set; }
        public string TrangThai { get; set; }

        public QLBan()
        {
            InitializeComponent();
        }

        // Hàm thiết lập thông tin bàn và tự động cập nhật màu sắc giao diện tương ứng
        public void ThietLapBan(int soBan, string trangThai)
        {
            this.SoThuTuBan = soBan;
            this.TrangThai = trangThai;

            // Gán dữ liệu chữ hiển thị lên các nhãn tương ứng inside ô bàn
            // LƯU Ý: Nếu bị gạch đỏ 2 chữ này, hãy kiểm tra lại (Name) của các nhãn trong màn hình Design nhé!
            lblSoBan.Text = "Bàn " + soBan.ToString();
            lblTrangThai.Text = trangThai;

            // Tự động kiểm tra trạng thái để thay đổi màu nền (BackColor)
            if (trangThai == "Trống")
            {
                this.BackColor = Color.ForestGreen; // Màu xanh lá cây khi trống
            }
            else if (trangThai == "Đang dùng")
            {
                this.BackColor = Color.Orange;      // Màu cam khi có khách ngồi
            }
        }

        // Hàm tự động đăng ký sự kiện Click xuyên suốt cho tất cả linh kiện inside ô bàn
        public void DangKySuKienClick(EventHandler suKien)
        {
            this.Click += suKien; // Click vào khoảng trống nền

            // Duyệt qua toàn bộ nhãn chữ số bàn, nhãn chữ trạng thái để gán click đồng bộ
            foreach (Control con in this.Controls)
            {
                con.Click += suKien;
            }
        }

    }
}
