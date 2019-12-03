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
    public partial class PhongTro : DevExpress.XtraEditors.XtraForm
    {
        myDatabase kn = new myDatabase();
        public PhongTro()
        {
            InitializeComponent();
        }

        private void PhongTro_Load(object sender, EventArgs e)
        {
            LoadDuLieu();

        }

        private void LoadDuLieu()
        {
            string sql = "select * from PhongTro";
            dataGridViewPhong.DataSource = kn.getData(sql);
        }

        private void dtgv_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            txtGiaPhong.Text = dataGridViewPhong.Rows[e.RowIndex].Cells["GiaPhong"].Value.ToString();
            txtMaPhong.Text = dataGridViewPhong.Rows[e.RowIndex].Cells["MaPT"].Value.ToString();
            txtSNHT.Text = dataGridViewPhong.Rows[e.RowIndex].Cells["SoNguoiHienTai"].Value.ToString();
            txtSNTD.Text = dataGridViewPhong.Rows[e.RowIndex].Cells["SoNguoiToiDa"].Value.ToString();
            txtTenPhong.Text = dataGridViewPhong.Rows[e.RowIndex].Cells["TenPhong"].Value.ToString();
            txtTrangThai.Text = dataGridViewPhong.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

        }

        private void setControls(bool s)
        {
            btnThem.Enabled = s;
            btnLuu.Enabled = !s;
            btnHuy.Enabled = !s;
            btnSua.Enabled = s;
            btnXoa.Enabled = s;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(false);
            txtGiaPhong.ResetText();
            txtMaPhong.ResetText();
            txtMaPhong.Focus();
            txtSNHT.ResetText();
            txtSNTD.ResetText();
            txtTenPhong.ResetText();
            txtTrangThai.ResetText();

            LoadDuLieu();
            int count = 0;
            count = dataGridViewPhong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridViewPhong.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//Loại bỏ ký tự mã khach thue KT
            if (chuoi2 + 1 < 10)
                txtMaPhong.Text = "PT00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMaPhong.Text = "PT0" + (chuoi2 + 1).ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setControls(false);
            string s = "select * from PhongTro where MaPT='" + txtMaPhong.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.getData(s);

            if (dt.Rows.Count != 0)
            {
                string sql = "update PhongTro set TenPhong=N'" + txtTenPhong.Text
               + "'," + "TrangThai = N'" + txtTrangThai.Text + "'," + "SoNguoiToiDa = '" + txtSNTD.Text + "',"
                + "SoNguoiHienTai='" + txtSNHT.Text + "'," + "GiaPhong = '" + txtGiaPhong.Text + "'" +
               "Where MaPT ='" + txtMaPhong.Text + "'";
                kn.getData(sql);

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để sửa", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            setControls(false);
            string s = "select * from PhongTro where MaPT='" + txtMaPhong.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.getData(s);
            if (dt.Rows.Count != 0)
            {


                string sql = "delete from PhongTro where MaPT =('" + txtMaPhong.Text + "')";
                kn.getData(sql);
                txtGiaPhong.ResetText();
                txtMaPhong.ResetText();
                txtSNHT.ResetText();
                txtSNTD.ResetText();
                txtTrangThai.ResetText();
                txtTenPhong.ResetText();

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            setControls(true);
            string s = "select * from PhongTro where MaPT = '" + txtMaPhong.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.getData(s);

            if (dt.Rows.Count == 0)
            {

                string sql = "insert into PhongTro values ('" + txtMaPhong.Text + "','" +
                     txtTenPhong.Text + "','" + txtTrangThai.Text + "'," + txtSNTD.Text
                      + "," + txtSNHT.Text + "," + txtGiaPhong.Text + ")";

                kn.getData(sql);

                txtTenPhong.ResetText();
                txtMaPhong.ResetText();
                txtTrangThai.ResetText();
                txtGiaPhong.ResetText();
                txtSNHT.ResetText();
                txtSNTD.ResetText();


            }

            else
            {
                MessageBox.Show("mã thiết bị đã tồn tại, vui lòng nhập lại !", "Lỗi!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtSNTD.ResetText();
            txtSNHT.ResetText();
            txtGiaPhong.ResetText();
            txtTenPhong.ResetText();
            txtMaPhong.ResetText();
            txtTrangThai.ResetText();
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            string st = txtSeach.Text;
            string sql = string.Format("select * from phongtro where MaPT like N'%{0}%'", st);
            dataGridViewPhong.DataSource = kn.getData(sql);
        }

        private void dataGridViewPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}