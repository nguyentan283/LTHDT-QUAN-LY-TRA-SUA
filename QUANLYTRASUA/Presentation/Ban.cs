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
using WindowsFormsApp1.Dangnhap;

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
                banNew.DangKySuKienClick(BanAn_Click);

                flpBan.Controls.Add(banNew);
            }
            CapNhatThongKeBan();
            btnquanlyban.BackColor = Color.Peru;
        }
        private void CapNhatThongKeBan()
        {
            int soBanTrong = 0;
            int soBanDangDung = 0;
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
            lblSoBanTrong.Text = soBanTrong.ToString();
            lblSoBanDangDung.Text = soBanDangDung.ToString();
            lblSoBanCanPhucVu.Text = "0";
        }
        private void BanAn_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            while (ctrl != null && !(ctrl is QLBan))
            {
                ctrl = ctrl.Parent;
            }
            if (ctrl != null)
            {
                banDangChonHienTai = (QLBan)ctrl;
                MessageBox.Show("Đã chọn: Bàn số " + banDangChonHienTai.SoThuTuBan + " (Trạng thái: " + banDangChonHienTai.TrangThai + ")");
            }
        }
        private void btnHuyDatBan_Click(object sender, EventArgs e)
        {
            if (banDangChonHienTai == null)
            {
                MessageBox.Show("Vui lòng click chuột chọn một cái bàn ở lưới bên trái trước!");
                return;
            }
            banDangChonHienTai.ThietLapBan(banDangChonHienTai.SoThuTuBan, "Trống");
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
            if (banDangChonHienTai.TrangThai == "Trống")
            {
                banDangChonHienTai.ThietLapBan(banDangChonHienTai.SoThuTuBan, "Đang dùng");   
                CapNhatThongKeBan();
                MessageBox.Show("Mở bàn số " + banDangChonHienTai.SoThuTuBan + " thành công!");
            }
            else
            {
                MessageBox.Show("Bàn này hiện đang có khách ngồi, không thể thêm mới!");
            }
        }

        private void flpBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnquanlyban_Click(object sender, EventArgs e)
        {

        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }

        private void btnnhanvien_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnhoadon_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnTrangchu_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnTrangchu_Click_2(object sender, EventArgs e)
        {
            manhinhchinh mhc = new manhinhchinh();
            mhc.Show();
            this.Hide();
        }

        private void btnnhanvien_Click_2(object sender, EventArgs e)
        {
            nhanvien nv = new nhanvien();
            nv.Show();
            this.Hide();
        }

        private void btnmenu_Click_2(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
            this.Hide();
        }

        private void btnhoadon_Click_2(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.Show();
            this.Hide();
        }

        private void Ban_Load_1(object sender, EventArgs e)
        {

        }
    }

}
