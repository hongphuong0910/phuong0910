using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QliNhaTro
{
    public partial class ResetPassword : Form
    {
        string username = sendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassver.Text)
            {
                myDatabase db = new myDatabase();
                SqlConnection connection = new SqlConnection(db.con);
                SqlCommand cmd = new SqlCommand("update taikhoan set password ='" + txtResetPassver.Text
                    + "'where username ='" + username + "'", connection);
                txtResetPass.Focus();
                txtResetPassver.Clear();
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Đặt mật khẩu thành công!");
                this.Close();
                Login m = new Login();
                m.Show();
                
            }
            else
            {
                MessageBox.Show("the new password do not match so enter same password");
            }

        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
