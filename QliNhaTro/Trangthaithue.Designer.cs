namespace QliNhaTro
{
    partial class Trangthaithue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDathue = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDsKhach = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtNguoiTD = new System.Windows.Forms.TextBox();
            this.txtNguoiHT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDathue)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsKhach)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.groupBox1.Controls.Add(this.dtgvDathue);
            this.groupBox1.Location = new System.Drawing.Point(237, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // dtgvDathue
            // 
            this.dtgvDathue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDathue.Location = new System.Drawing.Point(17, 21);
            this.dtgvDathue.Name = "dtgvDathue";
            this.dtgvDathue.RowHeadersWidth = 51;
            this.dtgvDathue.RowTemplate.Height = 24;
            this.dtgvDathue.Size = new System.Drawing.Size(625, 197);
            this.dtgvDathue.TabIndex = 0;
            this.dtgvDathue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDathue_CellClick);
            this.dtgvDathue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDathue_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.groupBox4.Controls.Add(this.dtgvDsKhach);
            this.groupBox4.Location = new System.Drawing.Point(237, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 238);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khách đã được thuê";
            // 
            // dtgvDsKhach
            // 
            this.dtgvDsKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsKhach.Location = new System.Drawing.Point(17, 26);
            this.dtgvDsKhach.Name = "dtgvDsKhach";
            this.dtgvDsKhach.RowHeadersWidth = 51;
            this.dtgvDsKhach.RowTemplate.Height = 24;
            this.dtgvDsKhach.Size = new System.Drawing.Size(625, 197);
            this.dtgvDsKhach.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.groupBox5.Controls.Add(this.simpleButton1);
            this.groupBox5.Controls.Add(this.txtMaPT);
            this.groupBox5.Controls.Add(this.txtNguoiTD);
            this.groupBox5.Controls.Add(this.txtNguoiHT);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(947, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 334);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thống kê";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(83, 232);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(160, 56);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Đăng kí";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(135, 48);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(108, 22);
            this.txtMaPT.TabIndex = 8;
            // 
            // txtNguoiTD
            // 
            this.txtNguoiTD.Location = new System.Drawing.Point(161, 161);
            this.txtNguoiTD.Name = "txtNguoiTD";
            this.txtNguoiTD.Size = new System.Drawing.Size(33, 22);
            this.txtNguoiTD.TabIndex = 2;
            // 
            // txtNguoiHT
            // 
            this.txtNguoiHT.Location = new System.Drawing.Point(161, 115);
            this.txtNguoiHT.Name = "txtNguoiHT";
            this.txtNguoiHT.Size = new System.Drawing.Size(33, 22);
            this.txtNguoiHT.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số người tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số người hiện tại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // Trangthaithue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 571);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Trangthaithue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trangthaithue";
            this.Load += new System.EventHandler(this.Trangthaithue_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDathue)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsKhach)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDathue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvDsKhach;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNguoiTD;
        private System.Windows.Forms.TextBox txtNguoiHT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPT;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}