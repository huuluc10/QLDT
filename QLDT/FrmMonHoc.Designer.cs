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
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLoadMH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbboxChuyenNganh1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioMonHocTheoKhoa2 = new System.Windows.Forms.RadioButton();
            this.radioMonHocChung2 = new System.Windows.Forms.RadioButton();
            this.txtMaMH1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownHocKyThu1 = new System.Windows.Forms.NumericUpDown();
            this.btXoaMH = new System.Windows.Forms.Button();
            this.numericUpDownSoTC1 = new System.Windows.Forms.NumericUpDown();
            this.btsuaMH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMH1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbboxKhoa1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbboxChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioMonHocTheoKhoa = new System.Windows.Forms.RadioButton();
            this.radioMonHocChung = new System.Windows.Forms.RadioButton();
            this.txtMaMonHocThemMoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownHocKyThu = new System.Windows.Forms.NumericUpDown();
            this.numericUpSoTC = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbboxKhoa = new System.Windows.Forms.ComboBox();
            this.Khoa = new System.Windows.Forms.Label();
            this.btThemMH = new System.Windows.Forms.Button();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbboxLoadChuyenNganh = new System.Windows.Forms.ComboBox();
            this.cbboxchonkhoa = new System.Windows.Forms.ComboBox();
            this.radioButtonTheoKhoa = new System.Windows.Forms.RadioButton();
            this.radioButtonTatCa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHocKyThu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoTC1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHocKyThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSoTC)).BeginInit();
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
            this.MaMonHoc,
            this.TenMonHoc,
            this.SoTinChi,
            this.HocKy,
            this.ChuyenNganh,
            this.TenKhoa});
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
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "Mã Môn Học";
            this.MaMonHoc.MinimumWidth = 6;
            this.MaMonHoc.Name = "MaMonHoc";
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Tên Môn Học";
            this.TenMonHoc.MinimumWidth = 6;
            this.TenMonHoc.Name = "TenMonHoc";
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTC";
            this.SoTinChi.HeaderText = "Số TC";
            this.SoTinChi.MinimumWidth = 6;
            this.SoTinChi.Name = "SoTinChi";
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.DataPropertyName = "TenChuyenNganh";
            this.ChuyenNganh.HeaderText = "Chuyên Ngành";
            this.ChuyenNganh.MinimumWidth = 6;
            this.ChuyenNganh.Name = "ChuyenNganh";
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Khoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            // 
            // btLoadMH
            // 
            this.btLoadMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btLoadMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoadMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLoadMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.groupBox2.Controls.Add(this.cbboxChuyenNganh1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.radioMonHocTheoKhoa2);
            this.groupBox2.Controls.Add(this.radioMonHocChung2);
            this.groupBox2.Controls.Add(this.txtMaMH1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDownHocKyThu1);
            this.groupBox2.Controls.Add(this.btXoaMH);
            this.groupBox2.Controls.Add(this.numericUpDownSoTC1);
            this.groupBox2.Controls.Add(this.btsuaMH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenMH1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbboxKhoa1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(757, 670);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(392, 430);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SỬA-XÓA";
            // 
            // cbboxChuyenNganh1
            // 
            this.cbboxChuyenNganh1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxChuyenNganh1.FormattingEnabled = true;
            this.cbboxChuyenNganh1.Location = new System.Drawing.Point(147, 306);
            this.cbboxChuyenNganh1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxChuyenNganh1.Name = "cbboxChuyenNganh1";
            this.cbboxChuyenNganh1.Size = new System.Drawing.Size(213, 28);
            this.cbboxChuyenNganh1.TabIndex = 39;
            this.cbboxChuyenNganh1.SelectedIndexChanged += new System.EventHandler(this.cbboxChuyenNganh1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(83, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "CN :";
            // 
            // radioMonHocTheoKhoa2
            // 
            this.radioMonHocTheoKhoa2.AutoSize = true;
            this.radioMonHocTheoKhoa2.Location = new System.Drawing.Point(181, 235);
            this.radioMonHocTheoKhoa2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioMonHocTheoKhoa2.Name = "radioMonHocTheoKhoa2";
            this.radioMonHocTheoKhoa2.Size = new System.Drawing.Size(190, 24);
            this.radioMonHocTheoKhoa2.TabIndex = 37;
            this.radioMonHocTheoKhoa2.TabStop = true;
            this.radioMonHocTheoKhoa2.Text = "Môn Học Theo CN Khoa";
            this.radioMonHocTheoKhoa2.UseVisualStyleBackColor = true;
            this.radioMonHocTheoKhoa2.CheckedChanged += new System.EventHandler(this.radioMonHocTheoKhoa2_CheckedChanged);
            // 
            // radioMonHocChung2
            // 
            this.radioMonHocChung2.AutoSize = true;
            this.radioMonHocChung2.Location = new System.Drawing.Point(30, 235);
            this.radioMonHocChung2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioMonHocChung2.Name = "radioMonHocChung2";
            this.radioMonHocChung2.Size = new System.Drawing.Size(137, 24);
            this.radioMonHocChung2.TabIndex = 36;
            this.radioMonHocChung2.TabStop = true;
            this.radioMonHocChung2.Text = "Môn Học Chung";
            this.radioMonHocChung2.UseVisualStyleBackColor = true;
            this.radioMonHocChung2.CheckedChanged += new System.EventHandler(this.radioMonHocChung2_CheckedChanged);
            // 
            // txtMaMH1
            // 
            this.txtMaMH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(48, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mã Môn Học :";
            // 
            // numericUpDownHocKyThu1
            // 
            this.numericUpDownHocKyThu1.Location = new System.Drawing.Point(147, 190);
            this.numericUpDownHocKyThu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownHocKyThu1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownHocKyThu1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHocKyThu1.Name = "numericUpDownHocKyThu1";
            this.numericUpDownHocKyThu1.Size = new System.Drawing.Size(89, 27);
            this.numericUpDownHocKyThu1.TabIndex = 31;
            this.numericUpDownHocKyThu1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btXoaMH
            // 
            this.btXoaMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoaMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btXoaMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoaMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btXoaMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaMH.Location = new System.Drawing.Point(222, 358);
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
            10,
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
            this.btsuaMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsuaMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsuaMH.Location = new System.Drawing.Point(63, 358);
            this.btsuaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsuaMH.Name = "btsuaMH";
            this.btsuaMH.Size = new System.Drawing.Size(138, 51);
            this.btsuaMH.TabIndex = 8;
            this.btsuaMH.Text = "    SỬA";
            this.btsuaMH.UseVisualStyleBackColor = false;
            this.btsuaMH.Click += new System.EventHandler(this.btsuaMH_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(57, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Học Kỳ Thứ :";
            // 
            // txtTenMH1
            // 
            this.txtTenMH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(68, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số TC :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(42, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tên Môn Học :";
            // 
            // cbboxKhoa1
            // 
            this.cbboxKhoa1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxKhoa1.FormattingEnabled = true;
            this.cbboxKhoa1.Location = new System.Drawing.Point(147, 269);
            this.cbboxKhoa1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxKhoa1.Name = "cbboxKhoa1";
            this.cbboxKhoa1.Size = new System.Drawing.Size(213, 28);
            this.cbboxKhoa1.TabIndex = 27;
            this.cbboxKhoa1.SelectedIndexChanged += new System.EventHandler(this.cbboxKhoa1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(83, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Khoa :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbboxChuyenNganh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.radioMonHocTheoKhoa);
            this.groupBox1.Controls.Add(this.radioMonHocChung);
            this.groupBox1.Controls.Add(this.txtMaMonHocThemMoi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDownHocKyThu);
            this.groupBox1.Controls.Add(this.numericUpSoTC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbboxKhoa);
            this.groupBox1.Controls.Add(this.Khoa);
            this.groupBox1.Controls.Add(this.btThemMH);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(757, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(392, 445);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÊM MỚI";
            // 
            // cbboxChuyenNganh
            // 
            this.cbboxChuyenNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxChuyenNganh.FormattingEnabled = true;
            this.cbboxChuyenNganh.Location = new System.Drawing.Point(164, 294);
            this.cbboxChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxChuyenNganh.Name = "cbboxChuyenNganh";
            this.cbboxChuyenNganh.Size = new System.Drawing.Size(213, 28);
            this.cbboxChuyenNganh.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(100, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "CN :";
            // 
            // radioMonHocTheoKhoa
            // 
            this.radioMonHocTheoKhoa.AutoSize = true;
            this.radioMonHocTheoKhoa.Location = new System.Drawing.Point(185, 222);
            this.radioMonHocTheoKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioMonHocTheoKhoa.Name = "radioMonHocTheoKhoa";
            this.radioMonHocTheoKhoa.Size = new System.Drawing.Size(190, 24);
            this.radioMonHocTheoKhoa.TabIndex = 35;
            this.radioMonHocTheoKhoa.TabStop = true;
            this.radioMonHocTheoKhoa.Text = "Môn Học Theo CN Khoa";
            this.radioMonHocTheoKhoa.UseVisualStyleBackColor = true;
            this.radioMonHocTheoKhoa.CheckedChanged += new System.EventHandler(this.radioMonHocTheoKhoa_CheckedChanged);
            // 
            // radioMonHocChung
            // 
            this.radioMonHocChung.AutoSize = true;
            this.radioMonHocChung.Location = new System.Drawing.Point(34, 222);
            this.radioMonHocChung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioMonHocChung.Name = "radioMonHocChung";
            this.radioMonHocChung.Size = new System.Drawing.Size(137, 24);
            this.radioMonHocChung.TabIndex = 34;
            this.radioMonHocChung.TabStop = true;
            this.radioMonHocChung.Text = "Môn Học Chung";
            this.radioMonHocChung.UseVisualStyleBackColor = true;
            this.radioMonHocChung.CheckedChanged += new System.EventHandler(this.radioMonHocChung_CheckedChanged);
            // 
            // txtMaMonHocThemMoi
            // 
            this.txtMaMonHocThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaMonHocThemMoi.Location = new System.Drawing.Point(167, 38);
            this.txtMaMonHocThemMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaMonHocThemMoi.Name = "txtMaMonHocThemMoi";
            this.txtMaMonHocThemMoi.Size = new System.Drawing.Size(214, 27);
            this.txtMaMonHocThemMoi.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(68, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Mã Môn Học :";
            // 
            // numericUpDownHocKyThu
            // 
            this.numericUpDownHocKyThu.Location = new System.Drawing.Point(168, 176);
            this.numericUpDownHocKyThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownHocKyThu.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownHocKyThu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHocKyThu.Name = "numericUpDownHocKyThu";
            this.numericUpDownHocKyThu.Size = new System.Drawing.Size(89, 27);
            this.numericUpDownHocKyThu.TabIndex = 23;
            this.numericUpDownHocKyThu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpSoTC
            // 
            this.numericUpSoTC.Location = new System.Drawing.Point(168, 130);
            this.numericUpSoTC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpSoTC.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpSoTC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpSoTC.Name = "numericUpSoTC";
            this.numericUpSoTC.Size = new System.Drawing.Size(89, 27);
            this.numericUpSoTC.TabIndex = 22;
            this.numericUpSoTC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(68, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Học Kỳ Thứ :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(79, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số TC :";
            // 
            // cbboxKhoa
            // 
            this.cbboxKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxKhoa.FormattingEnabled = true;
            this.cbboxKhoa.Location = new System.Drawing.Point(164, 256);
            this.cbboxKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxKhoa.Name = "cbboxKhoa";
            this.cbboxKhoa.Size = new System.Drawing.Size(213, 28);
            this.cbboxKhoa.TabIndex = 7;
            this.cbboxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbboxKhoa_SelectedIndexChanged);
            // 
            // Khoa
            // 
            this.Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Khoa.AutoSize = true;
            this.Khoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Khoa.Location = new System.Drawing.Point(99, 260);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(50, 20);
            this.Khoa.TabIndex = 6;
            this.Khoa.Text = "Khoa :";
            // 
            // btThemMH
            // 
            this.btThemMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btThemMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThemMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThemMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMH.Location = new System.Drawing.Point(117, 348);
            this.btThemMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemMH.Name = "btThemMH";
            this.btThemMH.Size = new System.Drawing.Size(193, 55);
            this.btThemMH.TabIndex = 5;
            this.btThemMH.Text = "THÊM MỚI";
            this.btThemMH.UseVisualStyleBackColor = false;
            this.btThemMH.Click += new System.EventHandler(this.btThemMH_Click);
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMH.Location = new System.Drawing.Point(168, 84);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(214, 27);
            this.txtTenMH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(62, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Môn Học :";
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
            this.cbboxchonkhoa.SelectedIndexChanged += new System.EventHandler(this.cbboxchonkhoa_SelectedIndexChanged);
            // 
            // radioButtonTheoKhoa
            // 
            this.radioButtonTheoKhoa.AutoSize = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHocKyThu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoTC1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHocKyThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSoTC)).EndInit();
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
        private System.Windows.Forms.ComboBox cbboxKhoa;
        private System.Windows.Forms.Label Khoa;
        private System.Windows.Forms.Button btThemMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpSoTC;
        private System.Windows.Forms.NumericUpDown numericUpDownHocKyThu;
        private System.Windows.Forms.TextBox txtMaMH1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownHocKyThu1;
        private System.Windows.Forms.NumericUpDown numericUpDownSoTC1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMH1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbboxKhoa1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaMonHocThemMoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbboxchonkhoa;
        private System.Windows.Forms.RadioButton radioButtonTheoKhoa;
        private System.Windows.Forms.RadioButton radioButtonTatCa;
        private System.Windows.Forms.RadioButton radioMonHocTheoKhoa;
        private System.Windows.Forms.RadioButton radioMonHocChung;
        private System.Windows.Forms.RadioButton radioMonHocTheoKhoa2;
        private System.Windows.Forms.RadioButton radioMonHocChung2;
        private System.Windows.Forms.ComboBox cbboxChuyenNganh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbboxChuyenNganh1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbboxLoadChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
    }
}