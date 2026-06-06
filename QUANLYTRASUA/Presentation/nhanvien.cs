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
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {

        }
        void loadhanvien()
        {
            dgvnhanvien.Rows.Clear();
            dgvnhanvien.Columns.Clear();

            dgvnhanvien.ColumnCount = 5;

            dgvnhanvien.Columns[0].Name = "Mã NV";
            dgvnhanvien.Columns[1].Name = "Họ tên";
            dgvnhanvien.Columns[2].Name = "Chức vụ";
            dgvnhanvien.Columns[3].Name = "Số DT";
            dgvnhanvien.Columns[4].Name = "Trạng thái";

            dgvnhanvien.ReadOnly = true;

            dgvnhanvien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvnhanvien.MultiSelect = false;

            dgvnhanvien.AllowUserToAddRows = false;

            dgvnhanvien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvnhanvien.Rows[e.RowIndex];

                txtmanv.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                cbochucvu.Text = row.Cells[2].Value.ToString();
                txtsdt.Text = row.Cells[3].Value.ToString();
                cbotrangthai.Text = row.Cells[4].Value.ToString();
            }
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            loadhanvien();
            btnnhanvien.BackColor = Color.Peru;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnquanlyban_Click(object sender, EventArgs e)
        {
            
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void btnTrangchu_Click_1(object sender, EventArgs e)
        {
            manhinhchinh mhn = new manhinhchinh();
            mhn.Show();
            this.Hide();
        }

        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
            this.Hide();
        }

        private void btnhoadon_Click_1(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.Show();
            this.Hide();
        }

        private void btnquanlyban_Click_1(object sender, EventArgs e)
        {
            Ban qlb = new Ban();
            qlb.Show();
            qlb.Hide();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dgvnhanvien.Rows.Add(
            txtmanv.Text,
            txthoten.Text,
            cbochucvu.Text,
            txtsdt.Text,
            cbotrangthai.Text
        );

            MessageBox.Show("Thêm nhân viên thành công!");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvnhanvien.CurrentRow != null)
            {
                dgvnhanvien.CurrentRow.Cells[0].Value = txtmanv.Text;
                dgvnhanvien.CurrentRow.Cells[1].Value = txthoten.Text;
                dgvnhanvien.CurrentRow.Cells[2].Value = cbochucvu.Text;
                dgvnhanvien.CurrentRow.Cells[3].Value = txtsdt.Text;
                dgvnhanvien.CurrentRow.Cells[4].Value = cbotrangthai.Text;

                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvnhanvien.CurrentRow != null)
            {
                DialogResult rs = MessageBox.Show(
                    "Bạn có muốn xóa nhân viên này?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    dgvnhanvien.Rows.RemoveAt(
                        dgvnhanvien.CurrentRow.Index);
                }
            }
        }
        void ClearData()
        {
            txtmanv.Clear();
            txthoten.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtluongcoban.Clear();

            cbochucvu.SelectedIndex = -1;
            cbotrangthai.SelectedIndex = -1;
        }
    }
}
