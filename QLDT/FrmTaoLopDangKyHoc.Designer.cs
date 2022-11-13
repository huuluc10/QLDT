namespace QLDT
{
    partial class FrmTaoLopDangKyHoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoadTheoKhoa = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbboxLoadKhoa = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLopHP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbboxKhoa = new System.Windows.Forms.ComboBox();
            this.cbboxMonHoc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbboxGiangVien = new System.Windows.Forms.ComboBox();
            this.txtNamHocHienTai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHOAHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMONHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(31, 440);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1291, 504);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(383, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(624, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "DANH SÁCH CÁC LỚP ĐANG MỞ CHO SINH VIÊN ĐĂNG KÝ ";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(86, 215);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(249, 56);
            this.btnLoad.TabIndex = 62;
            this.btnLoad.Text = "CẬP NHẬT ALL";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLoadTheoKhoa
            // 
            this.btnLoadTheoKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnLoadTheoKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTheoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadTheoKhoa.Location = new System.Drawing.Point(86, 115);
            this.btnLoadTheoKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadTheoKhoa.Name = "btnLoadTheoKhoa";
            this.btnLoadTheoKhoa.Size = new System.Drawing.Size(249, 56);
            this.btnLoadTheoKhoa.TabIndex = 63;
            this.btnLoadTheoKhoa.Text = "CẬP NHẬT";
            this.btnLoadTheoKhoa.UseVisualStyleBackColor = false;
            this.btnLoadTheoKhoa.Click += new System.EventHandler(this.btnLoadTheoKhoa_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(192, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 64;
            this.label12.Text = "OR";
            // 
            // cbboxLoadKhoa
            // 
            this.cbboxLoadKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxLoadKhoa.FormattingEnabled = true;
            this.cbboxLoadKhoa.Location = new System.Drawing.Point(86, 62);
            this.cbboxLoadKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxLoadKhoa.Name = "cbboxLoadKhoa";
            this.cbboxLoadKhoa.Size = new System.Drawing.Size(263, 28);
            this.cbboxLoadKhoa.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(26, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 64;
            this.label13.Text = "KHOA :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.cbboxLoadKhoa);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnLoadTheoKhoa);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Location = new System.Drawing.Point(31, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(397, 319);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÃ LỚP HP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(460, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "MÔN HỌC :";
            // 
            // txtMaLopHP
            // 
            this.txtMaLopHP.Location = new System.Drawing.Point(151, 145);
            this.txtMaLopHP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLopHP.Name = "txtMaLopHP";
            this.txtMaLopHP.Size = new System.Drawing.Size(263, 27);
            this.txtMaLopHP.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(64, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "KHOA :";
            // 
            // cbboxKhoa
            // 
            this.cbboxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxKhoa.FormattingEnabled = true;
            this.cbboxKhoa.Location = new System.Drawing.Point(151, 45);
            this.cbboxKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxKhoa.Name = "cbboxKhoa";
            this.cbboxKhoa.Size = new System.Drawing.Size(263, 28);
            this.cbboxKhoa.TabIndex = 10;
            this.cbboxKhoa.SelectedValueChanged += new System.EventHandler(this.cbboxKhoa_SelectedValueChanged);
            // 
            // cbboxMonHoc
            // 
            this.cbboxMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxMonHoc.FormattingEnabled = true;
            this.cbboxMonHoc.Location = new System.Drawing.Point(565, 40);
            this.cbboxMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxMonHoc.Name = "cbboxMonHoc";
            this.cbboxMonHoc.Size = new System.Drawing.Size(263, 28);
            this.cbboxMonHoc.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(64, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(781, 59);
            this.button1.TabIndex = 57;
            this.button1.Text = "TẠO LỚP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(46, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "GIẢNG VIÊN :";
            // 
            // cbboxGiangVien
            // 
            this.cbboxGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxGiangVien.FormattingEnabled = true;
            this.cbboxGiangVien.Location = new System.Drawing.Point(151, 94);
            this.cbboxGiangVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxGiangVien.Name = "cbboxGiangVien";
            this.cbboxGiangVien.Size = new System.Drawing.Size(263, 28);
            this.cbboxGiangVien.TabIndex = 63;
            // 
            // txtNamHocHienTai
            // 
            this.txtNamHocHienTai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNamHocHienTai.Enabled = false;
            this.txtNamHocHienTai.Location = new System.Drawing.Point(565, 94);
            this.txtNamHocHienTai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamHocHienTai.Name = "txtNamHocHienTai";
            this.txtNamHocHienTai.Size = new System.Drawing.Size(141, 27);
            this.txtNamHocHienTai.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(460, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 114;
            this.label3.Text = "NĂM HỌC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(460, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "HỌC KỲ";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHocKy.BackColor = System.Drawing.SystemColors.Window;
            this.txtHocKy.Enabled = false;
            this.txtHocKy.Location = new System.Drawing.Point(565, 142);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(76, 27);
            this.txtHocKy.TabIndex = 116;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNamHocHienTai);
            this.groupBox1.Controls.Add(this.cbboxGiangVien);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbboxMonHoc);
            this.groupBox1.Controls.Add(this.cbboxKhoa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaLopHP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(434, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(888, 320);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TẠO LỚP";
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaLop.DataPropertyName = "MAKHOAHOC";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 125;
            // 
            // MonHoc
            // 
            this.MonHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MonHoc.DataPropertyName = "TenMonHoc";
            this.MonHoc.HeaderText = "Môn Học";
            this.MonHoc.MinimumWidth = 6;
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Width = 125;
            // 
            // GiangVien
            // 
            this.GiangVien.DataPropertyName = "HOTEN";
            this.GiangVien.HeaderText = "Giảng Viên";
            this.GiangVien.MinimumWidth = 6;
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.Width = 203;
            // 
            // MAKHOAHOC
            // 
            this.MAKHOAHOC.DataPropertyName = "MAKHOAHOC";
            this.MAKHOAHOC.HeaderText = "MAKHOAHOC";
            this.MAKHOAHOC.MinimumWidth = 6;
            this.MAKHOAHOC.Name = "MAKHOAHOC";
            this.MAKHOAHOC.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "GVGD";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 125;
            // 
            // TENMONHOC
            // 
            this.TENMONHOC.DataPropertyName = "TENMONHOC";
            this.TENMONHOC.HeaderText = "TENMONHOC";
            this.TENMONHOC.MinimumWidth = 6;
            this.TENMONHOC.Name = "TENMONHOC";
            this.TENMONHOC.Width = 125;
            // 
            // FrmTaoLopDangKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1349, 982);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTaoLopDangKyHoc";
            this.Text = "TẠO LỚP";
            this.Load += new System.EventHandler(this.FrmTaoLopDangKyHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLoadTheoKhoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbboxLoadKhoa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private Label label1;
        private Label label4;
        private TextBox txtMaLopHP;
        private Label label7;
        private ComboBox cbboxKhoa;
        private ComboBox cbboxMonHoc;
        private Button button1;
        private Label label11;
        private ComboBox cbboxGiangVien;
        private TextBox txtNamHocHienTai;
        private Label label3;
        private Label label5;
        private TextBox txtHocKy;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn MonHoc;
        private DataGridViewTextBoxColumn GiangVien;
        private DataGridViewTextBoxColumn MAKHOAHOC;
        private DataGridViewTextBoxColumn HOTEN;
        private DataGridViewTextBoxColumn TENMONHOC;
    }
}