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
        // Danh sách bàn
        List<Ban> dsBan = new List<Ban>();

        public QuanLyBan()
        {
            InitializeComponent();

            dgvBan.CellClick += dgvBan_CellClick;

            // Chỉ đọc DataGridView
            dgvBan.ReadOnly = true;

            // Chỉ chọn nguyên dòng
            dgvBan.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Chỉ chọn 1 dòng
            dgvBan.MultiSelect = false;

            // Ẩn dòng trắng cuối
            dgvBan.AllowUserToAddRows = false;
        }

        // ================= HIỂN THỊ =================
        void HienThiDanhSach()
        {
            dgvBan.DataSource = null;
            dgvBan.DataSource = dsBan;
        }

        // ================= THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (txtMaBan.Text == "" || txtSucChua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
                return;
            }

            // Kiểm tra sức chứa phải là số
            if (!int.TryParse(txtSucChua.Text, out int sc))
            {
                MessageBox.Show("Sức chứa phải là số");
                return;
            }

            // Kiểm tra trùng mã bàn
            foreach (Ban b in dsBan)
            {
                if (b.MaBan == txtMaBan.Text)
                {
                    MessageBox.Show("Mã bàn đã tồn tại");
                    return;
                }
            }

            // Thêm bàn
            Ban banMoi = new Ban();

            banMoi.MaBan = txtMaBan.Text;
            banMoi.SucChua = sc;

            dsBan.Add(banMoi);

            HienThiDanhSach();

            MessageBox.Show("Thêm thành công");
        }

        // ================= SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSucChua.Text, out int sc))
            {
                MessageBox.Show("Sức chứa phải là số");
                return;
            }

            bool timThay = false;

            foreach (Ban b in dsBan)
            {
                if (b.MaBan == txtMaBan.Text)
                {
                    b.SucChua = sc;
                    timThay = true;
                    break;
                }
            }

            if (timThay)
            {
                HienThiDanhSach();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã bàn");
            }
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show(
                "Bạn có muốn xóa không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (tb == DialogResult.Yes)
            {
                for (int i = 0; i < dsBan.Count; i++)
                {
                    if (dsBan[i].MaBan == txtMaBan.Text)
                    {
                        dsBan.RemoveAt(i);

                        HienThiDanhSach();

                        MessageBox.Show("Xóa thành công");

                        return;
                    }
                }

                MessageBox.Show("Không tìm thấy mã bàn");
            }
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
            DialogResult tb = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (tb == DialogResult.Yes)
            {
                Application.Exit();
            }
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
            string ma = txtTimKiem.Text;

            var ketQua = dsBan
                .Where(x => x.MaBan.Contains(ma))
                .ToList();

            dgvBan.DataSource = null;
            dgvBan.DataSource = ketQua;
        }

    }
}
