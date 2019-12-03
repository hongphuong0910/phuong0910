using QliNhaTro.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QliNhaTro
{
    public partial class Login : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Login()
        {
            InitializeComponent();
            Init_Data();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Cleans Ocean";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            myDatabase db = new myDatabase();
            SqlConnection con = new SqlConnection(db.con);
            String sql = "select * from taikhoan where username = '" + txtUsers.Text + "'and password ='" + txtPass.Text + "'";
            con.Open();
            Save_Data();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read()== true)
            {
                this.Hide();
                Form1 m = new Form1();
                m.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
                txtPass.Text = "";
                txtUsers.Text = "";
                txtUsers.Focus();
            }

            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?","Thoát",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

       

        private void Init_Data()
        {
            if(Properties.Settings.Default.username != string.Empty)
            {
                if (Properties.Settings.Default.Remember == "yes")
                {
                    txtUsers.Text = Properties.Settings.Default.username;
                    txtPass.Text = Properties.Settings.Default.password;
                    checkRem.Checked = true;
                }
                else
                {
                    txtUsers.Text = Properties.Settings.Default.username;
                }
            }
        }

        private void Save_Data()
        {
            if (checkRem.Checked)
            {
                Properties.Settings.Default.username = txtUsers.Text;
                Properties.Settings.Default.password = txtPass.Text;
                Properties.Settings.Default.Remember = "yes";
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.username = txtUsers.Text;
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Remember = "no";
                Properties.Settings.Default.Save();
            }
        }

        private void forgotPass_Click(object sender, EventArgs e)
        {
            sendCode sc = new sendCode();
            this.Hide();
            sc.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            this.Hide();
            su.Show();
        }
    }
}
