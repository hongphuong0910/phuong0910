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
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connection;
        myDatabase db = new myDatabase();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void dtgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dtgvHoadon.Rows[e.RowIndex].Cells["Mahoadon"].Value.ToString();
            dtNgaythu.Text = dtgvHoadon.Rows[e.RowIndex].Cells["Ngaythu"].Value.ToString();


        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(db.con);
            String sql = "select hd.MaHoaDon,TongTien,TinhTrang,NgayLap,NgayThu from HoaDon hd join QuanLyThuTien ql" +
                " on ql.MaHoaDon=hd.MaHoaDon ";
            refeshDataGridView(sql);
        }
        private void refeshDataGridView(String sql)
        {

            dtgvHoadon.DataSource = db.getData(sql);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string sql = "update QuanLyThuTien set Tinhtrang = N'Đã đóng tiền',Ngaythu='"+dtNgaythu.Text+"' where Mahoadon = '"+txtMaHD.Text+"'";
            db.getData(sql);

            String sql1 = "select hd.MaHoaDon,TongTien,TinhTrang,NgayLap,NgayThu from HoaDon hd join QuanLyThuTien ql" +
                " on ql.MaHoaDon=hd.MaHoaDon ";
            refeshDataGridView(sql1);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sql = "update QuanLyThuTien set Tinhtrang = N'Chưa đóng tiền' where Mahoadon = '" + txtMaHD.Text + "'";
            db.getData(sql);

            String sql1 = "select hd.MaHoaDon,TongTien,TinhTrang,NgayLap,NgayThu from HoaDon hd join QuanLyThuTien ql" +
                " on ql.MaHoaDon=hd.MaHoaDon ";
            refeshDataGridView(sql1);
        }
    }
}
