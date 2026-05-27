using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1.Presentation
{
    public partial class QuanLyBan : Form
    {
        DataTable dt = new DataTable();

        public QuanLyBan()
        {
            InitializeComponent();

            dgvBan.CellClick += dgvBan_CellClick;

            // Tạo cột
            dt.Columns.Add("MaBan");
            dt.Columns.Add("SucChua");

            dgvBan.DataSource = dt;

            // Chỉ đọc
            dgvBan.ReadOnly = true;

            // Chọn nguyên dòng
            dgvBan.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Chỉ chọn 1 dòng
            dgvBan.MultiSelect = false;

            // Ẩn dòng trắng
            dgvBan.AllowUserToAddRows = false;
        }

        // ================= THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "" || txtSucChua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }

            // Kiểm tra trùng mã bàn
            foreach (DataRow row in dt.Rows)
            {
                if (row["MaBan"].ToString() == txtMaBan.Text)
                {
                    MessageBox.Show("Mã bàn đã tồn tại");
                    return;
                }
            }

            // Thêm dòng mới
            dt.Rows.Add(
                txtMaBan.Text,
                txtSucChua.Text
            );

            MessageBox.Show("Thêm thành công");
        }

        // ================= SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["MaBan"].ToString() == txtMaBan.Text)
                {
                    row["SucChua"] = txtSucChua.Text;

                    MessageBox.Show("Sửa thành công");
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy mã bàn");
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MaBan"].ToString() == txtMaBan.Text)
                {
                    dt.Rows.RemoveAt(i);

                    MessageBox.Show("Xóa thành công");
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy mã bàn");
        }

        // ================= XÓA TRẮNG =================
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaBan.Clear();
            txtSucChua.Clear();
            txtTimKiem.Clear();

            txtMaBan.Focus();
        }

        // ================= THOÁT =================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================= CLICK DGV =================
        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaBan.Text =
                    dgvBan.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtSucChua.Text =
                    dgvBan.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        // ================= TÌM KIẾM =================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.ToLower();

            foreach (DataGridViewRow row in dgvBan.Rows)
            {
                row.Visible = true;

                if (!row.Cells[0].Value
                    .ToString()
                    .ToLower()
                    .Contains(ma))
                {
                    row.Visible = false;
                }


            }
        }

    }
}
