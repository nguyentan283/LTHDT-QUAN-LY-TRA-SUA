using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dangnhap;

namespace WindowsFormsApp1.Presentation
{
    public partial class hoadon : Form
    {
        public hoadon()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadchitietmon()
        {
            dgvdsctm.ColumnCount = 6;
            dgvdsctm.Columns[0].Name = "STT";
            dgvdsctm.Columns[1].Name = "Tên món";
            dgvdsctm.Columns[2].Name = "Số lượng";
            dgvdsctm.Columns[3].Name = "Đơn giá";
            dgvdsctm.Columns[4].Name = "Thành tiền";
            dgvdsctm.Columns[5].Name = "Ghi chú";
        }
        private void dgvdsctm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            loadchitietmon();
            btnhoadon.BackColor = Color.Peru;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
            this.Hide();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            nhanvien nv = new nhanvien();
            nv.Show();
            this.Hide();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            manhinhchinh mhc = new manhinhchinh();
            mhc.Show();
            this.Hide();
        }

        private void btnquanlyban_Click(object sender, EventArgs e)
        {
            Ban qlb = new Ban();
            qlb.Show();
            this.Hide();
        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }
    }
}
