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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        myDatabase db = new myDatabase();
        private void sbDangki_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (txtMatkhau.Text != txtNhaplaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(db.con))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Taikhoan " +
                            " values('" + txtMaND.Text + "',N'" + txtTenND.Text + "','" + txtUserName.Text + "','" +
                            txtMatkhau.Text + "')", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Tạo tài khoản thành công!");
                }
            }
            
           

            
        }
    }
}
