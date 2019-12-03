namespace QliNhaTro.Views
{
    partial class PhongTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongTro));
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSNTD = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtSNHT = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Songuoitoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Songuoihientai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(307, 173);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(303, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phòng";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(675, 108);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(132, 22);
            this.txtGiaPhong.TabIndex = 2;
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.TenPhong,
            this.TrangThai,
            this.Songuoitoida,
            this.Songuoihientai,
            this.Giaphong});
            this.dataGridViewPhong.Location = new System.Drawing.Point(334, 303);
            this.dataGridViewPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 51;
            this.dataGridViewPhong.Size = new System.Drawing.Size(803, 239);
            this.dataGridViewPhong.TabIndex = 3;
            this.dataGridViewPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_cellclick);
            this.dataGridViewPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhong_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(303, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(587, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(875, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Người Tối Đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label5.Location = new System.Drawing.Point(875, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số Người Hiện Tại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label6.Location = new System.Drawing.Point(587, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giá Phòng";
            // 
            // txtSNTD
            // 
            this.txtSNTD.Location = new System.Drawing.Point(1019, 98);
            this.txtSNTD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSNTD.Name = "txtSNTD";
            this.txtSNTD.Size = new System.Drawing.Size(132, 22);
            this.txtSNTD.TabIndex = 2;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(675, 33);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(132, 22);
            this.txtTrangThai.TabIndex = 2;
            // 
            // txtSNHT
            // 
            this.txtSNHT.Location = new System.Drawing.Point(1019, 39);
            this.txtSNHT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSNHT.Name = "txtSNHT";
            this.txtSNHT.Size = new System.Drawing.Size(132, 22);
            this.txtSNHT.TabIndex = 2;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(399, 104);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(132, 22);
            this.txtTenPhong.TabIndex = 2;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(399, 33);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(132, 22);
            this.txtMaPhong.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(493, 173);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 44);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(675, 173);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 44);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(862, 173);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 44);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(493, 254);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(132, 22);
            this.txtSeach.TabIndex = 2;
            this.txtSeach.TextChanged += new System.EventHandler(this.txtSeach_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label7.Location = new System.Drawing.Point(318, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tìm Kiếm Theo Mã Phòng";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(1042, 173);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 44);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // MaPT
            // 
            this.MaPT.DataPropertyName = "MaPT";
            this.MaPT.HeaderText = "Mã phòng trọ";
            this.MaPT.MinimumWidth = 6;
            this.MaPT.Name = "MaPT";
            this.MaPT.Width = 125;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // Songuoitoida
            // 
            this.Songuoitoida.DataPropertyName = "Songuoitoida";
            this.Songuoitoida.HeaderText = "Số người tối đa";
            this.Songuoitoida.MinimumWidth = 6;
            this.Songuoitoida.Name = "Songuoitoida";
            this.Songuoitoida.Width = 125;
            // 
            // Songuoihientai
            // 
            this.Songuoihientai.DataPropertyName = "Songuoihientai";
            this.Songuoihientai.HeaderText = "Số người hiện tại";
            this.Songuoihientai.MinimumWidth = 6;
            this.Songuoihientai.Name = "Songuoihientai";
            this.Songuoihientai.Width = 125;
            // 
            // Giaphong
            // 
            this.Giaphong.DataPropertyName = "Giaphong";
            this.Giaphong.HeaderText = "Giá phòng";
            this.Giaphong.MinimumWidth = 6;
            this.Giaphong.Name = "Giaphong";
            this.Giaphong.Width = 125;
            // 
            // PhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 602);
            this.Controls.Add(this.dataGridViewPhong);
            this.Controls.Add(this.txtSNHT);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.txtSNTD);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhongTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhongTro";
            this.Load += new System.EventHandler(this.PhongTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSNTD;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtSNHT;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songuoitoida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songuoihientai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaphong;
    }
}