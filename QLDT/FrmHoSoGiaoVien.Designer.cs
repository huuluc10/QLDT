namespace QLDT
{
    partial class FrmHoSoGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoSoGiaoVien));
            this.cbboxchonkhoa = new System.Windows.Forms.ComboBox();
            this.cbboxTonGiao = new System.Windows.Forms.ComboBox();
            this.cbboxKhoa = new System.Windows.Forms.ComboBox();
            this.cbboxDanToc1 = new System.Windows.Forms.ComboBox();
            this.Lớp = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMSGV = new System.Windows.Forms.TextBox();
            this.cbboxGioitinh = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTimGV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoaGV = new System.Windows.Forms.Button();
            this.btSuaGV = new System.Windows.Forms.Button();
            this.btThemSV = new System.Windows.Forms.Button();
            this.btLoadGV = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPageMAx = new System.Windows.Forms.Label();
            this.btnfullback = new System.Windows.Forms.Button();
            this.btnfullnext = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbboxchonkhoa
            // 
            this.cbboxchonkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxchonkhoa.FormattingEnabled = true;
            this.cbboxchonkhoa.Location = new System.Drawing.Point(153, 59);
            this.cbboxchonkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxchonkhoa.Name = "cbboxchonkhoa";
            this.cbboxchonkhoa.Size = new System.Drawing.Size(235, 28);
            this.cbboxchonkhoa.TabIndex = 93;
            this.cbboxchonkhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbboxchonkhoa_KeyPress);
            // 
            // cbboxTonGiao
            // 
            this.cbboxTonGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxTonGiao.FormattingEnabled = true;
            this.cbboxTonGiao.Items.AddRange(new object[] {
            "Không",
            "Kitô giáo",
            "Hồi giáo",
            "Ấn Độ giáo",
            "Đạo giáo",
            "Phật giáo"});
            this.cbboxTonGiao.Location = new System.Drawing.Point(133, 174);
            this.cbboxTonGiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxTonGiao.Name = "cbboxTonGiao";
            this.cbboxTonGiao.Size = new System.Drawing.Size(270, 28);
            this.cbboxTonGiao.TabIndex = 56;
            // 
            // cbboxKhoa
            // 
            this.cbboxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxKhoa.FormattingEnabled = true;
            this.cbboxKhoa.Location = new System.Drawing.Point(550, 102);
            this.cbboxKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxKhoa.Name = "cbboxKhoa";
            this.cbboxKhoa.Size = new System.Drawing.Size(270, 28);
            this.cbboxKhoa.TabIndex = 69;
            // 
            // cbboxDanToc1
            // 
            this.cbboxDanToc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxDanToc1.FormattingEnabled = true;
            this.cbboxDanToc1.Items.AddRange(new object[] {
            "Kinh",
            "Tày",
            "Mường",
            "Thái",
            "Khme",
            "Nùng",
            "HMông",
            "Dao",
            "Gia-rai",
            "Ê-đê",
            "Ba-na",
            "Sán Chay",
            "Chăng",
            "Xê-đăng",
            "Sán Rìu",
            "Hrê",
            "Cơ-ho",
            "Ra Glay\t",
            "M\'Nông",
            "Thổ",
            "Xtiêng",
            "Khơ Mú",
            "Bru-Vân Kiều",
            "Giáy",
            "Cơ tu",
            "Gié-Triêng",
            "Ta Ôi",
            "Mạ",
            "Co",
            "Chơ Ro\t",
            "Hà Nhì",
            "Xinh Mun",
            "Chu-ru",
            "Lào",
            "La Chí",
            "Phù Lá",
            "La Hủ\t",
            "Kháng",
            "Lự",
            "Pà Thẻn",
            "Lô Lô",
            "Chứt",
            "Mảng",
            "Cờ lao",
            "Bố Y",
            "La Ha",
            "Cống",
            "Ngái",
            "Si La",
            "Pu Péo",
            "Brâu",
            "Rơ Măm",
            "Ơ Đu"});
            this.cbboxDanToc1.Location = new System.Drawing.Point(133, 217);
            this.cbboxDanToc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxDanToc1.Name = "cbboxDanToc1";
            this.cbboxDanToc1.Size = new System.Drawing.Size(270, 28);
            this.cbboxDanToc1.TabIndex = 54;
            // 
            // Lớp
            // 
            this.Lớp.AutoSize = true;
            this.Lớp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lớp.Location = new System.Drawing.Point(461, 102);
            this.Lớp.Name = "Lớp";
            this.Lớp.Size = new System.Drawing.Size(50, 20);
            this.Lớp.TabIndex = 70;
            this.Lớp.Text = "KHOA";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(550, 148);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(270, 27);
            this.txtCCCD.TabIndex = 58;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCMND1_TextChanged);
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND1_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(550, 191);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 27);
            this.txtEmail.TabIndex = 59;
            // 
            // txtMSGV
            // 
            this.txtMSGV.Location = new System.Drawing.Point(132, 59);
            this.txtMSGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMSGV.Name = "txtMSGV";
            this.txtMSGV.ReadOnly = true;
            this.txtMSGV.Size = new System.Drawing.Size(271, 27);
            this.txtMSGV.TabIndex = 50;
            // 
            // cbboxGioitinh
            // 
            this.cbboxGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxGioitinh.FormattingEnabled = true;
            this.cbboxGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbboxGioitinh.Location = new System.Drawing.Point(322, 132);
            this.cbboxGioitinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxGioitinh.Name = "cbboxGioitinh";
            this.cbboxGioitinh.Size = new System.Drawing.Size(81, 28);
            this.cbboxGioitinh.TabIndex = 53;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(186, 35);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(239, 27);
            this.txtTimKiem.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTimGV);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(37, 395);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(655, 88);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btTimGV
            // 
            this.btTimGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btTimGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTimGV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btTimGV.Image = global::QLDT.Properties.Resources.icons8_search_20;
            this.btTimGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimGV.Location = new System.Drawing.Point(432, 28);
            this.btTimGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTimGV.Name = "btTimGV";
            this.btTimGV.Size = new System.Drawing.Size(181, 42);
            this.btTimGV.TabIndex = 21;
            this.btTimGV.Text = "TÌM KIẾM";
            this.btTimGV.UseVisualStyleBackColor = false;
            this.btTimGV.Click += new System.EventHandler(this.btTimGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MSGV HOẶC HỌ TÊN :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(44, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 86;
            this.label14.Text = "TÔN GIÁO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(44, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 20);
            this.label19.TabIndex = 92;
            this.label19.Text = "MSGV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(237, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "GIỚI TÍNH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(44, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "DÂN TỘC";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(550, 233);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(271, 27);
            this.txtDiaChi.TabIndex = 62;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(133, 297);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(270, 27);
            this.txtSDT.TabIndex = 57;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT1_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(460, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 20);
            this.label18.TabIndex = 91;
            this.label18.Text = "ĐỊA CHỈ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(44, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "HỌ TÊN";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 133);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 27);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.Value = new System.DateTime(2000, 11, 14, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(44, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "NGÀY SINH";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(132, 97);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(271, 27);
            this.txtHoten.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(460, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 85;
            this.label13.Text = "EMAIL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(43, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 82;
            this.label12.Text = "SDT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(461, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "SỐ CCCD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.MSGV,
            this.HOTEN,
            this.NgaySinh,
            this.GioiTinh,
            this.QuocGia,
            this.Dantoc,
            this.TonGiao,
            this.Khoa,
            this.SDT,
            this.Email,
            this.DiaChi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(37, 490);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1608, 588);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // MSGV
            // 
            this.MSGV.DataPropertyName = "MSGV";
            this.MSGV.HeaderText = "MSGV";
            this.MSGV.MinimumWidth = 6;
            this.MSGV.Name = "MSGV";
            this.MSGV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NGAYSINH";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GIOITINH";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // QuocGia
            // 
            this.QuocGia.DataPropertyName = "QUOCGIA";
            this.QuocGia.HeaderText = "Quốc Gia";
            this.QuocGia.MinimumWidth = 6;
            this.QuocGia.Name = "QuocGia";
            this.QuocGia.ReadOnly = true;
            // 
            // Dantoc
            // 
            this.Dantoc.DataPropertyName = "DANTOC";
            this.Dantoc.HeaderText = "Dân Tộc";
            this.Dantoc.MinimumWidth = 6;
            this.Dantoc.Name = "Dantoc";
            this.Dantoc.ReadOnly = true;
            // 
            // TonGiao
            // 
            this.TonGiao.DataPropertyName = "TONGIAO";
            this.TonGiao.HeaderText = "Tôn Giáo";
            this.TonGiao.MinimumWidth = 6;
            this.TonGiao.Name = "TonGiao";
            this.TonGiao.ReadOnly = true;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "TENKHOA";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "DIENTHOAI";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "EMAIL";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DIACHI";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // btXoaGV
            // 
            this.btXoaGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoaGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btXoaGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoaGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaGV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btXoaGV.Image = global::QLDT.Properties.Resources.icons8_delete_bin_30;
            this.btXoaGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaGV.Location = new System.Drawing.Point(847, 259);
            this.btXoaGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoaGV.Name = "btXoaGV";
            this.btXoaGV.Size = new System.Drawing.Size(303, 103);
            this.btXoaGV.TabIndex = 87;
            this.btXoaGV.Text = "XÓA";
            this.btXoaGV.UseVisualStyleBackColor = false;
            this.btXoaGV.Click += new System.EventHandler(this.btXoaSV_Click);
            // 
            // btSuaGV
            // 
            this.btSuaGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSuaGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btSuaGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSuaGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSuaGV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSuaGV.Image = global::QLDT.Properties.Resources.icons8_update_30;
            this.btSuaGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaGV.Location = new System.Drawing.Point(847, 141);
            this.btSuaGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSuaGV.Name = "btSuaGV";
            this.btSuaGV.Size = new System.Drawing.Size(303, 105);
            this.btSuaGV.TabIndex = 84;
            this.btSuaGV.Text = "SỬA";
            this.btSuaGV.UseVisualStyleBackColor = false;
            this.btSuaGV.Click += new System.EventHandler(this.btSuaSV_Click);
            // 
            // btThemSV
            // 
            this.btThemSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btThemSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThemSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThemSV.Image = global::QLDT.Properties.Resources.icons8_add_link_30;
            this.btThemSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemSV.Location = new System.Drawing.Point(847, 24);
            this.btThemSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemSV.Name = "btThemSV";
            this.btThemSV.Size = new System.Drawing.Size(303, 101);
            this.btThemSV.TabIndex = 83;
            this.btThemSV.Text = "THÊM MỚI";
            this.btThemSV.UseVisualStyleBackColor = false;
            this.btThemSV.Click += new System.EventHandler(this.btThemGV_Click);
            // 
            // btLoadGV
            // 
            this.btLoadGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btLoadGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoadGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLoadGV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLoadGV.Image = global::QLDT.Properties.Resources._2346941;
            this.btLoadGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoadGV.Location = new System.Drawing.Point(48, 127);
            this.btLoadGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLoadGV.Name = "btLoadGV";
            this.btLoadGV.Size = new System.Drawing.Size(340, 76);
            this.btLoadGV.TabIndex = 81;
            this.btLoadGV.Text = "CẬP NHẬT";
            this.btLoadGV.UseVisualStyleBackColor = false;
            this.btLoadGV.Click += new System.EventHandler(this.btLoadGV_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(43, 261);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 20);
            this.label20.TabIndex = 96;
            this.label20.Text = "QUỐC GIA";
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Location = new System.Drawing.Point(132, 259);
            this.txtQuocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.ReadOnly = true;
            this.txtQuocGia.Size = new System.Drawing.Size(271, 27);
            this.txtQuocGia.TabIndex = 97;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(45, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 99;
            this.label21.Text = "CHỌN KHOA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::QLDT.Properties.Resources._2346941;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(48, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 76);
            this.button1.TabIndex = 100;
            this.button1.Text = "CẬP NHẬT TOÀN BỘ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.Enabled = false;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Location = new System.Drawing.Point(232, 23);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(158, 52);
            this.btnback.TabIndex = 101;
            this.btnback.Text = "<";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnnext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnext.Enabled = false;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.Location = new System.Drawing.Point(547, 24);
            this.btnnext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(158, 52);
            this.btnnext.TabIndex = 102;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPageNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPageNumber.Location = new System.Drawing.Point(408, 35);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(75, 25);
            this.lblPageNumber.TabIndex = 103;
            this.lblPageNumber.Text = "Trang :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPageMAx);
            this.groupBox2.Controls.Add(this.btnfullback);
            this.groupBox2.Controls.Add(this.btnfullnext);
            this.groupBox2.Controls.Add(this.lblPageNumber);
            this.groupBox2.Controls.Add(this.btnnext);
            this.groupBox2.Controls.Add(this.btnback);
            this.groupBox2.Location = new System.Drawing.Point(672, 395);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(972, 87);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // lblPageMAx
            // 
            this.lblPageMAx.AutoSize = true;
            this.lblPageMAx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPageMAx.Location = new System.Drawing.Point(492, 35);
            this.lblPageMAx.Name = "lblPageMAx";
            this.lblPageMAx.Size = new System.Drawing.Size(0, 25);
            this.lblPageMAx.TabIndex = 106;
            // 
            // btnfullback
            // 
            this.btnfullback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnfullback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfullback.Enabled = false;
            this.btnfullback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfullback.Location = new System.Drawing.Point(68, 24);
            this.btnfullback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfullback.Name = "btnfullback";
            this.btnfullback.Size = new System.Drawing.Size(158, 52);
            this.btnfullback.TabIndex = 105;
            this.btnfullback.Text = "<<";
            this.btnfullback.UseVisualStyleBackColor = false;
            this.btnfullback.Click += new System.EventHandler(this.btnfullback_Click);
            // 
            // btnfullnext
            // 
            this.btnfullnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnfullnext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfullnext.Enabled = false;
            this.btnfullnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfullnext.Location = new System.Drawing.Point(713, 24);
            this.btnfullnext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfullnext.Name = "btnfullnext";
            this.btnfullnext.Size = new System.Drawing.Size(158, 52);
            this.btnfullnext.TabIndex = 104;
            this.btnfullnext.Text = ">>";
            this.btnfullnext.UseVisualStyleBackColor = false;
            this.btnfullnext.Click += new System.EventHandler(this.btnfullnext_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQuocGia);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.btXoaGV);
            this.groupBox3.Controls.Add(this.btSuaGV);
            this.groupBox3.Controls.Add(this.btThemSV);
            this.groupBox3.Controls.Add(this.cbboxTonGiao);
            this.groupBox3.Controls.Add(this.cbboxKhoa);
            this.groupBox3.Controls.Add(this.cbboxDanToc1);
            this.groupBox3.Controls.Add(this.Lớp);
            this.groupBox3.Controls.Add(this.txtCCCD);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtMSGV);
            this.groupBox3.Controls.Add(this.cbboxGioitinh);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtHoten);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(37, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1168, 372);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN GV";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.Location = new System.Drawing.Point(209, 212);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 20);
            this.label23.TabIndex = 140;
            this.label23.Text = "OR";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cbboxchonkhoa);
            this.groupBox4.Controls.Add(this.btLoadGV);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(1211, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(434, 369);
            this.groupBox4.TabIndex = 141;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CẬP NHẬT";
            // 
            // FrmHoSoGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1813, 1101);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoSoGiaoVien";
            this.Text = "Hồ Sơ Sinh Viên";
            this.Load += new System.EventHandler(this.HoSoSinhVien_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTimGV;
        private System.Windows.Forms.ComboBox cbboxchonkhoa;
        private System.Windows.Forms.Button btXoaGV;
        private System.Windows.Forms.Button btSuaGV;
        private System.Windows.Forms.Button btThemSV;
        private System.Windows.Forms.ComboBox cbboxTonGiao;
        private System.Windows.Forms.ComboBox cbboxKhoa;
        private System.Windows.Forms.ComboBox cbboxDanToc1;
        private System.Windows.Forms.Button btLoadGV;
        private System.Windows.Forms.Label Lớp;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMSGV;
        private System.Windows.Forms.ComboBox cbboxGioitinh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnfullback;
        private System.Windows.Forms.Button btnfullnext;
        private System.Windows.Forms.Label lblPageMAx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox4;
        private DataGridViewTextBoxColumn MSGV;
        private DataGridViewTextBoxColumn HOTEN;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn QuocGia;
        private DataGridViewTextBoxColumn Dantoc;
        private DataGridViewTextBoxColumn TonGiao;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
    }
}