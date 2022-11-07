namespace QLDT
{
    partial class FrmLop
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
            this.Khoa = new System.Windows.Forms.Label();
            this.btThemLop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTenlop = new System.Windows.Forms.TextBox();
            this.cbbGVCV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbboxKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.cbboxKhoa1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btXoaLop = new System.Windows.Forms.Button();
            this.btsuaLop = new System.Windows.Forms.Button();
            this.btLoadLop = new System.Windows.Forms.Button();
            this.txtMalop1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbGVCV1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenlop1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Khoa
            // 
            this.Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Khoa.AutoSize = true;
            this.Khoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.Khoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Khoa.Location = new System.Drawing.Point(65, 74);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(69, 20);
            this.Khoa.TabIndex = 6;
            this.Khoa.Text = "TÊN LỚP:";
            // 
            // btThemLop
            // 
            this.btThemLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThemLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThemLop.Image = global::QLDT.Properties.Resources.icons8_add_30;
            this.btThemLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemLop.Location = new System.Drawing.Point(221, 198);
            this.btThemLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemLop.Name = "btThemLop";
            this.btThemLop.Size = new System.Drawing.Size(187, 51);
            this.btThemLop.TabIndex = 5;
            this.btThemLop.Text = "THÊM MỚI";
            this.btThemLop.UseVisualStyleBackColor = false;
            this.btThemLop.Click += new System.EventHandler(this.btThemLop_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(65, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "MÃ LỚP :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImage = global::QLDT.Properties.Resources.bgColor1;
            this.groupBox1.Controls.Add(this.txbTenlop);
            this.groupBox1.Controls.Add(this.cbbGVCV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbboxKhoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Khoa);
            this.groupBox1.Controls.Add(this.btThemLop);
            this.groupBox1.Controls.Add(this.txtMalop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(507, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(491, 269);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÊM MỚI";
            // 
            // txbTenlop
            // 
            this.txbTenlop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTenlop.Location = new System.Drawing.Point(185, 74);
            this.txbTenlop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTenlop.Name = "txbTenlop";
            this.txbTenlop.Size = new System.Drawing.Size(277, 27);
            this.txbTenlop.TabIndex = 16;
            // 
            // cbbGVCV
            // 
            this.cbbGVCV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbGVCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGVCV.FormattingEnabled = true;
            this.cbbGVCV.Location = new System.Drawing.Point(185, 162);
            this.cbbGVCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbGVCV.Name = "cbbGVCV";
            this.cbbGVCV.Size = new System.Drawing.Size(277, 28);
            this.cbbGVCV.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(65, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "GV CỐ VẤN :";
            // 
            // cbboxKhoa
            // 
            this.cbboxKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxKhoa.FormattingEnabled = true;
            this.cbboxKhoa.Location = new System.Drawing.Point(185, 118);
            this.cbboxKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxKhoa.Name = "cbboxKhoa";
            this.cbboxKhoa.Size = new System.Drawing.Size(277, 28);
            this.cbboxKhoa.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(65, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "KHOA :";
            // 
            // txtMalop
            // 
            this.txtMalop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalop.Location = new System.Drawing.Point(185, 32);
            this.txtMalop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(277, 27);
            this.txtMalop.TabIndex = 4;
            // 
            // cbboxKhoa1
            // 
            this.cbboxKhoa1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxKhoa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxKhoa1.FormattingEnabled = true;
            this.cbboxKhoa1.Location = new System.Drawing.Point(165, 115);
            this.cbboxKhoa1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxKhoa1.Name = "cbboxKhoa1";
            this.cbboxKhoa1.Size = new System.Drawing.Size(281, 28);
            this.cbboxKhoa1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(46, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "KHOA :";
            // 
            // btXoaLop
            // 
            this.btXoaLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXoaLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btXoaLop.Image = global::QLDT.Properties.Resources.icons8_delete_bin_30;
            this.btXoaLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaLop.Location = new System.Drawing.Point(320, 198);
            this.btXoaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoaLop.Name = "btXoaLop";
            this.btXoaLop.Size = new System.Drawing.Size(126, 51);
            this.btXoaLop.TabIndex = 9;
            this.btXoaLop.Text = "    XÓA";
            this.btXoaLop.UseVisualStyleBackColor = false;
            this.btXoaLop.Click += new System.EventHandler(this.btXoaLop_Click);
            // 
            // btsuaLop
            // 
            this.btsuaLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsuaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btsuaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsuaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btsuaLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsuaLop.Image = global::QLDT.Properties.Resources.icons8_pencil_drawing_30;
            this.btsuaLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsuaLop.Location = new System.Drawing.Point(165, 198);
            this.btsuaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsuaLop.Name = "btsuaLop";
            this.btsuaLop.Size = new System.Drawing.Size(125, 51);
            this.btsuaLop.TabIndex = 8;
            this.btsuaLop.Text = "    SỬA";
            this.btsuaLop.UseVisualStyleBackColor = false;
            this.btsuaLop.Click += new System.EventHandler(this.btsuaLop_Click);
            // 
            // btLoadLop
            // 
            this.btLoadLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btLoadLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLoadLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLoadLop.Image = global::QLDT.Properties.Resources.icons8_class_40;
            this.btLoadLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoadLop.Location = new System.Drawing.Point(634, 304);
            this.btLoadLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLoadLop.Name = "btLoadLop";
            this.btLoadLop.Size = new System.Drawing.Size(281, 52);
            this.btLoadLop.TabIndex = 16;
            this.btLoadLop.Text = "CẬP NHẬT";
            this.btLoadLop.UseVisualStyleBackColor = false;
            this.btLoadLop.Click += new System.EventHandler(this.btLoadLop_Click);
            // 
            // txtMalop1
            // 
            this.txtMalop1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalop1.Location = new System.Drawing.Point(165, 32);
            this.txtMalop1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMalop1.Name = "txtMalop1";
            this.txtMalop1.ReadOnly = true;
            this.txtMalop1.Size = new System.Drawing.Size(281, 27);
            this.txtMalop1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(46, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "TÊN LỚP :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "MÃ LỚP :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.groupBox2.BackgroundImage = global::QLDT.Properties.Resources.bgColor1;
            this.groupBox2.Controls.Add(this.cbbGVCV1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbboxKhoa1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btXoaLop);
            this.groupBox2.Controls.Add(this.btsuaLop);
            this.groupBox2.Controls.Add(this.txtMalop1);
            this.groupBox2.Controls.Add(this.txtTenlop1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(992, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(474, 269);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SỬA-XÓA";
            // 
            // cbbGVCV1
            // 
            this.cbbGVCV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbGVCV1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGVCV1.FormattingEnabled = true;
            this.cbbGVCV1.Location = new System.Drawing.Point(165, 159);
            this.cbbGVCV1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbGVCV1.Name = "cbbGVCV1";
            this.cbbGVCV1.Size = new System.Drawing.Size(281, 28);
            this.cbbGVCV1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "GV CỐ VẤN :";
            // 
            // txtTenlop1
            // 
            this.txtTenlop1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenlop1.Location = new System.Drawing.Point(165, 74);
            this.txtTenlop1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenlop1.Name = "txtTenlop1";
            this.txtTenlop1.Size = new System.Drawing.Size(281, 27);
            this.txtTenlop1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.MaLop,
            this.TenLop,
            this.dataGridViewTextBoxColumn1,
            this.GVCV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(29, 375);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1438, 462);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Width = 135;
            // 
            // TenLop
            // 
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.MinimumWidth = 6;
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Width = 500;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Khoa";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 500;
            // 
            // GVCV
            // 
            this.GVCV.HeaderText = "GV Cố Vấn";
            this.GVCV.MinimumWidth = 6;
            this.GVCV.Name = "GVCV";
            this.GVCV.ReadOnly = true;
            this.GVCV.Width = 300;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::QLDT.Properties.Resources.bgColor1;
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.btLoadLop);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(59, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1498, 869);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LỚP ";
            // 
            // FrmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BackgroundImage = global::QLDT.Properties.Resources.bgColor1;
            this.ClientSize = new System.Drawing.Size(1658, 1002);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLop";
            this.Text = "Danh Sách Lớp";
            this.Load += new System.EventHandler(this.FrmLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Khoa;
        private System.Windows.Forms.Button btThemLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.ComboBox cbboxKhoa1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btXoaLop;
        private System.Windows.Forms.Button btsuaLop;
        private System.Windows.Forms.Button btLoadLop;
        private System.Windows.Forms.TextBox txtMalop1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenlop1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbGVCV1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private ComboBox cbboxKhoa;
        private Label label6;
        private ComboBox cbbGVCV;
        private Label label7;
        private TextBox txbTenlop;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn GVCV;
    }
}