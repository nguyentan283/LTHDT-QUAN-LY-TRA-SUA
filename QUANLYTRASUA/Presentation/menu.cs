using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presentation;

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {



        public menu()
        {
            InitializeComponent();
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

        private void btnTrangchu_Click_1(object sender, EventArgs e)
        {
            manhinhchinh mhn = new manhinhchinh();
            mhn.Show();
            this.Hide();
        }

        private void btnnhanvien_Click_1(object sender, EventArgs e)
        {
            nhanvien nv = new nhanvien();
            nv.Show();
            this.Hide();
        }

        private void btnquanlyban_Click(object sender, EventArgs e)
        {
            QuanLyBan qlb = new QuanLyBan();
            qlb.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.Show();
            this.Hide();
        }

        private void dgvMenu_CellClick(object sender,
                               DataGridViewCellEventArgs e)
        {

        }

        public class MonAn
        {
            public string TenMon { get; set; }
            public int Gia { get; set; }
            public string HinhAnh { get; set; }

            public MonAn(string tenMon, int gia, string hinhAnh)
            {
                TenMon = tenMon;
                Gia = gia;
                HinhAnh = hinhAnh;
            }
        }
        List<MonAn> dsMon = new List<MonAn>();

        private void menu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form đã load");

            dsMon.Add(new MonAn("Trà sữa boba", 120000, @"Images\boba.jpg"));

            LoadMenu();
            btnmenu.BackColor = Color.Peru;
        }
        private void LoadMenu()
        {
            flpMenu.Controls.Clear();

            foreach (MonAn mon in dsMon)
            {
                Mon item = new Mon();

                item.TenMon = mon.TenMon;
                item.Gia = mon.Gia.ToString("N0");
                item.HinhAnh = Image.FromFile(mon.HinhAnh);

                item.MonDuocChon += (s, e) =>
                {
                    picAnhMon.Image = Image.FromFile(mon.HinhAnh);
                    txtTenMon.Text = mon.TenMon;
                    nmrGia.Value = mon.Gia;
                };

                flpMenu.Controls.Add(item);
            }
        }
    }
}
