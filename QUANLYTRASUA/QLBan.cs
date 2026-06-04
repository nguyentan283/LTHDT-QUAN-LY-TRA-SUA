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
        public string TrangThai { get; set; }
        public int SoThuTuBan { get; set; }

        public QLBan()
        {
            InitializeComponent();
        }

        // Hàm đổ dữ liệu và tự động đổi màu sắc theo trạng thái
        public void ThietLapBan(int soBan, string trangThai)
        {
            this.SoThuTuBan = soBan;
            this.TrangThai = trangThai;

            lblSoBan.Text = soBan.ToString();      // Hiển thị số bàn
            lblTrangThai.Text = trangThai;          // Hiển thị trạng thái (Trống, Đang dùng...)

            if (trangThai == "Trống")
            {
                this.BackColor = Color.ForestGreen;
            }
            else if (trangThai == "Đang dùng")
            {
                this.BackColor = Color.Orange;
            }
            else if (trangThai == "Cần Thanh Toán")
            {
                this.BackColor = Color.Firebrick;
            }
            else if (trangThai == "Trống") 
            {
                this.BackColor = Color.Green; 
            }
        }

        // Hàm truyền sự kiện click từ các chữ bên trong ra ngoài ô bàn lớn
        public void DangKySuKienClick(EventHandler suKien)
        {
            this.Click += suKien;
            foreach (Control con in this.Controls)
            {
                con.Click += suKien;
            }
        }

    }
}
