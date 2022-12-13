namespace QLDT
{
    partial class FrmQLTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtMKMSV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btThemTKSV = new System.Windows.Forms.Button();
            this.btncapnhattaikhoan = new System.Windows.Forms.Button();
            this.cbboxloaitaikhoan = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemTKQL = new System.Windows.Forms.Button();
            this.txtMAQTV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.Username,
            this.Password,
            this.QuyenHan,
            this.Xóa});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(22, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 965);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HOTEN";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "TENDANGNHAP";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "MATKHAU";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            // 
            // QuyenHan
            // 
            this.QuyenHan.DataPropertyName = "TENQUYEN";
            this.QuyenHan.HeaderText = "Quyền Hạn";
            this.QuyenHan.MinimumWidth = 6;
            this.QuyenHan.Name = "QuyenHan";
            // 
            // Xóa
            // 
            this.Xóa.DataPropertyName = "Delete";
            this.Xóa.HeaderText = "Xóa";
            this.Xóa.MinimumWidth = 6;
            this.Xóa.Name = "Xóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbQuyen);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Controls.Add(this.txtMKMSV);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btThemTKSV);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(1178, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(380, 286);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THAY ĐỔI TÀI KHOẢN";
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(156, 148);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(198, 28);
            this.cbbQuyen.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(15, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 57;
            this.label14.Text = "QUYỀN:";
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(156, 38);
            this.txtMSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(198, 27);
            this.txtMSV.TabIndex = 41;
            // 
            // txtMKMSV
            // 
            this.txtMKMSV.Location = new System.Drawing.Point(156, 91);
            this.txtMKMSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMKMSV.Name = "txtMKMSV";
            this.txtMKMSV.Size = new System.Drawing.Size(198, 27);
            this.txtMKMSV.TabIndex = 55;
            this.txtMKMSV.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(15, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = "MẬT KHẨU MỚI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "TÊN ĐĂNG NHẬP";
            // 
            // btThemTKSV
            // 
            this.btThemTKSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemTKSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btThemTKSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemTKSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemTKSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThemTKSV.Image = global::QLDT.Properties.Resources.icons8_pencil_drawing_30;
            this.btThemTKSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemTKSV.Location = new System.Drawing.Point(114, 207);
            this.btThemTKSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemTKSV.Name = "btThemTKSV";
            this.btThemTKSV.Size = new System.Drawing.Size(193, 47);
            this.btThemTKSV.TabIndex = 5;
            this.btThemTKSV.Text = "THAY ĐỔI";
            this.btThemTKSV.UseVisualStyleBackColor = false;
            this.btThemTKSV.Click += new System.EventHandler(this.btThemTKSV_Click_1);
            // 
            // btncapnhattaikhoan
            // 
            this.btncapnhattaikhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncapnhattaikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btncapnhattaikhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncapnhattaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhattaikhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncapnhattaikhoan.Image = global::QLDT.Properties.Resources.icons8_update_30;
            this.btncapnhattaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncapnhattaikhoan.Location = new System.Drawing.Point(617, 13);
            this.btncapnhattaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncapnhattaikhoan.Name = "btncapnhattaikhoan";
            this.btncapnhattaikhoan.Size = new System.Drawing.Size(185, 40);
            this.btncapnhattaikhoan.TabIndex = 30;
            this.btncapnhattaikhoan.Text = "CẬP NHẬT";
            this.btncapnhattaikhoan.UseVisualStyleBackColor = false;
            this.btncapnhattaikhoan.Click += new System.EventHandler(this.btncapnhattaikhoan_Click);
            // 
            // cbboxloaitaikhoan
            // 
            this.cbboxloaitaikhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbboxloaitaikhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxloaitaikhoan.FormattingEnabled = true;
            this.cbboxloaitaikhoan.Location = new System.Drawing.Point(417, 20);
            this.cbboxloaitaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxloaitaikhoan.Name = "cbboxloaitaikhoan";
            this.cbboxloaitaikhoan.Size = new System.Drawing.Size(179, 28);
            this.cbboxloaitaikhoan.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnThemTKQL);
            this.groupBox3.Controls.Add(this.txtMAQTV);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtmatkhau);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txthoten);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(1178, 319);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(380, 301);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÊM TÀI KHOẢN QUẢN LÝ";
            // 
            // btnThemTKQL
            // 
            this.btnThemTKQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemTKQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnThemTKQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTKQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTKQL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTKQL.Image = global::QLDT.Properties.Resources.icons8_add_30;
            this.btnThemTKQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTKQL.Location = new System.Drawing.Point(114, 223);
            this.btnThemTKQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemTKQL.Name = "btnThemTKQL";
            this.btnThemTKQL.Size = new System.Drawing.Size(193, 50);
            this.btnThemTKQL.TabIndex = 49;
            this.btnThemTKQL.Text = "THÊM MỚI";
            this.btnThemTKQL.UseVisualStyleBackColor = false;
            this.btnThemTKQL.Click += new System.EventHandler(this.btnThemTKQL_Click);
            // 
            // txtMAQTV
            // 
            this.txtMAQTV.Location = new System.Drawing.Point(144, 59);
            this.txtMAQTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMAQTV.Name = "txtMAQTV";
            this.txtMAQTV.Size = new System.Drawing.Size(210, 27);
            this.txtMAQTV.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(19, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mã QTV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(19, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "HỌ TÊN";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(144, 152);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(210, 27);
            this.txtmatkhau.TabIndex = 15;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(19, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "MẬT KHẨU";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(144, 106);
            this.txthoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(210, 27);
            this.txthoten.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(307, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "TÀI KHOẢN :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(80, 132);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(162, 29);
            this.simpleButton1.TabIndex = 59;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1576, 1062);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btncapnhattaikhoan);
            this.Controls.Add(this.cbboxloaitaikhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQLTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.FrmQLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThemTKSV;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncapnhattaikhoan;
        private System.Windows.Forms.ComboBox cbboxloaitaikhoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThemTKQL;
        private System.Windows.Forms.TextBox txtMAQTV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMKMSV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn QuyenHan;
        private DataGridViewTextBoxColumn Xóa;
        private ComboBox cbbQuyen;
    }
}