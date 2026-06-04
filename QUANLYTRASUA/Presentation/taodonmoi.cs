using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dsmongoi();
        }
        void loadchitietmon()
        {
            dgvdsctm.ColumnCount = 5;
            dgvdsctm.Columns[0].Name = "STT";
            dgvdsctm.Columns[1].Name = "Tên món";
            dgvdsctm.Columns[3].Name = "Giá bán";
            dgvdsctm.Columns[2].Name = "Số lượng";
            dgvdsctm.Columns[4].Name = "Trạng thái";
        }
        private void dgvdsctm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            manhinhchinh mhn = new manhinhchinh();
            mhn.Show();
            this.Hide();
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
        void dsmongoi()
        {
            dgvdsmongoi.ColumnCount = 5;
            dgvdsmongoi.Columns[0].Name = "STT";
            dgvdsmongoi.Columns[1].Name = "Tên món";
            dgvdsmongoi.Columns[3].Name = "Giá bán";
            dgvdsmongoi.Columns[2].Name = "Số lượng";
            dgvdsmongoi.Columns[4].Name = "Trạng thái";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picqr_Click(object sender, EventArgs e)
        {

        }
    }
}
