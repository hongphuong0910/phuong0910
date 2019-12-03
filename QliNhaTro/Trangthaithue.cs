using QliNhaTro.Views;
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

namespace QliNhaTro
{
    public partial class Trangthaithue : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connection;
        myDatabase db = new myDatabase();

        private void refeshDataGridView(String sql)
        {

            dtgvDathue.DataSource = db.getData(sql);
        }
        private void refeshDataGridView1(String sql1)
        {

            dtgvDsKhach.DataSource = db.getData(sql1);
        }
        public Trangthaithue()
        {
            InitializeComponent();
        }
       private void Trangthaithue_Load(object sender, EventArgs e)
            {
                String sql = "select * from PhongTro";
                refeshDataGridView(sql);

                string sql1 = "select kt.MaKT,HoTen,TienDatCoc,NgayThue,TrangThai from KhachThue kt join ThuePhong pt" +
                    " on kt.MaKT=pt.MaKT";
                refeshDataGridView1(sql1);
            }
        private void dtgvDathue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMaPT.Text = dtgvDathue.Rows[e.RowIndex].Cells["MaPT"].Value.ToString();
            txtNguoiHT.Text = dtgvDathue.Rows[e.RowIndex].Cells["Songuoihientai"].Value.ToString();
            txtNguoiTD.Text = dtgvDathue.Rows[e.RowIndex].Cells["SoNguoitoida"].Value.ToString();

            string sql = "select kt.MaKT,HoTen,TienDatCoc,NgayThue,TrangThai from KhachThue kt join ThuePhong pt " +
                "on kt.MaKT=pt.MaKT where MaPT='" + txtMaPT.Text + "'";
           dtgvDsKhach.DataSource= db.getData(sql);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Dangkithue dki = new Dangkithue();
            //dki.MdiParent = this;
            dki.Show();
        }

        private void dtgvDathue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
