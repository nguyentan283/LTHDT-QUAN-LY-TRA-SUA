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
            public string Loai { get; set; }

            public MonAn(string tenMon, int gia, string hinhAnh, string loai)
            {
                TenMon = tenMon;
                Gia = gia;
                HinhAnh = hinhAnh;
                Loai = loai;
            }
        }
        List<MonAn> dsMon = new List<MonAn>();

        private void menu_Load(object sender, EventArgs e)
        {
            cboDanhMuc.Items.Add("Trà sữa");
            cboDanhMuc.Items.Add("Ăn vặt");

            cboDanhMuc.SelectedIndex = 0;
            //MessageBox.Show("Form đã load");

            dsMon.Add(new MonAn("Trà sữa boba", 120000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\boba.png", "Trà sữa"));
            dsMon.Add(new MonAn("Trà sữa việt quất", 45000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tsvietquat.png", "Trà sữa"));
            dsMon.Add(new MonAn("Trà sữa màu xanh", 45000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tsmauxanh.png", "Trà sữa"));
            dsMon.Add(new MonAn("Trà sữa màu cam", 45000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tsmaucam.png", "Trà sữa"));



            LoadMenu(cboDanhMuc.Text);
        }
        private void LoadMenu(string loai)
        {
            flpMenu.Controls.Clear();

            foreach (MonAn mon in dsMon)
            {

                if (mon.Loai != loai)
                    continue;

                Mon item = new Mon();

                item.TenMon = mon.TenMon;
                item.Gia = mon.Gia.ToString("N0");
                item.HinhAnh = Image.FromFile(mon.HinhAnh);

                item.MonDuocChon += (s, e) =>
                {

                    picAnhMon.Image = Image.FromFile(mon.HinhAnh);
                    txtTenMon.Text = mon.TenMon;
                    nmrGia.Value = Convert.ToDecimal(mon.Gia);
                };

                flpMenu.Controls.Add(item);
            }
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loai = cboDanhMuc.Text;

            LoadMenu(loai);
        }
    }
}
