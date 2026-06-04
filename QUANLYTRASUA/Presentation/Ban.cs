using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Presentation
{
    public partial class Ban : Form
    {

        // Biến toàn cục dùng chung để ghi nhớ đối tượng bàn nào vừa được người dùng click chọn
        private QLBan banDangChonHienTai = null;

        public Ban()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Ban_Load);
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            manhinhchinh mhn = new manhinhchinh();
            mhn.Show();
            this.Hide();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            nhanvien nv = new nhanvien();
            nv.Show();
            this.Hide();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            //menu mn = new menu();
            //mn.Show();
            //this.Hide();
            this.Show();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.Show();
            this.Hide();
        }

        private void Ban_Load(object sender, EventArgs e)
        {
            flpBan.Controls.Clear();

            for (int i = 1; i <= 20; i++)
            {
                QLBan banNew = new QLBan();
                banNew.ThietLapBan(i, "Trống");

                // Đăng ký sự kiện Click chuẩn, không dùng chung với Paint!
                banNew.DangKySuKienClick(BanAn_Click);

                flpBan.Controls.Add(banNew);
            }
            CapNhatThongKeBan();
        }

        // Hàm duyệt danh sách để đếm số lượng bàn trống và bàn đang dùng
        private void CapNhatThongKeBan()
        {
            int soBanTrong = 0;
            int soBanDangDung = 0;

            // Duyệt qua tất cả linh kiện đang nằm inside khung flpBan
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
                }
            }

            // Gán giá trị số vừa đếm được vào chữ hiển thị của các Label bên góc phải
            lblSoBanTrong.Text = soBanTrong.ToString();
            lblSoBanDangDung.Text = soBanDangDung.ToString();
            lblSoBanCanPhucVu.Text = "0"; // Dòng thứ 3 đặt mặc định bằng 0 hoặc tùy biến sau
        }

        // Hàm xử lý sự kiện khi người dùng click chuột vào bất kỳ vị trí nào trên một ô bàn ăn
        private void BanAn_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            while (ctrl != null && !(ctrl is QLBan))
            {
                ctrl = ctrl.Parent;
            }

            // Kiểm tra an toàn trước khi ép kiểu
            if (ctrl != null)
            {
                banDangChonHienTai = (QLBan)ctrl;
                MessageBox.Show("Đã chọn: Bàn số " + banDangChonHienTai.SoThuTuBan + " (Trạng thái: " + banDangChonHienTai.TrangThai + ")");
            }
        }



        // Luồng xử lý khi người dùng ấn vào nút "Hủy đặt bàn"
        private void btnHuyDatBan_Click(object sender, EventArgs e)
        {
            if (banDangChonHienTai == null)
            {
                MessageBox.Show("Vui lòng click chuột chọn một cái bàn ở lưới bên trái trước!");
                return;
            }

            // Đưa trạng thái bàn quay về chữ "Trống", hàm ThietLapBan sẽ tự động đổi màu nền sang xanh lá cây
            banDangChonHienTai.ThietLapBan(banDangChonHienTai.SoThuTuBan, "Trống");

            // Tính toán lại bảng thống kê số liệu bên phải
            CapNhatThongKeBan();
            MessageBox.Show("Đã hủy trạng thái bàn số " + banDangChonHienTai.SoThuTuBan + " về Trống thành công!");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (banDangChonHienTai == null)
            {
                MessageBox.Show("Vui lòng click chuột chọn một cái bàn ở lưới bên trái trước!");
                return;
            }

            // Chỉ cho phép chuyển sang Đang dùng nếu bàn đó thực sự đang trống màu xanh
            if (banDangChonHienTai.TrangThai == "Trống")
            {
                banDangChonHienTai.ThietLapBan(banDangChonHienTai.SoThuTuBan, "Đang dùng");

                // Tính toán lại bảng thống kê số liệu bên phải
                CapNhatThongKeBan();
                MessageBox.Show("Mở bàn số " + banDangChonHienTai.SoThuTuBan + " thành công!");
            }
            else
            {
                MessageBox.Show("Bàn này hiện đang có khách ngồi, không thể thêm mới!");
            }
        }


    }

}
