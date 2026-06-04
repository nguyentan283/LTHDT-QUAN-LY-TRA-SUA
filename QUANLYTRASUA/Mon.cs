using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Mon : UserControl
    {
        public string TenMon
        {
            get { return lblTenMon.Text; }
            set { lblTenMon.Text = value; }
        }

        public string Gia
        {
            get { return lblGia.Text; }
            set { lblGia.Text = value; }
        }

        public Image HinhAnh
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public Mon()
        {
            InitializeComponent();

            this.Click += Mon_Click;
            pictureBox1.Click += Mon_Click;
            lblTenMon.Click += Mon_Click;
            lblGia.Click += Mon_Click;
        }
        public event EventHandler MonDuocChon;

        private void Mon_Click(object sender, EventArgs e)
        {
            MonDuocChon?.Invoke(this, EventArgs.Empty);
        }
    }
}
