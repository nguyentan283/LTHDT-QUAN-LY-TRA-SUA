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
    public partial class taodonmoi : Form
    {
        public taodonmoi()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void taodonmoi_Load(object sender, EventArgs e)
        {
            loadchitietmon();
           
        }
        void loadchitietmon()
        {
            dgvdsctm.ColumnCount = 4;
            dgvdsctm.Columns[0].Name = "STT";
            dgvdsctm.Columns[1].Name = "Tên món";
            dgvdsctm.Columns[3].Name = "Giá bán";
            dgvdsctm.Columns[2].Name = "Số lượng";
            
        }
        private void dgvdsctm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntaoqr_Click(object sender, EventArgs e)
        
          
        {
            string bank = "MB";
            string stk = "123456789";
            string tenTK = "4CUTI";

            string tongTien = txttongtien.Text;
            string maHD = txtmahd.Text;

            string url = "https://img.vietqr.io/image/"
                + bank + "-" + stk + "-compact2.png"
                + "?amount=" + tongTien
                + "&addInfo=" + maHD
                + "&accountName=" + tenTK;

            picqr.Load(url);
        
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picqr_Click(object sender, EventArgs e)
        {

        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTrangchu_Click_1(object sender, EventArgs e)
        {
            manhinhchinh mhn = new manhinhchinh();
            mhn.Show();
            this.Hide();
        }

        private void btnhoadon_Click_1(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.Show();
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

        private void btnquanlyban_Click(object sender, EventArgs e)
        {
            Ban qlb = new Ban();
            qlb.Show();
            this.Hide();
        }
    }
}
