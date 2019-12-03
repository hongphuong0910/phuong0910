using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QliNhaTro.Views
{
    public partial class Dichvu : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connection ;
        myDatabase db = new myDatabase();
        private bool addNew;
        public Dichvu()
        {
            InitializeComponent();
        }
        public void setControls(bool s)
        {
            btn_Them.Enabled = s;
            btn_Sua.Enabled = s;
            btn_Xoa.Enabled = s;
            btn_Luu.Enabled = !s;
            //-----
            txtMaDV.Enabled = !s;
            txtTenDV.Enabled = !s;
            txtGia.Enabled = !s;
            txtDVtinh.Enabled = !s;
        }
      
        private void Dichvu_Load(object sender, EventArgs e)
        {
            String sql="Select * from Dichvu";
            refeshDataGridView(sql);
        }
        private void refeshDataGridView(String sql)
        {
            
            dtgvDichvu.DataSource = db.getData(sql);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            addNew = false;
            setControls(false);
            connection = new SqlConnection(db.con);
            String sql = "Select * From Dichvu ";
            refeshDataGridView(sql);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            setControls(false);
            addNew = true;
            txtMaDV.Focus();
            txtTenDV.Clear();
            txtGia.Clear();
            txtDVtinh.Clear();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            setControls(true);
            String sql = "Select * from Dichvu";
            refeshDataGridView(sql);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(db.con);
            String sql = "select * from Dichvu where TenDV like N'%" + textBox1.Text + "%'";
            db.getData(sql);
            refeshDataGridView(sql);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            setControls(true);

            DialogResult dr;
            dr = MessageBox.Show("Chắc chắn xóa dòng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No)
                return;

            //Lay du lieu tren luoi

            //Xoa
            connection = new SqlConnection(db.con);
            string sql = "delete from ChiTietHoaDon where MaDV = '" + txtMaDV.Text + "'";

            string sSql = "DELETE FROM Dichvu WHERE MaDV = '" + txtMaDV.Text + "'";
            db.getData(sql);
            db.getData(sSql);
            String sql2 = "Select * from Dichvu";
            refeshDataGridView(sql2);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "Tìm theo tên DV")
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = Color.Black;
                }
        
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Tìm theo tên DV";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void dtgvDichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                txtMaDV.Text = dtgvDichvu.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
                txtTenDV.Text = dtgvDichvu.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
                txtGia.Text = dtgvDichvu.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                txtDVtinh.Text = dtgvDichvu.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();

            
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dtgvDichvu.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtgvDichvu.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//Loại bỏ ký tự mã khach thue KT
            if (chuoi2 + 1 < 10)
                txtMaDV.Text = "DV00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMaDV.Text = "KT0" + (chuoi2 + 1).ToString();
            setControls(false);
            connection = new SqlConnection(db.con);
            if (addNew== true)
            {
                String sql = "INSERT INTO Dichvu " +
                         " values('" + txtMaDV.Text + "',N'" + txtTenDV.Text + "',N'" + txtGia.Text + "',N'" +
                         txtDVtinh.Text + "')";
                db.getData(sql);
                String sql3 = "Select * from Dichvu";
                refeshDataGridView(sql3);
            }
            else
            {
                String sql1 = "update Dichvu set TenDV = N'" +
                           txtTenDV.Text + "',DonViTinh = N'" + txtDVtinh.Text +
                         "',DonGia = '" + txtGia.Text + "' WHERE MaDV = '" + txtMaDV.Text + "'";
                 db.getData(sql1);
               // refeshDataGridView(sql1);
                String sql2 = "Select * from Dichvu";
                refeshDataGridView(sql2);

            }
        }

        private void dtgvDichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
