namespace QliNhaTro
{
    partial class ResetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.txtResetPass = new System.Windows.Forms.TextBox();
            this.sbReset = new DevExpress.XtraEditors.SimpleButton();
            this.txtResetPassver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResetPass
            // 
            this.txtResetPass.Location = new System.Drawing.Point(111, 92);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.PasswordChar = '*';
            this.txtResetPass.Size = new System.Drawing.Size(177, 22);
            this.txtResetPass.TabIndex = 0;
            // 
            // sbReset
            // 
            this.sbReset.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbReset.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sbReset.Appearance.Options.UseFont = true;
            this.sbReset.Appearance.Options.UseForeColor = true;
            this.sbReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbReset.ImageOptions.Image")));
            this.sbReset.Location = new System.Drawing.Point(147, 235);
            this.sbReset.Name = "sbReset";
            this.sbReset.Size = new System.Drawing.Size(109, 43);
            this.sbReset.TabIndex = 1;
            this.sbReset.Text = "Reset";
            this.sbReset.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtResetPassver
            // 
            this.txtResetPassver.Location = new System.Drawing.Point(111, 180);
            this.txtResetPassver.Name = "txtResetPassver";
            this.txtResetPassver.PasswordChar = '*';
            this.txtResetPassver.Size = new System.Drawing.Size(177, 22);
            this.txtResetPassver.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập lại mật khẩu mới";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(409, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbReset);
            this.Controls.Add(this.txtResetPassver);
            this.Controls.Add(this.txtResetPass);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResetPass;
        private DevExpress.XtraEditors.SimpleButton sbReset;
        private System.Windows.Forms.TextBox txtResetPassver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}