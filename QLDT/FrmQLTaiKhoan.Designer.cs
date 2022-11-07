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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReMKSV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtMKSV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btThemTKSV = new System.Windows.Forms.Button();
            this.btncapnhattaikhoan = new System.Windows.Forms.Button();
            this.cbboxloaitaikhoan = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemTKQL = new System.Windows.Forms.Button();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radioButtonGV = new System.Windows.Forms.RadioButton();
            this.radioButtonSinhVien = new System.Windows.Forms.RadioButton();
            this.cbboxLocKhoa = new System.Windows.Forms.ComboBox();
            this.cbboxLocLop = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.ID,
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
            this.dataGridView1.Size = new System.Drawing.Size(737, 965);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "Hoten";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            // 
            // QuyenHan
            // 
            this.QuyenHan.DataPropertyName = "QuyenHan";
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
            this.groupBox1.Controls.Add(this.txtReMKSV);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Controls.Add(this.txtMKSV);
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
            // txtReMKSV
            // 
            this.txtReMKSV.Location = new System.Drawing.Point(156, 148);
            this.txtReMKSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReMKSV.Name = "txtReMKSV";
            this.txtReMKSV.Size = new System.Drawing.Size(198, 27);
            this.txtReMKSV.TabIndex = 56;
            this.txtReMKSV.UseSystemPasswordChar = true;
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
            this.txtMSV.ReadOnly = true;
            this.txtMSV.Size = new System.Drawing.Size(198, 27);
            this.txtMSV.TabIndex = 41;
            // 
            // txtMKSV
            // 
            this.txtMKSV.Location = new System.Drawing.Point(156, 91);
            this.txtMKSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMKSV.Name = "txtMKSV";
            this.txtMKSV.Size = new System.Drawing.Size(198, 27);
            this.txtMKSV.TabIndex = 55;
            this.txtMKSV.UseSystemPasswordChar = true;
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
            this.btThemTKSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemTKSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThemTKSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemTKSV.Location = new System.Drawing.Point(114, 207);
            this.btThemTKSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemTKSV.Name = "btThemTKSV";
            this.btThemTKSV.Size = new System.Drawing.Size(193, 47);
            this.btThemTKSV.TabIndex = 5;
            this.btThemTKSV.Text = "THAY ĐỔI";
            this.btThemTKSV.UseVisualStyleBackColor = false;
            this.btThemTKSV.Click += new System.EventHandler(this.btThemTKSV_Click);
            // 
            // btncapnhattaikhoan
            // 
            this.btncapnhattaikhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncapnhattaikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btncapnhattaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhattaikhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncapnhattaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncapnhattaikhoan.Location = new System.Drawing.Point(417, 22);
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
            this.cbboxloaitaikhoan.Items.AddRange(new object[] {
            "Quản Trị Viên",
            "Sinh Viên",
            "Giảng Viên"});
            this.cbboxloaitaikhoan.Location = new System.Drawing.Point(217, 29);
            this.cbboxloaitaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxloaitaikhoan.Name = "cbboxloaitaikhoan";
            this.cbboxloaitaikhoan.Size = new System.Drawing.Size(179, 28);
            this.cbboxloaitaikhoan.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnThemTKQL);
            this.groupBox3.Controls.Add(this.txtNhapLaiMK);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtmatkhau);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txttendangnhap);
            this.groupBox3.Controls.Add(this.txthoten);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(1178, 319);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(380, 319);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÊM TÀI KHOẢN QUẢN LÝ";
            // 
            // btnThemTKQL
            // 
            this.btnThemTKQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemTKQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnThemTKQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTKQL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTKQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTKQL.Location = new System.Drawing.Point(114, 236);
            this.btnThemTKQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemTKQL.Name = "btnThemTKQL";
            this.btnThemTKQL.Size = new System.Drawing.Size(193, 50);
            this.btnThemTKQL.TabIndex = 49;
            this.btnThemTKQL.Text = "THÊM MỚI";
            this.btnThemTKQL.UseVisualStyleBackColor = false;
            this.btnThemTKQL.Click += new System.EventHandler(this.btnThemTKQL_Click);
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(140, 176);
            this.txtNhapLaiMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(210, 27);
            this.txtNhapLaiMK.TabIndex = 16;
            this.txtNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(15, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nhập Lại MK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(15, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Họ Tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(15, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tên Đăng Nhập";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(140, 128);
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
            this.label12.Location = new System.Drawing.Point(15, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mật Khẩu";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(140, 82);
            this.txttendangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(210, 27);
            this.txttendangnhap.TabIndex = 14;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(140, 34);
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
            this.label16.Location = new System.Drawing.Point(107, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "TÀI KHOẢN :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(22, 210);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(357, 798);
            this.dataGridView2.TabIndex = 52;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // radioButtonGV
            // 
            this.radioButtonGV.AutoSize = true;
            this.radioButtonGV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonGV.Location = new System.Drawing.Point(65, 44);
            this.radioButtonGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonGV.Name = "radioButtonGV";
            this.radioButtonGV.Size = new System.Drawing.Size(111, 24);
            this.radioButtonGV.TabIndex = 53;
            this.radioButtonGV.TabStop = true;
            this.radioButtonGV.Text = "GIẢNG VIÊN";
            this.radioButtonGV.UseVisualStyleBackColor = true;
            // 
            // radioButtonSinhVien
            // 
            this.radioButtonSinhVien.AutoSize = true;
            this.radioButtonSinhVien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonSinhVien.Location = new System.Drawing.Point(211, 44);
            this.radioButtonSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSinhVien.Name = "radioButtonSinhVien";
            this.radioButtonSinhVien.Size = new System.Drawing.Size(100, 24);
            this.radioButtonSinhVien.TabIndex = 54;
            this.radioButtonSinhVien.TabStop = true;
            this.radioButtonSinhVien.Text = "SINH VIÊN";
            this.radioButtonSinhVien.UseVisualStyleBackColor = true;
            // 
            // cbboxLocKhoa
            // 
            this.cbboxLocKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxLocKhoa.FormattingEnabled = true;
            this.cbboxLocKhoa.Location = new System.Drawing.Point(77, 90);
            this.cbboxLocKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxLocKhoa.Name = "cbboxLocKhoa";
            this.cbboxLocKhoa.Size = new System.Drawing.Size(301, 28);
            this.cbboxLocKhoa.TabIndex = 55;
            this.cbboxLocKhoa.SelectedIndexChanged += new System.EventHandler(this.cbboxLocKhoa_SelectedIndexChanged);
            // 
            // cbboxLocLop
            // 
            this.cbboxLocLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxLocLop.FormattingEnabled = true;
            this.cbboxLocLop.Location = new System.Drawing.Point(77, 128);
            this.cbboxLocLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxLocLop.Name = "cbboxLocLop";
            this.cbboxLocLop.Size = new System.Drawing.Size(252, 28);
            this.cbboxLocLop.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(18, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 57;
            this.label17.Text = "KHOA :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(18, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 20);
            this.label18.TabIndex = 58;
            this.label18.Text = "LỚP :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cbboxLocLop);
            this.groupBox4.Controls.Add(this.cbboxLocKhoa);
            this.groupBox4.Controls.Add(this.radioButtonSinhVien);
            this.groupBox4.Controls.Add(this.radioButtonGV);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(769, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(403, 1030);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CẤP TÀI KHOẢN";
            // 
            // FrmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1576, 1062);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btncapnhattaikhoan);
            this.Controls.Add(this.cbboxloaitaikhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQLTaiKhoan";
            this.Text = "QL Tài Khoản";
            this.Load += new System.EventHandler(this.FrmQLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtReMKSV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMKSV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xóa;
        private DataGridView dataGridView2;
        private RadioButton radioButtonGV;
        private RadioButton radioButtonSinhVien;
        private ComboBox cbboxLocKhoa;
        private ComboBox cbboxLocLop;
        private Label label17;
        private Label label18;
        private GroupBox groupBox4;
    }
}