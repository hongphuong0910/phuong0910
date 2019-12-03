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
using System.Data.SqlClient;

namespace QliNhaTro.Views
{
    public partial class Dangkithue : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connection ;
        myDatabase db = new myDatabase();
         bool modelNew;
        public Dangkithue()
        {
            InitializeComponent();
        }

        private void Dangkithue_Load(object sender, EventArgs e)
        {
            String sql = "select MaPT, Khachthue.MaKT,Hoten,CMND,Ngaysinh,Gioitinh," +
                "SDT,NgheNghiep,Diachi,Ngaythue,Tiendatcoc,Trangthai from Khachthue join Thuephong on Khachthue.MaKT=Thuephong.MaKT";
            refeshDataGridView(sql);
            
        }
        private void refeshDataGridView(String sql)
        {

            dtgvThuephong.DataSource = db.getData(sql);
        }
        private void setControls(bool s)
        {
            btnDangki.Enabled = s;
            btnLuu.Enabled = !s;
            btnHuy.Enabled = !s;
            btnSua.Enabled = s;
            btnDelete.Enabled = s;
            //-------------
            txtMaPT.Enabled = !s;
            txtMAKT.Enabled = !s;
            txtCMND.Enabled = !s;
            txtNgheNghiep.Enabled = !s;
            txtHoten.Enabled = !s;
            txtdatcoc.Enabled = !s;
            txtDiachi.Enabled = !s;
            txtGioitinh.Enabled = !s;
            dtNgaythue.Enabled = !s;
            dateENgaysinh.Enabled = !s;
            txtSDT.Enabled = !s;
            txtTrangthai.Enabled = !s;
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            setControls(false);
            modelNew = true;
            txtMaPT.Focus ();
            //txtMAKT.Enabled=false;
            txtMAKT.Clear();
            txtHoten.Clear();
            txtNgheNghiep.Clear();
            txtSDT.Clear();
            txtGioitinh.ResetText();
            txtDiachi.Clear();
            txtCMND.Clear();
            txtCMND.Clear();
            dateENgaysinh.ResetText();
            dtNgaythue.ResetText();
            txtdatcoc.Clear();
            txtTrangthai.Clear();
          /*  int count = 0;
            count = dtgvThuephong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtgvThuephong.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//Loại bỏ ký tự mã khach thue KT
            if (chuoi2 + 1 < 10)
                txtMAKT.Text = "KT00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMAKT.Text = "KT0" + (chuoi2 + 1).ToString();*/

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            setControls(true);
            modelNew = false;
            DialogResult dr;
            dr = MessageBox.Show("Chắc chắn xóa dòng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) 
                return;

            //Lay du lieu tren luoi

            //Xoa
            connection = new SqlConnection(db.con);
            //string sSql = "DELETE FROM Phongtro WHERE MaPT = '" + txtMaPT.Text + "'";

            string sSql1 = "DELETE FROM Thuephong WHERE MaKT = '" + txtMAKT.Text+"'and MaPT ='"+txtMaPT.Text+"'";
            string sSql2 = "DELETE FROM Khachthue WHERE MaKT = '" + txtMAKT.Text + "'";
            DataTable td = db.getData("update PhongTro set songuoihientai = songuoihientai-1 where MaPT = '" + txtMaPT.Text + "'");
           // db.getData(sSql);
            db.getData(sSql1);
            db.getData(sSql2);
            String sql = "select MaPT, Khachthue.MaKT,Hoten,CMND,Ngaysinh,Gioitinh," +
                "SDT,NgheNghiep,Diachi,Ngaythue,Tiendatcoc,Trangthai from Khachthue join Thuephong on Khachthue.MaKT=Thuephong.MaKT";
            refeshDataGridView(sql);
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            modelNew = false;
            setControls(false);
            connection = new SqlConnection(db.con);

            String sql = "select MaPT, Khachthue.MaKT,Hoten,CMND,Ngaysinh,Gioitinh," +
                "SDT,NgheNghiep,Diachi,Ngaythue,Tiendatcoc,Trangthai from Khachthue join Thuephong on Khachthue.MaKT=Thuephong.MaKT";
            refeshDataGridView(sql);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(db.con);
            String sql = "SELECT MaPT,kt.MaKT,Hoten,Gioitinh,CMND,Ngaysinh,Nghenghiep,Tiendatcoc,SDT,Diachi,Ngaythue FROM Thuephong tp join Khachthue kt " +
             "on tp.MaKT=kt.MaKT WHERE MaPT LIKE '%" + txtSearch.Text + "%'";
            dtgvThuephong.DataSource = db.getData(sql);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setControls(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy nhập tên khách thuê", "Thông báo");
                    txtHoten.Focus();
                    return;
                }
                /* if (txtGioitinh.Text.Trim() == "")
                 {
                     MessageBox.Show("Hãy nhập tên khách thuê", "Thông báo");
                     txtGioitinh.Focus();
                     return;
                 }
                 if (txtDiachi.Text.Trim() == "")
                 {
                     MessageBox.Show("Hãy nhập tên khách thuê", "Thông báo");
                     txtDiachi.Focus();
                     return;
                 }
                 if (txtdatcoc.Text.Trim() == "")
                 {
                     MessageBox.Show("Hãy nhập tên khách thuê", "Thông báo");
                     txtdatcoc.Focus();
                     return;
                 }
                 if (txtNgheNghiep.Text.Trim() == "")
                 {
                     MessageBox.Show("Hãy nhập tên khách thuê", "Thông báo");
                     txtNgheNghiep.Focus();
                     return;
                 }
                 if (txtSDT.Text.Trim() == "")
                 {
                     MessageBox.Show("Hãy nhập tên khách thuê", "Thông báo");
                     txtSDT.Focus();
                     return;
                 }*/
                setControls(true);
                connection = new SqlConnection(db.con);
          /*  int count = 0;
            count = dtgvThuephong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtgvThuephong.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//Loại bỏ ký tự mã khach thue KT
            if (chuoi2 + 1 < 10)
                txtMAKT.Text = "KT00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMAKT.Text = "KT0" + (chuoi2 + 1).ToString();*/

            if (modelNew == true)
                {
                try
                {
                    //String sql = "INSERT INTO Phongtro(MaPT)" + "values('" + txtMaPT.Text + "')";
                    String sql1 = "INSERT INTO Khachthue " +
                             " values('" + txtMAKT.Text + "',N'" + txtHoten.Text + "',N'" + txtGioitinh.Text + "','" + dateENgaysinh.Text +
                             "','" + txtCMND.Text + "',N'" + txtNgheNghiep.Text
                             + "',N'" + txtDiachi.Text + "','" + txtSDT.Text + "')";
                   
                    String sql2 = "INSERT INTO ThuePhong" +
                                 " values('"
                                 + txtMAKT.Text + "','"
                                 + txtMaPT.Text + "','"
                                 + txtdatcoc.Text + "','"
                                  + dtNgaythue.Text
                                  + "',N'" + txtTrangthai.Text + "')";

                    // dtgvThuephong.DataSource = db.getData(sql);
                    dtgvThuephong.DataSource = db.getData(sql1);
                    dtgvThuephong.DataSource = db.getData(sql2);
                    DataTable td = db.getData("update PhongTro set songuoihientai = songuoihientai+1 where MaPT = '" + txtMaPT.Text + "'");

                }
                catch
                {
                    MessageBox.Show("Lỗi không thêm được");
                }
               
                /*String sql3 = "select MaPT, Khachthue.MaKT,Hoten,CMND,Ngaysinh,Gioitinh," +
                    "SDT,NgheNghiep,Diachi,Ngaythue,Tiendatcoc,Trangthai from Khachthue join Thuephong on Khachthue.MaKT=Thuephong.MaKT";
                refeshDataGridView(sql3);*/

            }
            else
                {
                    String sql3 = "update Phongtro set MaPT = '" + txtMaPT.Text + "' WHERE MaPT = '" + txtMaPT.Text + "'";
                    String sql4 = "update Khachthue set Hoten = N'" +
                          txtHoten.Text + "',gioitinh = N'" + txtGioitinh.Text + "',Ngaysinh = '" + dateENgaysinh.Text +
                         "',CMND = '" + txtCMND.Text + "',Nghenghiep = N'" + txtNgheNghiep.Text
                         + "',Diachi = N'" + txtDiachi.Text + "',SDT ='" + txtSDT.Text + "' WHERE MaKT = '" + txtMAKT.Text + "'";
                    String sql5 = "update Thuephong set Ngaythue = '" +
                                          dtNgaythue.Text + "',Tiendatcoc = '" + txtdatcoc.Text +
                                        "',Trangthai = N'" + txtTrangthai.Text + "' WHERE MaKT = '" + txtMAKT.Text+"' and MaPT='"+txtMaPT.Text + "'";
                   dtgvThuephong.DataSource = db.getData(sql3);
                   dtgvThuephong.DataSource = db.getData(sql4);
                   dtgvThuephong.DataSource = db.getData(sql5); 
                  

                }
                    String sql6 = "select MaPT, Khachthue.MaKT,Hoten,CMND,Ngaysinh,Gioitinh," +
                        "SDT,NgheNghiep,Diachi,Ngaythue,Tiendatcoc,Trangthai from Khachthue join Thuephong on Khachthue.MaKT=Thuephong.MaKT";
                    refeshDataGridView(sql6);
        }

        private void dtgvThuephong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

                txtMaPT.Text = dtgvThuephong.Rows[e.RowIndex].Cells["MaPT"].Value.ToString();
                txtMAKT.Text = dtgvThuephong.Rows[e.RowIndex].Cells["MaKT"].Value.ToString();
                txtHoten.Text = dtgvThuephong.Rows[e.RowIndex].Cells["Hoten"].Value.ToString();
                txtGioitinh.Text = dtgvThuephong.Rows[e.RowIndex].Cells["Gioitinh"].Value.ToString();
                dateENgaysinh.Text = dtgvThuephong.Rows[e.RowIndex].Cells["Ngaysinh"].Value.ToString();
                txtCMND.Text = dtgvThuephong.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
                txtNgheNghiep.Text = dtgvThuephong.Rows[e.RowIndex].Cells["NgheNghiep"].Value.ToString();
                txtDiachi.Text = dtgvThuephong.Rows[e.RowIndex].Cells["Diachi"].Value.ToString();
                txtSDT.Text = dtgvThuephong.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                txtdatcoc.Text = dtgvThuephong.Rows[e.RowIndex].Cells["Tiendatcoc"].Value.ToString();
                dtNgaythue.Text = dtgvThuephong.Rows[e.RowIndex].Cells["Ngaythue"].Value.ToString();
                txtTrangthai.Text = dtgvThuephong.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

            
        }

        private void dtgvThuephong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
