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
            menu mn = new menu();
            mn.Show();
            this.Hide();
        }

        private void btnTrangchu_Click_1(object sender, EventArgs e)
        {
            manhinhchinh mhn = new manhinhchinh();
            mhn.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void menu_Load(object sender, EventArgs e)
        {
            btnmenu.BackColor = Color.Peru;
            btnmenu.ForeColor = Color.Ivory;
        }
    }
}
