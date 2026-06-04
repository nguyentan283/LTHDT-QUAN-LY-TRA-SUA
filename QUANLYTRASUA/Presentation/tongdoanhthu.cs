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
    public partial class tongdoanhthu : Form
    {
        public tongdoanhthu()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tongdoanhthu_Load(object sender, EventArgs e)
        {
            lbldthn.Text = "0 VND";
            lbldttn.Text = "0 VND";
            lbldtt.Text = "0";
            lbldahuy.Text = "0";
            lblck.Text = "0 VND";
            lbltm.Text = "0 VND";

            chart1.Series.Clear();

            chart1.Series.Add("DoanhThu");

            chart1.Series["DoanhThu"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            for (int i = 1; i <= 7; i++)
            {
                chart1.Series["DoanhThu"].Points.AddXY("Ngày " + i, 0);
            }

            chart1.Series["DoanhThu"]["PointWidth"] = "0.3";

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            manhinhchinh mhc = new manhinhchinh();
            mhc.Show();
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
    }
}
