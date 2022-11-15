namespace QLDT
{
    partial class FrmNhapDiemRL
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
            this.cbboxChonkhoa = new System.Windows.Forms.ComboBox();
            this.cbboxchonlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongDiemRL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNamHocHienTai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadSV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUYENNGANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbboxChonkhoa
            // 
            this.cbboxChonkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxChonkhoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbboxChonkhoa.FormattingEnabled = true;
            this.cbboxChonkhoa.Location = new System.Drawing.Point(66, 28);
            this.cbboxChonkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxChonkhoa.Name = "cbboxChonkhoa";
            this.cbboxChonkhoa.Size = new System.Drawing.Size(220, 28);
            this.cbboxChonkhoa.TabIndex = 0;
            this.cbboxChonkhoa.SelectedValueChanged += new System.EventHandler(this.cbboxChonkhoa_SelectedValueChanged);
            // 
            // cbboxchonlop
            // 
            this.cbboxchonlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxchonlop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbboxchonlop.FormattingEnabled = true;
            this.cbboxchonlop.Location = new System.Drawing.Point(66, 80);
            this.cbboxchonlop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxchonlop.Name = "cbboxchonlop";
            this.cbboxchonlop.Size = new System.Drawing.Size(220, 28);
            this.cbboxchonlop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHOA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "LỚP :";
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
            this.MSV,
            this.HoTen,
            this.Khoa,
            this.CHUYENNGANH,
            this.Malop});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(530, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 954);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(44, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "MSSV :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(44, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "HỌ TÊN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(44, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "LỚP :";
            // 
            // txtMSV
            // 
            this.txtMSV.BackColor = System.Drawing.Color.LightGray;
            this.txtMSV.Location = new System.Drawing.Point(140, 28);
            this.txtMSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.ReadOnly = true;
            this.txtMSV.Size = new System.Drawing.Size(100, 27);
            this.txtMSV.TabIndex = 9;
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.Color.LightGray;
            this.txtHoten.Location = new System.Drawing.Point(140, 80);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Size = new System.Drawing.Size(265, 27);
            this.txtHoten.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(122, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 70);
            this.button1.TabIndex = 12;
            this.button1.Text = "NHẬP ĐIỂM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLop
            // 
            this.txtLop.BackColor = System.Drawing.Color.LightGray;
            this.txtLop.Location = new System.Drawing.Point(140, 133);
            this.txtLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(100, 27);
            this.txtLop.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(229, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "TỔNG ĐIỂM RL :";
            // 
            // txtTongDiemRL
            // 
            this.txtTongDiemRL.Location = new System.Drawing.Point(358, 235);
            this.txtTongDiemRL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongDiemRL.Name = "txtTongDiemRL";
            this.txtTongDiemRL.Size = new System.Drawing.Size(100, 27);
            this.txtTongDiemRL.TabIndex = 17;
            this.txtTongDiemRL.TextChanged += new System.EventHandler(this.txtTongDiemRL_TextChanged);
            this.txtTongDiemRL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongDiemRL_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(39, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "NĂM HỌC :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNamHocHienTai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTongDiemRL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(37, 467);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(483, 392);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Điểm :";
            // 
            // txtNamHocHienTai
            // 
            this.txtNamHocHienTai.Enabled = false;
            this.txtNamHocHienTai.Location = new System.Drawing.Point(140, 185);
            this.txtNamHocHienTai.Name = "txtNamHocHienTai";
            this.txtNamHocHienTai.Size = new System.Drawing.Size(165, 27);
            this.txtNamHocHienTai.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "HỌC KỲ";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(140, 235);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(77, 27);
            this.txtHocKy.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadSV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbboxchonlop);
            this.groupBox2.Controls.Add(this.cbboxChonkhoa);
            this.groupBox2.Location = new System.Drawing.Point(37, 339);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(483, 120);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc Sinh Viên";
            // 
            // btnLoadSV
            // 
            this.btnLoadSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnLoadSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadSV.Image = global::QLDT.Properties.Resources.icons8_update_301;
            this.btnLoadSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSV.Location = new System.Drawing.Point(302, 40);
            this.btnLoadSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadSV.Name = "btnLoadSV";
            this.btnLoadSV.Size = new System.Drawing.Size(175, 46);
            this.btnLoadSV.TabIndex = 4;
            this.btnLoadSV.Text = "    CẬP NHẬT";
            this.btnLoadSV.UseVisualStyleBackColor = false;
            this.btnLoadSV.Click += new System.EventHandler(this.btnLoadSV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDT.Properties.Resources._202004091154448852_54972fefc1ce01cc5f2e642e616eaa501;
            this.pictureBox1.Location = new System.Drawing.Point(37, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // MSV
            // 
            this.MSV.DataPropertyName = "MSSV";
            this.MSV.HeaderText = "Mã SV";
            this.MSV.MinimumWidth = 6;
            this.MSV.Name = "MSV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "Hoten";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "TENKHOA";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            // 
            // CHUYENNGANH
            // 
            this.CHUYENNGANH.DataPropertyName = "TENCHUYENNGANH";
            this.CHUYENNGANH.HeaderText = "Chuyên Ngành";
            this.CHUYENNGANH.MinimumWidth = 6;
            this.CHUYENNGANH.Name = "CHUYENNGANH";
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "MALOP";
            this.Malop.HeaderText = "Lớp";
            this.Malop.MinimumWidth = 6;
            this.Malop.Name = "Malop";
            // 
            // FrmNhapDiemRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1292, 1006);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNhapDiemRL";
            this.Text = "Nhập Điểm Rèn Luyện";
            this.Load += new System.EventHandler(this.FrmNhapDiemRL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbboxChonkhoa;
        private System.Windows.Forms.ComboBox cbboxchonlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadSV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongDiemRL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label8;
        private TextBox txtHocKy;
        private TextBox txtNamHocHienTai;
        private DataGridViewTextBoxColumn MSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn CHUYENNGANH;
        private DataGridViewTextBoxColumn Malop;
    }
}