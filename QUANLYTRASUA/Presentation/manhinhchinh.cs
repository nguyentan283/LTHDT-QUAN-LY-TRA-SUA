using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dangnhap;

namespace WindowsFormsApp1.Presentation
{
    public partial class manhinhchinh : Form
    {
        public manhinhchinh()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void manhinhchinh_Load(object sender, EventArgs e)
        {
            Taoban();
            LoadHoaDon();
            btnTrangchu.BackColor = Color.Peru;
            btnTrangchu.ForeColor = Color.Ivory;
        }
        void LoadHoaDon()
        {
            dgvHoaDon.ColumnCount = 7;

            dgvHoaDon.Columns[0].Name = "Mã HD";
            dgvHoaDon.Columns[4].Name = "Bàn";
            dgvHoaDon.Columns[2].Name = "Mã NV";
            dgvHoaDon.Columns[5].Name = "Tổng tiền";
            dgvHoaDon.Columns[1].Name = "Ngày";
            dgvHoaDon.Columns[3].Name = "Mã KH";
            dgvHoaDon.Columns[6].Name = "Trạng thái";
        }
        void Taoban()
        {
            for (int i = 1; i <= 15; i++)
            {
                Button btn = new Button();
                btn.Width = 90;
                btn.Height = 70;
                btn.Text = "Bàn" + i;
                btn.BackColor = Color.Beige;
                btn.Tag = i;
                btn.Click += Btn_Click;
                flbBan.Controls.Add(btn);

            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            MessageBox.Show(btn.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyBan qlb = new QuanLyBan();
            qlb.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            nhanvien nv = new nhanvien();
            nv.Show();
            this.Hide();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
            this.Hide();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.Show();
            this.Hide();
        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            taodonmoi tdm = new taodonmoi();
            tdm.Show();
            this.Hide();
        }
    }
}
