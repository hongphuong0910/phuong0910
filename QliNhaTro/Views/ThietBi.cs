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
using System.Data.SqlClient;

namespace QliNhaTro.Views
{
    public partial class ThietBi : DevExpress.XtraEditors.XtraForm
    {

        myDatabase kn = new myDatabase();
        public ThietBi()
        {
            InitializeComponent();
        }



        private void ThietBi_Load(object sender, EventArgs e)
        {

            LoadDuLieu();
        }

        private void LoadDuLieu()
        {

            dataGridViewTB.DataSource = kn.getData("select * from thietbi");

        }

        private void setControls(bool s)
        {
            btnThem.Enabled = s;
            btnLuu.Enabled = !s;
            btnHuy.Enabled = !s;
            btnSua.Enabled = s;
            btnXoa.Enabled = s;

        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtGia.ResetText();
            txtMaTB.Focus();
            txtSeach.ResetText();
            txtTenTB.ResetText();
            txtTinhTrang.ResetText();

            LoadDuLieu();


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            setControls(true);

            string s = "select * from thietbi where matb = '" + txtMaTB.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.getData(s);

            if (dt.Rows.Count == 0)
            {
                string sql = "insert into thietbi values ('" + txtMaTB.Text + "','" +
                      txtTenTB.Text + "',N'" + txtTinhTrang.Text + "','" + txtGia.Text + "')";
                kn.getData(sql);

                txtTenTB.ResetText();
                txtMaTB.ResetText();
                txtTinhTrang.ResetText();
                txtGia.ResetText();

            }

            else
            {
                MessageBox.Show("mã thiết bị đã tồn tại, vui lòng nhập lại !", "Lỗi!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(false);
            txtGia.ResetText();
            txtMaTB.ResetText();
            txtMaTB.Focus();
            txtTenTB.ResetText();
            txtTinhTrang.ResetText();

            LoadDuLieu();
            int count = 0;
            count = dataGridViewTB.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridViewTB.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//Loại bỏ ký tự mã khach thue KT
            if (chuoi2 + 1 < 10)
                txtMaTB.Text = "TB00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMaTB.Text = "TB0" + (chuoi2 + 1).ToString();
        }

        private void dtgrvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTinhTrang.Text = dataGridViewTB.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
            txtTenTB.Text = dataGridViewTB.Rows[e.RowIndex].Cells["TenTB"].Value.ToString();
            txtMaTB.Text = dataGridViewTB.Rows[e.RowIndex].Cells["MaTB"].Value.ToString();
            txtGia.Text = dataGridViewTB.Rows[e.RowIndex].Cells["GiaTB"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setControls(false);
            string s = "select * from thietbi where matb='" + txtMaTB.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.getData(s);

            if (dt.Rows.Count != 0)
            {
                string sql = "update ThietBi set TenTB=N'" + txtTenTB.Text
               + "'," + "TinhTrang = N'" + txtTinhTrang.Text + "'," + "GiaTB = " + txtGia.Text +
               "Where MaTB ='" + txtMaTB.Text + "'";
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
            string s = "select * from thietbi where matb='" + txtMaTB.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.getData(s);
            if (dt.Rows.Count != 0)
            {
                string sql = "delete from thietbi where matb = ('" + txtMaTB.Text + "')";
                kn.getData(sql);
                txtGia.ResetText();
                txtMaTB.ResetText();
                txtTenTB.ResetText();
                txtTinhTrang.ResetText();

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieu();
        }



        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            string st = txtSeach.Text;
            string sql = string.Format("select * from thietbi where MaTB like N'%{0}%'", st);
            dataGridViewTB.DataSource = kn.getData(sql);
        }

    }
}