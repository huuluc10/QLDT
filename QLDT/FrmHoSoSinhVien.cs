using GLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLDT
{
    public partial class FrmHoSoSinhVien : Form
    {
        #region KHAI BÁO BIẾN
        static String imgLoc = string.Empty;
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        static int start;
        int page;
        static String trangthai = string.Empty;
        static String TimKiem = string.Empty;
        static String Quyen = string.Empty;
        static String username = string.Empty;
        private bool DoiTTSV;
        #endregion

        public FrmHoSoSinhVien(String quyenhan, String user, bool DoiTTSV)
        {
            InitializeComponent();
            start = 0;
            page = 1;
            Quyen = quyenhan;
            username = user;
            this.DoiTTSV = DoiTTSV;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public Boolean click = false;

        private void btThemSV_Click(object sender, EventArgs e)
        {
            FrmThemGV frm = new FrmThemGV();
            frm.ShowDialog();
        }

        private void HoSoSinhVien_Load_1(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            getData2(DataCollection);
            
            txtTimKiem.AutoCompleteCustomSource = DataCollection;
            con.Open();
            
            string queryKhoa = "SELECT DISTINCT TENKHOA FROM KHOA ORDER BY TENKHOA";
            SqlCommand cmd = new SqlCommand(queryKhoa, con);
            using (SqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string khoa = saReader.GetString(0);
                    cbboxKhoa.Items.Add(khoa);
                    cbboxchonkhoa.Items.Add(khoa);
                }
            }
            
            string queryLop = String.Format("SELECT DISTINCT MALOP FROM LOPQUANLY ORDER BY MALOP");
            cmd = new SqlCommand(queryLop, con);
            using (SqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string lop = saReader.GetString(0);
                    cbboxLop.Items.Add(lop);
                    cbboxchonlop.Items.Add(lop);
                }
            }

            string queryCN = String.Format("SELECT DISTINCT TENCHUYENNGANH FROM CHUYENNGANH\r\nORDER BY TENCHUYENNGANH");
            cmd = new SqlCommand(queryCN, con);
            using (SqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string chuyenNganh = saReader.GetString(0);
                    cbboxCN.Items.Add(chuyenNganh);
                }
            }

            con.Close();
            
            if (Quyen != "1" )
            {
                var r = new Database().Select(String.Format("SELECTSV '" + username + "'"));
                if (DoiTTSV == false)
                {
                    btSuaSV.Visible = false;
                    txtMSSV.ReadOnly = true;
                    txtHoten.ReadOnly = true;
                    txtCCCD.ReadOnly = true;
                    dateTimePicker1.Enabled = false;
                    cbboxGioitinh.Enabled = false;
                    cbboxDanToc1.Enabled = false;
                    txtEmail.ReadOnly = true;
                    txtSDT.ReadOnly = true;
                    cbboxKhoa.Enabled = false;
                    cbboxLop.Enabled = false;
                    txtQuocGia.ReadOnly = true;
                    cbboxTonGiao.Enabled = false;
                    cbboxCN.Enabled = false;
                    txtDiaChi.ReadOnly = true;
                }
                else
                {
                    btSuaSV.Visible = true;
                    txtMSSV.ReadOnly = false;
                    txtHoten.ReadOnly = false;
                    txtCCCD.ReadOnly = false;
                    dateTimePicker1.Enabled = false;
                    cbboxGioitinh.Enabled = false;
                    cbboxDanToc1.Enabled = false;
                    txtEmail.ReadOnly = false;
                    txtSDT.ReadOnly = false;
                    cbboxKhoa.Enabled = false;
                    cbboxLop.Enabled = false;
                    txtQuocGia.ReadOnly = false;
                    cbboxTonGiao.Enabled = false;
                    cbboxCN.Enabled = false;
                    txtDiaChi.ReadOnly = false;
                }
                try
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                    groupBox4.Visible = false;
                    dataGridView1.Visible = false;
                    groupBox3.Dock = DockStyle.Fill;

                    // get the results of each column
                    if (r["ANH"].ToString() != "")
                    {
                        byte[] img = (byte[])(r["ANH"]);
                        if (img == null)
                            picstudent.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            picstudent.Image = Image.FromStream(ms);
                        }
                    }
                    txtMSSV.Text = r["MSSV"].ToString();
                    txtHoten.Text = (string)r["HOTEN"];
                    dateTimePicker1.Text = r["NGAYSINH"].ToString();
                    cbboxGioitinh.SelectedItem = (string)r["GIOITINH"];
                    cbboxDanToc1.SelectedItem = (string)r["DANTOC"];
                    txtSDT.Text = (string)r["DIENTHOAI"];
                    txtCCCD.Text = (string)r["SOCCCD"];
                    txtEmail.Text = (string)r["EMAIL"];
                    cbboxKhoa.SelectedItem = (string)r["TENKHOA"];
                    cbboxLop.SelectedItem = (string)r["MALOP"];
                    txtQuocGia.Text = (string)r["QUOCGIA"];
                    cbboxTonGiao.SelectedItem = (string)r["TONGIAO"];
                    txtDiaChi.Text = (string)r["DIACHI"];
                    cbboxCN.SelectedItem = (string)r["TENCHUYENNGANH"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                btLoadSV.Visible = false;
                btThemSV.Visible = false;
                btXoaSV.Visible = false;
                btTimSV.Visible = false;
                button1.Enabled = false;
                button2.Enabled = false;
                dataGridView1.Enabled = false;
                txtTimKiem.Enabled = false;
            }
            
        }
        private void getData(AutoCompleteStringCollection dataCollection)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT HOTEN FROM SINHVIEN";
            connection = new SqlConnection(ConnectionString.connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! \n" + ex);
            }
        }
        private void getData2(AutoCompleteStringCollection dataCollection)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT MSSV FROM SINHVIEN";
            connection = new SqlConnection(ConnectionString.connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! \n" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (click == true)
            {
                if (dataGridView1.Rows.Count == 0)
                {

                }
                else
                {
                    imgLoc = "";
                    txtMSSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtHoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dataGridView1.CurrentRow.Selected = true;
                    if (dataGridView1.CurrentRow.Cells[2].Value.ToString() != "")
                    {
                        byte[] img = (byte[])(dataGridView1.CurrentRow.Cells[2].Value);
                        if (img == null)
                            picstudent.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            picstudent.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picstudent.Image = null;
                    }
                    txtCCCD.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    cbboxGioitinh.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txtQuocGia.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    cbboxDanToc1.SelectedItem = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    cbboxTonGiao.SelectedItem = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    cbboxKhoa.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    cbboxLop.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    txtSDT.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    txtEmail.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    cbboxCN.SelectedItem = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    txtDiaChi.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                }
            }
        }

        private void HienThiSVTheoKhoaLop()
        {
            string query = String.Format("SELECTSVKHOALOP N'" + cbboxchonkhoa.SelectedItem + "', '" + cbboxchonlop.SelectedItem.ToString() + "'");
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                adapter.Fill(data);
                con.Close();
            }
            dataGridView1.DataSource = data;
        }

        private void btLoadSV_Click(object sender, EventArgs e)
        {
            if (cbboxchonlop.Text != "")
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                start = 0;
                page = 1;
                lblPageNumber.Text = "Trang : " + page;
                lblPageMAx.Text = "";
                HienThiSVTheoKhoaLop();
                click = true;
                btnback.Enabled = false;
                btnnext.Enabled = false;
                btnfullnext.Enabled = false;
                btnfullback.Enabled = false;
                trangthai = "L";
            }
            else
            {
                MessageBox.Show("Hãy Chọn Khoa Rồi Chọn Lớp");
            }
        }

        private void btSuaSV_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text != "")
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Xác Nhận Chỉnh Sửa?", "Chỉnh sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (thongbao == DialogResult.OK)
                {
                    byte[] img = null;
                    FileStream fs = new System.IO.FileStream(imgLoc, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    con.Open();
                    String sql = "UPDATE SINHVIEN\r\n    SET\r\n        MAKHOA = (SELECT MAKHOA FROM KHOA WHERE TENKHOA = @TENKHOA),\r\n        MACHUYENNGANH = (SELECT MACHUYENNGANH FROM CHUYENNGANH WHERE TENCHUYENNGANH = @TENCHUYENNGANH),\r\n        MALOP = @MALOP,\r\n        ANHSV = @ANHSV\r\n    WHERE MSSV = @MSSV;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@MSSV", SqlDbType.Char, 8);
                    cmd.Parameters.Add("@TENKHOA", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@TENCHUYENNGANH", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@MALOP", SqlDbType.VarChar, 12);
                    cmd.Parameters.Add(new SqlParameter("@ANHSV", img));
                    cmd.Parameters["@MSSV"].Value = txtMSSV.Text;
                    cmd.Parameters["@TENKHOA"].Value = cbboxKhoa.SelectedItem;
                    cmd.Parameters["@MALOP"].Value = cbboxLop.SelectedItem;
                    cmd.Parameters["@TENCHUYENNGANH"].Value = cbboxCN.SelectedItem;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Thay đổi thông tin sinh viên thành công");
                    //txtMSSV.Clear();
                    //txtHoten.Clear();
                    //cbboxGioitinh.Items.Clear();
                    //cbboxDanToc1.Items.Clear();
                    //cbboxTonGiao.Items.Clear();
                    //cbboxLop.Items.Clear();
                    //cbboxKhoa.Items.Clear();
                    //txtSDT.Clear();
                    //txtEmail.Clear();
                    //txtQuocGia.Clear();
                    //cbboxCN.Items.Clear();
                    //txtCCCD.Clear();
                    //txtDiaChi.Clear();
                    //picstudent.Image = null;
                    if (trangthai == "L")
                    {
                        HienThiSVTheoKhoaLop();
                    }
                    else if (trangthai == "TK" && TimKiem != "")
                    {
                        timSV();
                    }
                    else if (trangthai == "All")
                    {
                        HienThiAllSV();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tượng");
            }
        }

        private void btXoaSV_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text != "")
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Delete Sinh Vien", "Delete ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (thongbao == DialogResult.OK)
                {
                    #region truyền tham số
                    List<CustomParameter> lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter()
                        {
                            key = "@MSSV",
                            value = txtMSSV.Text
                        },
                    };
                    #endregion

                    var rs = new Database().ExeCute("XOASV", lstPara);  //truyền câu lệnh sql và các tham số
                    if (rs == 1)      //nếu thực thi thành công
                    {
                        MessageBox.Show("Xóa sinh viên thành công");
                        txtMSSV.Clear();
                        txtHoten.Clear();
                        cbboxGioitinh.Items.Clear();
                        cbboxDanToc1.Items.Clear();
                        cbboxTonGiao.Items.Clear();
                        cbboxLop.Items.Clear();
                        cbboxKhoa.Items.Clear();
                        txtSDT.Clear();
                        txtEmail.Clear();
                        txtQuocGia.Clear();
                        cbboxCN.Items.Clear();
                        txtCCCD.Clear();
                        txtDiaChi.Clear();
                        picstudent.Image = null;
                    }
                    else        //thực thi lỗi
                    {
                        MessageBox.Show("Thực hiện thất bại");
                    };
                    
                    if (trangthai == "L")
                    {
                        HienThiSVTheoKhoaLop();
                    }
                    else if (trangthai == "TK" && TimKiem != "")
                    {
                        timSV();
                    }
                    else if (trangthai == "All")
                    {
                        ds.Clear();
                        HienThiAllSV();
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tượng");
            }
        }

        private void txtSDT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbboxchonkhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cbboxchonkhoa.DroppedDown = true;
            //if (char.IsControl(e.KeyChar))
            //{
            //    return;
            //}
            //string str = cbboxchonkhoa.Text.Substring(0, cbboxchonkhoa.SelectionStart) + e.KeyChar;
            //Int32 index = cbboxchonkhoa.FindStringExact(str);
            //if (index == -1)
            //{
            //    index = cbboxchonkhoa.FindString(str);
            //}
            //this.cbboxchonkhoa.SelectedIndex = index;
            //this.cbboxchonkhoa.SelectionStart = str.Length;
            //this.cbboxchonkhoa.SelectionLength = this.cbboxchonkhoa.Text.Length - this.cbboxchonkhoa.SelectionStart;
            //e.Handled = true;
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void timSV()
        {
            if (txtTimKiem.Text != "")
            {
                click = true;
                if (IsNumber(txtTimKiem.Text) == true)
                {
                    string query = String.Format("SELECTSV '" + txtTimKiem.Text + "'");
                    DataTable data = new DataTable();
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = con;
                        cmd1.CommandText = query;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                        adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có sinh viên này");
                    }
                    TimKiem = txtTimKiem.Text;
                }
                else
                {
                    DataTable data = new DataTable();
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.CommandText = "FINDSV";
                        cmd2.Parameters.Add(new SqlParameter("@HOTEN", txtTimKiem.Text));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                        adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có sinh viên này");
                    }
                    TimKiem = txtTimKiem.Text;
                }
            }
        }

        private void btTimSV_Click(object sender, EventArgs e)
        {
            click = true;
            page = 1;
            lblPageMAx.Text = "";
            btnback.Enabled = false;
            btnnext.Enabled = false;
            btnfullnext.Enabled = false;
            btnfullback.Enabled = false;
            trangthai = "TK";
            timSV();
            
        }

        private void HienThiAllSV()
        {
            con.Open();
            ds.Clear();
            start = 0;
            page = 1;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SELECTALLSV";
            adapter.SelectCommand = cmd;
            double c = (double)count() / (double)17;
            lblPageMAx.Text = "/" + (int)Math.Ceiling(c);
            adapter.Fill(ds, start, 17, "OP");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Cập Nhật Toàn Bộ SV?", "Hiển Thị Toàn Bộ SV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                click = true;
                HienThiAllSV();
                lblPageNumber.Text = "Trang: 1";
                btnback.Enabled = false;
                btnnext.Enabled = true;
                btnfullnext.Enabled = true;
                btnfullback.Enabled = false;
                
                trangthai = "All";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            start = start - 17;
            btnnext.Enabled = true;
            btnfullnext.Enabled = true;
            if (start < 0)
            {
                start = 0;
                btnback.Enabled = false;
                btnfullback.Enabled = false;
            }
            else
            {
                ds.Clear();
                adapter.Fill(ds, start, 17, "OP");
                btnfullnext.Enabled = true;
                btnnext.Enabled = true;
                page = page - 1;
                lblPageNumber.Text = "Trang: " + page;
                if (start - 17 < 0)
                {
                    btnback.Enabled = false;
                    btnfullback.Enabled = false;
                }
            }

        }
        public static int count()
        {
            int kq;
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            con.Open();
            String sql = "SELECT COUNT(*) FROM SINHVIEN";
            SqlCommand cmd = new SqlCommand(sql, con);
            kq = (int)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            start = start + 17;
            btnback.Enabled = true;
            if (start > count())
            {
                btnnext.Enabled = false;
                btnfullnext.Enabled = false;
            }
            else
            {
                ds.Clear();
                adapter.Fill(ds, start, 17, "OP");
                btnback.Enabled = true;
                btnfullback.Enabled = true;
                page = page + 1;
                lblPageNumber.Text = "Trang: " + page;
                if (start + 17 >= count())
                {
                    btnnext.Enabled = false;
                    btnfullnext.Enabled = false;
                }
            }
        }

        private void btnfullback_Click(object sender, EventArgs e)
        {
            start = 0;
            ds.Clear();
            adapter.Fill(ds, start, 17, "OP");
            btnfullback.Enabled = false;
            btnfullnext.Enabled = true;
            btnnext.Enabled = true;
            btnback.Enabled = false;
            page = 1;
            lblPageNumber.Text = "Trang: " + page;
        }

        private void btnfullnext_Click(object sender, EventArgs e)
        {
            int phandu = count() % 17;
            if (phandu == 0)
            {
                start = count() - 17;
            }
            else
            {
                start = count() - phandu;
            }
            ds.Clear();
            adapter.Fill(ds, start, 17, "OP");
            btnfullnext.Enabled = false;
            btnfullback.Enabled = true;
            btnback.Enabled = true;
            btnnext.Enabled = false;
            double c = (double)count() / (double)18;
            page = (int)Math.Ceiling(c);
            lblPageNumber.Text = "Trang: " + page;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Student Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picstudent.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
