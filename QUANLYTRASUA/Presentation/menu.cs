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
using WindowsFormsApp1.Presentation;

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
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
            //menu mn = new menu();
            //mn.Show();
            //this.Hide();
            this.Show();
        }

        private void btnTrangchu_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnnhanvien_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnquanlyban_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvMenu_CellClick(object sender,
                               DataGridViewCellEventArgs e)
        {

        }

        public class MonAn
        {
            public string TenMon { get; set; }
            public int Gia { get; set; }
            public string HinhAnh { get; set; }

            public MonAn(string tenMon, int gia, string hinhAnh)
            {
                TenMon = tenMon;
                Gia = gia;
                HinhAnh = hinhAnh;
            }
        }
        List<MonAn> dsMon = new List<MonAn>();

        private void menu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form đã load");

            dsMon.Add(new MonAn("Trà sữa Trân Châu", 45000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\boba.png"));
            dsMon.Add(new MonAn("Trà sữa Việt Quất", 40000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tsvq.png"));
            dsMon.Add(new MonAn("Trà sữa Matcha Latte", 42000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tsmc.png"));
            dsMon.Add(new MonAn("Trà sữa Ô Long", 45000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tsolong.png"));
            dsMon.Add(new MonAn("Trà sữa Khoai Môn", 45000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tskm.png"));
            dsMon.Add(new MonAn("Trà sữa Bạc Hà", 40000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tsbh.png"));
            dsMon.Add(new MonAn("Trà sữa Dâu", 45000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tsd.png"));
            dsMon.Add(new MonAn("Trà sữa Phô Mai", 42000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\tspm.png"));
            dsMon.Add(new MonAn("Khoai Tây Chiên", 20000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\ktc.png"));
            dsMon.Add(new MonAn("Bắp Xào", 20000, @"C:\Users\HP\LTHDT-QUAN-LY-TRA-SUA\QUANLYTRASUA\Images\bx.png"));




            LoadMenu();
        }
        private void LoadMenu(List<MonAn> danhSach = null)
        {
            flpMenu.Controls.Clear();

            if (danhSach == null)
                danhSach = dsMon;

            foreach (MonAn mon in danhSach)
            {
                Mon item = new Mon();

                item.TenMon = mon.TenMon;
                item.Gia = mon.Gia.ToString("N0");
                item.HinhAnh = Image.FromFile(mon.HinhAnh);

                item.MonDuocChon += (s, e) =>
                {
                    picAnhMon.Image = Image.FromFile(mon.HinhAnh);
                    txtTenMon.Text = mon.TenMon;
                    nmrGia.Value = Convert.ToDecimal(mon.Gia);
                };

                flpMenu.Controls.Add(item);
            }
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            List<MonAn> ketQua = dsMon
                .Where(m => m.TenMon.ToLower().Contains(tuKhoa))
                .ToList();

            LoadMenu(ketQua);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng chọn món trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenMon = txtTenMon.Text;
            decimal gia = nmrGia.Value;
            decimal soLuong = nmrSoLuong.Value; 

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nmrSoLuong.Value = 0;
        }

        private void btnTrangchu_Click_2(object sender, EventArgs e)
        {
            manhinhchinh mhn = new manhinhchinh();
            mhn.Show();
            this.Hide();
        }

        private void btnnhanvien_Click_2(object sender, EventArgs e)
        {
            nhanvien nv = new nhanvien();
            nv.Show();
            this.Hide();
        }

        private void btnquanlyban_Click_1(object sender, EventArgs e)
        {
            Ban qlb = new Ban();
            qlb.Show();
            this.Hide();
        }

        private void btnhoadon_Click_1(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.Show();
            this.Hide();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }
    }
}
