namespace QLDT
{
    partial class FrmHocPhi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbboxChonkhoa = new System.Windows.Forms.ComboBox();
            this.cbboxChonlop = new System.Windows.Forms.ComboBox();
            this.radioButtonHK2 = new System.Windows.Forms.RadioButton();
            this.radioButtonHK1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCaNam = new System.Windows.Forms.RadioButton();
            this.btnLoadDanhSach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChonDuongDan = new System.Windows.Forms.Button();
            this.lblDuongDan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDuongDanFile = new System.Windows.Forms.Label();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.MSV,
            this.Hoten,
            this.Lop,
            this.HocKy,
            this.NAM});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1509, 689);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHOA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "LỚP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(350, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "HỌC KỲ :";
            // 
            // cbboxChonkhoa
            // 
            this.cbboxChonkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxChonkhoa.FormattingEnabled = true;
            this.cbboxChonkhoa.Location = new System.Drawing.Point(91, 40);
            this.cbboxChonkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxChonkhoa.Name = "cbboxChonkhoa";
            this.cbboxChonkhoa.Size = new System.Drawing.Size(247, 28);
            this.cbboxChonkhoa.TabIndex = 5;
            this.cbboxChonkhoa.SelectedValueChanged += new System.EventHandler(this.cbboxChonkhoa_SelectedValueChanged);
            // 
            // cbboxChonlop
            // 
            this.cbboxChonlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxChonlop.FormattingEnabled = true;
            this.cbboxChonlop.Location = new System.Drawing.Point(91, 99);
            this.cbboxChonlop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbboxChonlop.Name = "cbboxChonlop";
            this.cbboxChonlop.Size = new System.Drawing.Size(201, 28);
            this.cbboxChonlop.TabIndex = 6;
            this.cbboxChonlop.SelectedIndexChanged += new System.EventHandler(this.cbboxChonkhoa_SelectedValueChanged);
            // 
            // radioButtonHK2
            // 
            this.radioButtonHK2.AutoSize = true;
            this.radioButtonHK2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonHK2.Location = new System.Drawing.Point(541, 75);
            this.radioButtonHK2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonHK2.Name = "radioButtonHK2";
            this.radioButtonHK2.Size = new System.Drawing.Size(88, 24);
            this.radioButtonHK2.TabIndex = 17;
            this.radioButtonHK2.TabStop = true;
            this.radioButtonHK2.Text = "Học Kỳ II";
            this.radioButtonHK2.UseVisualStyleBackColor = true;
            // 
            // radioButtonHK1
            // 
            this.radioButtonHK1.AutoSize = true;
            this.radioButtonHK1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonHK1.Location = new System.Drawing.Point(424, 75);
            this.radioButtonHK1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonHK1.Name = "radioButtonHK1";
            this.radioButtonHK1.Size = new System.Drawing.Size(84, 24);
            this.radioButtonHK1.TabIndex = 16;
            this.radioButtonHK1.TabStop = true;
            this.radioButtonHK1.Text = "Học Kỳ I";
            this.radioButtonHK1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.radioButtonCaNam);
            this.groupBox1.Controls.Add(this.btnLoadDanhSach);
            this.groupBox1.Controls.Add(this.radioButtonHK2);
            this.groupBox1.Controls.Add(this.radioButtonHK1);
            this.groupBox1.Controls.Add(this.cbboxChonlop);
            this.groupBox1.Controls.Add(this.cbboxChonkhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1001, 160);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonCaNam
            // 
            this.radioButtonCaNam.AutoSize = true;
            this.radioButtonCaNam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonCaNam.Location = new System.Drawing.Point(659, 75);
            this.radioButtonCaNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonCaNam.Name = "radioButtonCaNam";
            this.radioButtonCaNam.Size = new System.Drawing.Size(83, 24);
            this.radioButtonCaNam.TabIndex = 19;
            this.radioButtonCaNam.TabStop = true;
            this.radioButtonCaNam.Text = "Cả Năm";
            this.radioButtonCaNam.UseVisualStyleBackColor = true;
            this.radioButtonCaNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnLoadDanhSach
            // 
            this.btnLoadDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnLoadDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDanhSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadDanhSach.Image = global::QLDT.Properties.Resources.icons8_update_301;
            this.btnLoadDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDanhSach.Location = new System.Drawing.Point(778, 45);
            this.btnLoadDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadDanhSach.Name = "btnLoadDanhSach";
            this.btnLoadDanhSach.Size = new System.Drawing.Size(178, 84);
            this.btnLoadDanhSach.TabIndex = 18;
            this.btnLoadDanhSach.Text = "    CẬP NHẬT";
            this.btnLoadDanhSach.UseVisualStyleBackColor = false;
            this.btnLoadDanhSach.Click += new System.EventHandler(this.btnLoadDanhSach_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(305, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "XUẤT EXCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChonDuongDan
            // 
            this.btnChonDuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.btnChonDuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonDuongDan.Location = new System.Drawing.Point(45, 54);
            this.btnChonDuongDan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChonDuongDan.Name = "btnChonDuongDan";
            this.btnChonDuongDan.Size = new System.Drawing.Size(169, 38);
            this.btnChonDuongDan.TabIndex = 102;
            this.btnChonDuongDan.Text = "Chọn Đường Dẫn";
            this.btnChonDuongDan.UseVisualStyleBackColor = false;
            this.btnChonDuongDan.Click += new System.EventHandler(this.btnChonDuongDan_Click);
            // 
            // lblDuongDan
            // 
            this.lblDuongDan.AutoSize = true;
            this.lblDuongDan.Location = new System.Drawing.Point(15, 108);
            this.lblDuongDan.Name = "lblDuongDan";
            this.lblDuongDan.Size = new System.Drawing.Size(29, 20);
            this.lblDuongDan.TabIndex = 103;
            this.lblDuongDan.Text = "=>";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.lblDuongDanFile);
            this.groupBox2.Controls.Add(this.lblDuongDan);
            this.groupBox2.Controls.Add(this.btnChonDuongDan);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(1057, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(521, 159);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // lblDuongDanFile
            // 
            this.lblDuongDanFile.AutoSize = true;
            this.lblDuongDanFile.Location = new System.Drawing.Point(45, 108);
            this.lblDuongDanFile.Name = "lblDuongDanFile";
            this.lblDuongDanFile.Size = new System.Drawing.Size(0, 20);
            this.lblDuongDanFile.TabIndex = 104;
            // 
            // MSV
            // 
            this.MSV.DataPropertyName = "MSSV";
            this.MSV.HeaderText = "Mã SV";
            this.MSV.MinimumWidth = 6;
            this.MSV.Name = "MSV";
            // 
            // Hoten
            // 
            this.Hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hoten.DataPropertyName = "HOTEN";
            this.Hoten.HeaderText = "Họ Tên";
            this.Hoten.MinimumWidth = 6;
            this.Hoten.Name = "Hoten";
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "MALOP";
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HOCKY";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            // 
            // NAM
            // 
            this.NAM.DataPropertyName = "NAM";
            this.NAM.HeaderText = "NĂM";
            this.NAM.MinimumWidth = 6;
            this.NAM.Name = "NAM";
            // 
            // FrmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1533, 902);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHocPhi";
            this.Text = "Xem Điểm RL";
            this.Load += new System.EventHandler(this.FrmXemDiemRL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbboxChonkhoa;
        private System.Windows.Forms.ComboBox cbboxChonlop;
        private System.Windows.Forms.ComboBox cbboxNamHoc;
        private System.Windows.Forms.RadioButton radioButtonHK2;
        private System.Windows.Forms.RadioButton radioButtonHK1;
        private System.Windows.Forms.Button btnLoadDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonCaNam;
        private System.Windows.Forms.Button btnChonDuongDan;
        private System.Windows.Forms.Label lblDuongDan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDuongDanFile;
        private DataGridViewTextBoxColumn MSV;
        private DataGridViewTextBoxColumn Hoten;
        private DataGridViewTextBoxColumn Lop;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn NAM;
    }
}