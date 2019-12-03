using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QliNhaTro
{
    public partial class Thutien : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connection;
        myDatabase db = new myDatabase();
        public Thutien()
        {
            InitializeComponent();
        }

       
        private void txtDien_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(db.con);
           
            if (txtDien.Text == String.Empty)
                txtDien.Text = "0";
            else
            {

                 DataTable dt = db.getData("select Dongia from Dichvu where MaDV ='DV001'");
           
             double tiendien = Convert.ToDouble(txtDien.Text);
            double tongtien1 = 0;
            foreach(DataRow dr in dt.Rows)
            {
                tongtien1 += double.Parse(dr["Dongia"].ToString()) * tiendien;
            }
                txtThanhtien1.Text = tongtien1.ToString();
            }

           
        }

        private void txtNuoc_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(db.con);

            if (txtNuoc.Text == String.Empty)
                txtNuoc.Text = "0";
            else
            {

                DataTable dt = db.getData("select Dongia from Dichvu where MaDV ='DV002'");
                double tienphong = Convert.ToDouble(txtTienPhong.Text);
                double tiennuoc = Convert.ToDouble(txtNuoc.Text);
                double tongtien1 = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    tongtien1 += double.Parse(dr["Dongia"].ToString()) * tiennuoc;
                }
                txtThanhtien2.Text = tongtien1.ToString();
            }
        }

        private void txtInternet_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(db.con);

            if (txtInternet.Text == String.Empty)
                txtInternet.Text = "0";
            else
            {

                DataTable dt = db.getData("select Dongia from Dichvu where MaDV ='DV003'");
                double tienphong = Convert.ToDouble(txtTienPhong.Text);

                double tienInternet = Convert.ToDouble(txtInternet.Text);
                double tongtien1 = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    tongtien1 += double.Parse(dr["Dongia"].ToString()) * tienInternet;
                }
                txtThanhtien3.Text = tongtien1.ToString();
            }
        }

       
        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

            
           
        }

        private void txtTongtien_Click(object sender, EventArgs e)
        {
            double tienphong = Convert.ToDouble(txtTienPhong.Text);

            double thanhtien1 = Convert.ToDouble(txtThanhtien1.Text);
            double thanhtien2 = Convert.ToDouble(txtThanhtien2.Text);
            double thanhtien3 = Convert.ToDouble(txtThanhtien3.Text);

            if (txtInternet.Text == String.Empty)
                txtInternet.Text = "0";
            else
            {
                double tongtien = 0;
                tongtien += thanhtien1 + thanhtien2 + thanhtien3 + tienphong;
                txtTongtien.Text = tongtien.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
               
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            //   try
            {
                connection = new SqlConnection(db.con);
                String sql = "insert into HoaDon values('" + txtMaHD.Text + "','" + txtTongtien.Text + "','" + dtNgayHD.Text + "')";
                string sql1 = "insert into QuanLyThuTien(Mahoadon,MaPT,Tinhtrang) values('" + txtMaHD.Text + "','" + txtMaPT.Text + "',N'Chua thu')";
                db.getData(sql);
                db.getData(sql1);
                if (txtDien.Text != "0")
                {
                    string sql2 = "insert into ChiTietHoaDon values('" + txtMaHD.Text + "','DV001','" + txtDien.Text + "','" + txtThanhtien1.Text + "')";
                    db.getData(sql2);
                }
               
                if (txtNuoc.Text != "0")
                {
                    string sql3 = "insert into ChiTietHoaDon values('" + txtMaHD.Text + "','DV002','" + txtNuoc.Text + "','" + txtThanhtien2.Text + "')";
                    db.getData(sql3);
                }
                if (txtInternet.Text != "0")
                {
                    string sql4 = "insert into ChiTietHoaDon values('" + txtMaHD.Text + "','DV003','" + txtDien.Text + "','" + txtThanhtien3.Text + "')";
                    db.getData(sql4);
                }

               
                
                MessageBox.Show("Lưu hóa đơn thành công");
            }
            /*catch
            {
                MessageBox.Show("Lỗi không thể lưu!");
            }*/
        }

        private void txtMaPT_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(db.con);
            String sql = "select * from PhongTro pt join ThuePhong tp on pt.MaPT=tp.MaPT" +
                 " where tp.MaPT like '%" + txtMaPT.Text + "%'";
            string sql1 = "select kt.MaKT,HoTen,Diachi,SDT from Khachthue kt join Thuephong tp on kt.MaKT=tp.MaKT where MaPT like '%" + txtMaPT.Text + "%'";

            db.getData(sql);
            dtgvKhachthue.DataSource = db.getData(sql1);

            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtTenphong.Text = (rd["Tenphong"].ToString());
                dtNgaythue.Text = (rd["Ngaythue"].ToString());
                txtNguoiHT.Text = (rd["Songuoihientai"].ToString());
                txtTienPhong.Text = (rd["Giaphong"].ToString());

            }
            //refeshDataGridView(sql);
            connection.Close();
            txtTongtien.Clear();
        }
    }
}
