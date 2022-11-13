namespace QLDT
{
    partial class FrmMonHoc
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
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSCHUYENCAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSGIUAKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSCUOIKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLoadMH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMH1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btXoaMH = new System.Windows.Forms.Button();
            this.numericUpDownSoTC1 = new System.Windows.Forms.NumericUpDown();
            this.btsuaMH = new System.Windows.Forms.Button();
            this.txtTenMH1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThemMH = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbboxLoadChuyenNganh = new System.Windows.Forms.ComboBox();
            this.cbboxchonkhoa = new System.Windows.Forms.ComboBox();
            this.radioButtonTheoKhoa = new System.Windows.Forms.RadioButton();
            this.radioButtonTatCa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoTC1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.TenKhoa,
            this.MaMonHoc,
            this.TenMonHoc,
            this.SoTinChi,
            this.ChuyenNganh,
            this.TSCHUYENCAN,
            this.TSGIUAKY,
            this.TSCUOIKY,
            this.DONGIA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(37, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 1118);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TENKHOA";
            this.TenKhoa.HeaderText = "Khoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MAMONHOC";
            this.MaMonHoc.HeaderText = "Mã Môn Học";
            this.MaMonHoc.MinimumWidth = 6;
            this.MaMonHoc.Name = "MaMonHoc";
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TENMONHOC";
            this.TenMonHoc.HeaderText = "Tên Môn Học";
            this.TenMonHoc.MinimumWidth = 6;
            this.TenMonHoc.Name = "TenMonHoc";
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SOTC";
            this.SoTinChi.HeaderText = "Số TC";
            this.SoTinChi.MinimumWidth = 6;
            this.SoTinChi.Name = "SoTinChi";
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.DataPropertyName = "TENCHUYENNGANH";
            this.ChuyenNganh.HeaderText = "Chuyên Ngành";
            this.ChuyenNganh.MinimumWidth = 6;
            this.ChuyenNganh.Name = "ChuyenNganh";
            // 
            // TSCHUYENCAN
            // 
            this.TSCHUYENCAN.DataPropertyName = "TSCHUYENCAN";
            this.TSCHUYENCAN.HeaderText = "Trọng số điểm chuyên cần";
            this.TSCHUYENCAN.MinimumWidth = 6;
            this.TSCHUYENCAN.Name = "TSCHUYENCAN";
            // 
            // TSGIUAKY
            // 
            this.TSGIUAKY.DataPropertyName = "TSGIUAKY";
            this.TSGIUAKY.HeaderText = "Trọng số giữa kỳ";
            this.TSGIUAKY.MinimumWidth = 6;
            this.TSGIUAKY.Name = "TSGIUAKY";
            // 
            // TSCUOIKY
            // 
            this.TSCUOIKY.DataPropertyName = "TSCUOIKY";
            this.TSCUOIKY.HeaderText = "Trọng số cuối kỳ";
            this.TSCUOIKY.MinimumWidth = 6;
            this.TSCUOIKY.Name = "TSCUOIKY";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            // 
            // btLoadMH
            // 
            this.btLoadMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btLoadMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoadMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLoadMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLoadMH.ForeColor = System.Drawing.SystemColors.Control;
            this.btLoadMH.Image = global::QLDT.Properties.Resources.icons8_update_301;
            this.btLoadMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoadMH.Location = new System.Drawing.Point(137, 24);
            this.btLoadMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLoadMH.Name = "btLoadMH";
            this.btLoadMH.Size = new System.Drawing.Size(240, 65);
            this.btLoadMH.TabIndex = 20;
            this.btLoadMH.Text = "CẬP NHẬT";
            this.btLoadMH.UseVisualStyleBackColor = false;
            this.btLoadMH.Click += new System.EventHandler(this.btLoadMH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txbDonGia);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMaMH1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btXoaMH);
            this.groupBox2.Controls.Add(this.numericUpDownSoTC1);
            this.groupBox2.Controls.Add(this.btsuaMH);
            this.groupBox2.Controls.Add(this.txtTenMH1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(757, 334);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(392, 335);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SỬA-XÓA";
            // 
            // txbDonGia
            // 
            this.txbDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDonGia.Enabled = false;
            this.txbDonGia.Location = new System.Drawing.Point(147, 188);
            this.txbDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(138, 27);
            this.txbDonGia.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Đơn giá";
            // 
            // txtMaMH1
            // 
            this.txtMaMH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaMH1.Enabled = false;
            this.txtMaMH1.Location = new System.Drawing.Point(147, 51);
            this.txtMaMH1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaMH1.Name = "txtMaMH1";
            this.txtMaMH1.ReadOnly = true;
            this.txtMaMH1.Size = new System.Drawing.Size(214, 27);
            this.txtMaMH1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(38, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mã Môn Học :";
            // 
            // btXoaMH
            // 
            this.btXoaMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoaMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btXoaMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoaMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoaMH.ForeColor = System.Drawing.SystemColors.Control;
            this.btXoaMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaMH.Location = new System.Drawing.Point(223, 249);
            this.btXoaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoaMH.Name = "btXoaMH";
            this.btXoaMH.Size = new System.Drawing.Size(139, 51);
            this.btXoaMH.TabIndex = 9;
            this.btXoaMH.Text = "    XÓA";
            this.btXoaMH.UseVisualStyleBackColor = false;
            this.btXoaMH.Click += new System.EventHandler(this.btXoaMH_Click);
            // 
            // numericUpDownSoTC1
            // 
            this.numericUpDownSoTC1.Location = new System.Drawing.Point(147, 144);
            this.numericUpDownSoTC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownSoTC1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSoTC1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSoTC1.Name = "numericUpDownSoTC1";
            this.numericUpDownSoTC1.Size = new System.Drawing.Size(89, 27);
            this.numericUpDownSoTC1.TabIndex = 30;
            this.numericUpDownSoTC1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btsuaMH
            // 
            this.btsuaMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsuaMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btsuaMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsuaMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsuaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsuaMH.ForeColor = System.Drawing.SystemColors.Control;
            this.btsuaMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsuaMH.Location = new System.Drawing.Point(64, 249);
            this.btsuaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsuaMH.Name = "btsuaMH";
            this.btsuaMH.Size = new System.Drawing.Size(138, 51);
            this.btsuaMH.TabIndex = 8;
            this.btsuaMH.Text = "    SỬA";
            this.btsuaMH.UseVisualStyleBackColor = false;
            this.btsuaMH.Click += new System.EventHandler(this.btsuaMH_Click);
            // 
            // txtTenMH1
            // 
            this.txtTenMH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMH1.Enabled = false;
            this.txtTenMH1.Location = new System.Drawing.Point(148, 98);
            this.txtTenMH1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenMH1.Name = "txtTenMH1";
            this.txtTenMH1.Size = new System.Drawing.Size(214, 27);
            this.txtTenMH1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(38, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số TC :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(38, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tên Môn Học :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btThemMH);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(757, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(392, 108);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÊM MỚI";
            // 
            // btThemMH
            // 
            this.btThemMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btThemMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThemMH.ForeColor = System.Drawing.SystemColors.Control;
            this.btThemMH.Image = global::QLDT.Properties.Resources.icons8_add_30;
            this.btThemMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMH.Location = new System.Drawing.Point(11, 28);
            this.btThemMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemMH.Name = "btThemMH";
            this.btThemMH.Size = new System.Drawing.Size(366, 55);
            this.btThemMH.TabIndex = 5;
            this.btThemMH.Text = "THÊM MỚI";
            this.btThemMH.UseVisualStyleBackColor = false;
            this.btThemMH.Click += new System.EventHandler(this.btThemMH_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.cbboxLoadChuyenNganh);
            this.groupBox6.Controls.Add(this.cbboxchonkhoa);
            this.groupBox6.Controls.Add(this.radioButtonTheoKhoa);
            this.groupBox6.Controls.Add(this.btLoadMH);
            this.groupBox6.Controls.Add(this.radioButtonTatCa);
            this.groupBox6.Location = new System.Drawing.Point(757, 34);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(392, 176);
            this.groupBox6.TabIndex = 129;
            this.groupBox6.TabStop = false;
            // 
            // cbboxLoadChuyenNganh
            // 
            this.cbboxLoadChuyenNganh.Enabled = false;
            this.cbboxLoadChuyenNganh.FormattingEnabled = true;
            this.cbboxLoadChuyenNganh.Location = new System.Drawing.Point(137, 139);
            this.cbboxLoadChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxLoadChuyenNganh.Name = "cbboxLoadChuyenNganh";
            this.cbboxLoadChuyenNganh.Size = new System.Drawing.Size(240, 28);
            this.cbboxLoadChuyenNganh.TabIndex = 128;
            // 
            // cbboxchonkhoa
            // 
            this.cbboxchonkhoa.FormattingEnabled = true;
            this.cbboxchonkhoa.Location = new System.Drawing.Point(137, 105);
            this.cbboxchonkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxchonkhoa.Name = "cbboxchonkhoa";
            this.cbboxchonkhoa.Size = new System.Drawing.Size(240, 28);
            this.cbboxchonkhoa.TabIndex = 127;
            this.cbboxchonkhoa.SelectedValueChanged += new System.EventHandler(this.cbboxchonkhoa_SelectedValueChanged);
            // 
            // radioButtonTheoKhoa
            // 
            this.radioButtonTheoKhoa.AutoSize = true;
            this.radioButtonTheoKhoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonTheoKhoa.Location = new System.Drawing.Point(11, 105);
            this.radioButtonTheoKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTheoKhoa.Name = "radioButtonTheoKhoa";
            this.radioButtonTheoKhoa.Size = new System.Drawing.Size(133, 24);
            this.radioButtonTheoKhoa.TabIndex = 126;
            this.radioButtonTheoKhoa.TabStop = true;
            this.radioButtonTheoKhoa.Text = "Chuyên Ngành :";
            this.radioButtonTheoKhoa.UseVisualStyleBackColor = true;
            this.radioButtonTheoKhoa.CheckedChanged += new System.EventHandler(this.radioButtonTheoKhoa_CheckedChanged);
            // 
            // radioButtonTatCa
            // 
            this.radioButtonTatCa.AutoSize = true;
            this.radioButtonTatCa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonTatCa.Location = new System.Drawing.Point(12, 44);
            this.radioButtonTatCa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTatCa.Name = "radioButtonTatCa";
            this.radioButtonTatCa.Size = new System.Drawing.Size(72, 24);
            this.radioButtonTatCa.TabIndex = 125;
            this.radioButtonTatCa.TabStop = true;
            this.radioButtonTatCa.Text = "Tất Cả";
            this.radioButtonTatCa.UseVisualStyleBackColor = true;
            this.radioButtonTatCa.CheckedChanged += new System.EventHandler(this.radioButtonTatCa_CheckedChanged);
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1161, 1102);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMonHoc";
            this.Text = "MÔN HỌC";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoTC1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btLoadMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXoaMH;
        private System.Windows.Forms.Button btsuaMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThemMH;
        private System.Windows.Forms.TextBox txtMaMH1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownSoTC1;
        private System.Windows.Forms.TextBox txtTenMH1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbboxchonkhoa;
        private System.Windows.Forms.RadioButton radioButtonTheoKhoa;
        private System.Windows.Forms.RadioButton radioButtonTatCa;
        private System.Windows.Forms.ComboBox cbboxLoadChuyenNganh;
        private TextBox txbDonGia;
        private Label label1;
        private DataGridViewTextBoxColumn TenKhoa;
        private DataGridViewTextBoxColumn MaMonHoc;
        private DataGridViewTextBoxColumn TenMonHoc;
        private DataGridViewTextBoxColumn SoTinChi;
        private DataGridViewTextBoxColumn ChuyenNganh;
        private DataGridViewTextBoxColumn TSCHUYENCAN;
        private DataGridViewTextBoxColumn TSGIUAKY;
        private DataGridViewTextBoxColumn TSCUOIKY;
        private DataGridViewTextBoxColumn DONGIA;
    }
}