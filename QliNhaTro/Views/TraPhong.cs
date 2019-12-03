using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QliNhaTro.Views
{
    public partial class TraPhong : DevExpress.XtraEditors.XtraForm
    {
        myDatabase kn = new myDatabase();
        public TraPhong()
        {
            InitializeComponent();
        }



        private void TraPhong_Load(object sender, EventArgs e)
        {
            LoadDuLieuKT();
            LoadDuLieuTP();
            LoadDuLieuThuTien();
        }
        private void LoadDuLieuKT()
        {
            string s = "select * from KhachThue";
            dataGridViewKhachThue.DataSource = kn.getData(s);
        }

        private void LoadDuLieuTP()
        {
            string s = "select * from ThuePhong";
            dataGridViewThuePhong.DataSource = kn.getData(s);
        }

        private void LoadDuLieuThuTien()
        {
            string s = "select * from quanlythutien";
            dataGridViewThanhToan.DataSource = kn.getData(s);
        }

        private void dataGridViewKhachThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCmnd.Text = dataGridViewKhachThue.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
            txtMaKT.Text = dataGridViewKhachThue.Rows[e.RowIndex].Cells["MaKT"].Value.ToString();
            txtHoTen.Text = dataGridViewKhachThue.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            txtNgaySinh.Text = dataGridViewKhachThue.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            txtNgheNghiep.Text = dataGridViewKhachThue.Rows[e.RowIndex].Cells["NgheNghiep"].Value.ToString();
            txtSDT.Text = dataGridViewKhachThue.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txtGioiTinh.Text = dataGridViewKhachThue.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            txtDiaChi.Text = dataGridViewKhachThue.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
        }

        private void dataGridViewThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMKT.Text = dataGridViewThuePhong.Rows[e.RowIndex].Cells["MaKT"].Value.ToString();
            txtMaPT.Text = dataGridViewThuePhong.Rows[e.RowIndex].Cells["MaPT"].Value.ToString();
            txtNgayThue.Text = dataGridViewThuePhong.Rows[e.RowIndex].Cells["NgayThue"].Value.ToString();
            txtDatCoc.Text = dataGridViewThuePhong.Rows[e.RowIndex].Cells["TienDatCoc"].Value.ToString();
            txtTrangThai.Text = dataGridViewThuePhong.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            string st = txtSeach.Text;
            string sql = string.Format("select * from quanlythutien where MaPT like N'%{0}%'", st);
            dataGridViewThanhToan.DataSource = kn.getData(sql);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            string s1 = "select * from KhachThue where MaKT='" + txtMaKT.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.getData(s1);

            string s2 = "select * from ThuePhong where MaPT='" + txtMaPT.Text + "'";
            DataTable dt1 = new DataTable();
            dt = kn.getData(s2);


            if (dt.Rows.Count != 0)
            {
                string s = "delete from KhachThue where MaKT ='" + txtMaKT.Text + "'";
                kn.getData(s);

                txtGioiTinh.ResetText();
                txtCmnd.ResetText();
                txtHoTen.ResetText();
                txtNgaySinh.ResetText();
                txtNgheNghiep.ResetText();
                txtSDT.ResetText();
                txtMaKT.ResetText();
                txtDiaChi.ResetText();


                string sql = "delete from ThuePhong where MaPT ='" + txtMaPT.Text + "'";
                kn.getData(sql);

                txtMKT.ResetText();
                txtMaPT.ResetText();
                txtNgayThue.ResetText();
                txtDatCoc.ResetText();
                txtTrangThai.ResetText();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieuKT();
            LoadDuLieuTP();

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string st = txtTimKiem.Text;
            string sql = string.Format("select * from ThuePhong where MaKT like N'%{0}%'", st);
            dataGridViewThuePhong.DataSource = kn.getData(sql);
        }
    }
}