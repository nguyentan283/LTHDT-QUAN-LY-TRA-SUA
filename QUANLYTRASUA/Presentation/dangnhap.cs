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

namespace WindowsFormsApp1.Dangnhap
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txttendn.Text.Trim() == "" || txtmk.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Bạn chưa nhập thông tin, vui lòng nhập đầy đủ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            manhinhchinh mhc = new manhinhchinh();
            mhc.Show();

            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dangki dk = new dangki();
            dk.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
