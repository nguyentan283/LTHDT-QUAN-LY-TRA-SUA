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

        }

        private void btnTrangchu_Click_1(object sender, EventArgs e)
        {
            manhinhchinh mhn = new manhinhchinh();
            mhn.Show();
            this.Hide();
        }


    }
}
