namespace QLDT
{
    partial class FrmKhoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruongKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThemkhoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTien2 = new System.Windows.Forms.TextBox();
            this.btXoakhoa = new System.Windows.Forms.Button();
            this.btsuakhoa = new System.Windows.Forms.Button();
            this.btLoadkhoa = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbboxKhoa = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTenChuyenNganh = new System.Windows.Forms.TextBox();
            this.txtMaChuyenNganh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbboxChonKhoaCapNhat = new System.Windows.Forms.ComboBox();
            this.btnCapNhatCNTheoKhoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.MaKhoa,
            this.Tenkhoa,
            this.TruongKhoa,
            this.Email,
            this.DiaChi,
            this.DienThoai,
            this.Website});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(29, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 592);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // MaKhoa
            // 
            this.MaKhoa.FillWeight = 49.15783F;
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            // 
            // Tenkhoa
            // 
            this.Tenkhoa.DataPropertyName = "Tenkhoa";
            this.Tenkhoa.FillWeight = 91.56049F;
            this.Tenkhoa.HeaderText = "Tên Khoa";
            this.Tenkhoa.MinimumWidth = 6;
            this.Tenkhoa.Name = "Tenkhoa";
            // 
            // TruongKhoa
            // 
            this.TruongKhoa.FillWeight = 79.2026F;
            this.TruongKhoa.HeaderText = "Trưởng Khoa";
            this.TruongKhoa.MinimumWidth = 6;
            this.TruongKhoa.Name = "TruongKhoa";
            // 
            // Email
            // 
            this.Email.FillWeight = 73.24736F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // DiaChi
            // 
            this.DiaChi.FillWeight = 153.9597F;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.FillWeight = 50.9568F;
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            // 
            // Website
            // 
            this.Website.FillWeight = 114.7494F;
            this.Website.HeaderText = "Website";
            this.Website.MinimumWidth = 6;
            this.Website.Name = "Website";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btThemkhoa);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(930, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(350, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÊM MỚI";
            // 
            // btThemkhoa
            // 
            this.btThemkhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemkhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btThemkhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemkhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThemkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThemkhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThemkhoa.Image = global::QLDT.Properties.Resources.icons8_add_30;
            this.btThemkhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemkhoa.Location = new System.Drawing.Point(15, 24);
            this.btThemkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemkhoa.Name = "btThemkhoa";
            this.btThemkhoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btThemkhoa.Size = new System.Drawing.Size(321, 49);
            this.btThemkhoa.TabIndex = 5;
            this.btThemkhoa.Text = "THÊM MỚI";
            this.btThemkhoa.UseVisualStyleBackColor = false;
            this.btThemkhoa.Click += new System.EventHandler(this.btThemkhoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSoTien2);
            this.groupBox2.Controls.Add(this.btXoakhoa);
            this.groupBox2.Controls.Add(this.btsuakhoa);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(930, 227);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(350, 265);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SỬA-XÓA";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(146, 134);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 27);
            this.textBox4.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(146, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 27);
            this.textBox2.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(15, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "WEBSITE:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "ĐỊA CHỈ :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "TRƯỞNG KHOA :";
            // 
            // txtSoTien2
            // 
            this.txtSoTien2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTien2.Location = new System.Drawing.Point(146, 38);
            this.txtSoTien2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTien2.Name = "txtSoTien2";
            this.txtSoTien2.Size = new System.Drawing.Size(190, 27);
            this.txtSoTien2.TabIndex = 9;
            this.txtSoTien2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien2_KeyPress);
            // 
            // btXoakhoa
            // 
            this.btXoakhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoakhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btXoakhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoakhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoakhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoakhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btXoakhoa.Image = global::QLDT.Properties.Resources.icons8_delete_bin_30;
            this.btXoakhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoakhoa.Location = new System.Drawing.Point(221, 183);
            this.btXoakhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoakhoa.Name = "btXoakhoa";
            this.btXoakhoa.Size = new System.Drawing.Size(115, 49);
            this.btXoakhoa.TabIndex = 9;
            this.btXoakhoa.Text = "XÓA";
            this.btXoakhoa.UseVisualStyleBackColor = false;
            this.btXoakhoa.Click += new System.EventHandler(this.btXoakhoa_Click);
            // 
            // btsuakhoa
            // 
            this.btsuakhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsuakhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btsuakhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsuakhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsuakhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsuakhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsuakhoa.Image = global::QLDT.Properties.Resources.icons8_pencil_drawing_30;
            this.btsuakhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsuakhoa.Location = new System.Drawing.Point(59, 183);
            this.btsuakhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsuakhoa.Name = "btsuakhoa";
            this.btsuakhoa.Size = new System.Drawing.Size(115, 49);
            this.btsuakhoa.TabIndex = 8;
            this.btsuakhoa.Text = "SỬA";
            this.btsuakhoa.UseVisualStyleBackColor = false;
            this.btsuakhoa.Click += new System.EventHandler(this.btsuakhoa_Click);
            // 
            // btLoadkhoa
            // 
            this.btLoadkhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadkhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btLoadkhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoadkhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLoadkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLoadkhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLoadkhoa.Image = global::QLDT.Properties.Resources.icons8_update_301;
            this.btLoadkhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoadkhoa.Location = new System.Drawing.Point(930, 52);
            this.btLoadkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLoadkhoa.Name = "btLoadkhoa";
            this.btLoadkhoa.Size = new System.Drawing.Size(350, 57);
            this.btLoadkhoa.TabIndex = 13;
            this.btLoadkhoa.Text = "CẬP NHẬT";
            this.btLoadkhoa.UseVisualStyleBackColor = false;
            this.btLoadkhoa.Click += new System.EventHandler(this.btLoadkhoa_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Khoas});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(29, 670);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(881, 389);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaChuyenNganh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Chuyên Ngành";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenChuyenNganh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Chuyên Ngành";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Khoas
            // 
            this.Khoas.DataPropertyName = "TenKhoa";
            this.Khoas.HeaderText = "Khoa";
            this.Khoas.MinimumWidth = 6;
            this.Khoas.Name = "Khoas";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::QLDT.Properties.Resources.icons8_update_301;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(930, 576);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "CẬP NHẬT TẤT CẢ CHUYÊN NGÀNH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbboxKhoa);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.txtTenChuyenNganh);
            this.groupBox3.Controls.Add(this.txtMaChuyenNganh);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(930, 707);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(350, 232);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(18, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "KHOA :";
            // 
            // cbboxKhoa
            // 
            this.cbboxKhoa.FormattingEnabled = true;
            this.cbboxKhoa.Location = new System.Drawing.Point(202, 136);
            this.cbboxKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxKhoa.Name = "cbboxKhoa";
            this.cbboxKhoa.Size = new System.Drawing.Size(175, 28);
            this.cbboxKhoa.TabIndex = 13;
            this.cbboxKhoa.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::QLDT.Properties.Resources.icons8_delete_bin_30;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(242, 172);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 47);
            this.button3.TabIndex = 12;
            this.button3.Text = "XÓA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "TÊN CN:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::QLDT.Properties.Resources.icons8_add_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(46, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(104, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "THÊM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::QLDT.Properties.Resources.icons8_pencil_drawing_30;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(149, 172);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 47);
            this.button4.TabIndex = 11;
            this.button4.Text = "SỬA";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTenChuyenNganh
            // 
            this.txtTenChuyenNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenChuyenNganh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChuyenNganh.Location = new System.Drawing.Point(149, 83);
            this.txtTenChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenChuyenNganh.MaxLength = 60;
            this.txtTenChuyenNganh.Name = "txtTenChuyenNganh";
            this.txtTenChuyenNganh.Size = new System.Drawing.Size(175, 27);
            this.txtTenChuyenNganh.TabIndex = 7;
            // 
            // txtMaChuyenNganh
            // 
            this.txtMaChuyenNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaChuyenNganh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChuyenNganh.Location = new System.Drawing.Point(149, 34);
            this.txtMaChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaChuyenNganh.MaxLength = 15;
            this.txtMaChuyenNganh.Name = "txtMaChuyenNganh";
            this.txtMaChuyenNganh.Size = new System.Drawing.Size(175, 27);
            this.txtMaChuyenNganh.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(17, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "MÃ CN :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(930, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "MÃ KHOA :";
            // 
            // cbboxChonKhoaCapNhat
            // 
            this.cbboxChonKhoaCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxChonKhoaCapNhat.FormattingEnabled = true;
            this.cbboxChonKhoaCapNhat.Location = new System.Drawing.Point(1020, 666);
            this.cbboxChonKhoaCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxChonKhoaCapNhat.Name = "cbboxChonKhoaCapNhat";
            this.cbboxChonKhoaCapNhat.Size = new System.Drawing.Size(120, 28);
            this.cbboxChonKhoaCapNhat.TabIndex = 16;
            this.cbboxChonKhoaCapNhat.UseWaitCursor = true;
            // 
            // btnCapNhatCNTheoKhoa
            // 
            this.btnCapNhatCNTheoKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatCNTheoKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnCapNhatCNTheoKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatCNTheoKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatCNTheoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhatCNTheoKhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCapNhatCNTheoKhoa.Image = global::QLDT.Properties.Resources.icons8_update_301;
            this.btnCapNhatCNTheoKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatCNTheoKhoa.Location = new System.Drawing.Point(1146, 661);
            this.btnCapNhatCNTheoKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhatCNTheoKhoa.Name = "btnCapNhatCNTheoKhoa";
            this.btnCapNhatCNTheoKhoa.Size = new System.Drawing.Size(134, 38);
            this.btnCapNhatCNTheoKhoa.TabIndex = 18;
            this.btnCapNhatCNTheoKhoa.Text = "         CẬP NHẬT";
            this.btnCapNhatCNTheoKhoa.UseVisualStyleBackColor = false;
            this.btnCapNhatCNTheoKhoa.Click += new System.EventHandler(this.btnCapNhatCNTheoKhoa_Click);
            // 
            // FrmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1300, 1102);
            this.Controls.Add(this.btnCapNhatCNTheoKhoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbboxChonKhoaCapNhat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btLoadkhoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmKhoa";
            this.Text = "Danh Sách Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThemkhoa;
        private System.Windows.Forms.Button btLoadkhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoakhoa;
        private System.Windows.Forms.Button btsuakhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTien2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenChuyenNganh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMaChuyenNganh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbboxKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbboxChonKhoaCapNhat;
        private System.Windows.Forms.Button btnCapNhatCNTheoKhoa;
        private DataGridViewTextBoxColumn MaKhoa;
        private DataGridViewTextBoxColumn Tenkhoa;
        private DataGridViewTextBoxColumn TruongKhoa;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Website;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label11;
        private Label label2;
    }
}