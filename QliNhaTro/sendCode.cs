using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace QliNhaTro
{
    public partial class sendCode : Form
    {
        string randomCode;
        public static string to;
        public sendCode()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string from, pass, MessageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage mailMessage = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "cutoi123abc@gmail.com";
            pass = "phuong0910";
            MessageBody = "your reset code is  :" + randomCode;
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = MessageBody;
            mailMessage.Subject = "Mật khẩu đặt lại :";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(mailMessage);
                MessageBox.Show("Mã xác minh đã được gửi đến email của bạn!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerCode.Text).ToString())
            {
                to = txtEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai mã xác minh!");
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "abc@gmail.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "abc@gmail.com";
                txtEmail.ForeColor = Color.Black;
            }
        }


    }
}
