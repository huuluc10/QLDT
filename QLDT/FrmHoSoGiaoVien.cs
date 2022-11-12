using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QLDT
{
    public partial class FrmHoSoGiaoVien : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        static int start;
        int page;
        static String trangthai="";
        static String TimKiem = "";
        static String Quyen = "";
        static String username = "";
        public FrmHoSoGiaoVien(String quyenhan,String user)
        {
            InitializeComponent();
            start = 0;
            page = 1;
            Quyen = quyenhan;
            username = user;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public Boolean click = false;
        
        private void HoSoSinhVien_Load_1(object sender, EventArgs e)
        {
            con.Open();
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                con.Close();
            }

            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            getData2(DataCollection);
            txtTimKiem.AutoCompleteCustomSource = DataCollection;
            if (Quyen == "2")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        groupBox1.Visible = false;
                        groupBox2.Visible = false;
                        groupBox4.Visible = false;
                        dataGridView1.Visible = false;
                        groupBox3.Dock = DockStyle.Fill;

                        con.Open();
                        String sql = "SELECTGV " + username;
                        cmd = new SqlCommand(sql, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            // get the results of each column
                            txtMSGV.Text = rdr["MSGV"].ToString();
                            txtHoten.Text = (string)rdr["HOTEN"];
                            dateTimePicker1.Text = rdr["NGAYSINH"].ToString();
                            cbboxGioitinh.SelectedItem = (string)rdr["GIOITINH"];
                            cbboxDanToc1.SelectedItem = (string)rdr["DANTOC"];
                            txtSDT.Text = (string)rdr["DIENTHOAI"];
                            txtCCCD.Text = (string)rdr["SOCCCD"];
                            txtEmail.Text = (string)rdr["EMAIL"];
                            cbboxKhoa.SelectedItem = (string)rdr["TENKHOA"];
                            txtQuocGia.Text = (string)rdr["QUOCGIA"];
                            cbboxTonGiao.SelectedItem = (string)rdr["TONGIAO"];
                            txtDiaChi.Text = (string)rdr["DIACHI"];
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                btLoadGV.Visible = false;
                btThemSV.Visible = false;
                btXoaGV.Visible = false;
                btTimGV.Visible = false;
                button1.Enabled = false;
                //button2.Enabled = false;
                dataGridView1.Enabled = false;
                txtMSGV.ReadOnly = true;
                txtCCCD.ReadOnly = true;
                txtHoten.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtQuocGia.ReadOnly = true;
                txtTimKiem.Enabled = false;
                cbboxchonkhoa.Enabled = false;
                cbboxDanToc1.Enabled = false;
                cbboxGioitinh.Enabled = false;
                cbboxTonGiao.Enabled = false;
                cbboxKhoa.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }
        private void getData(AutoCompleteStringCollection dataCollection)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT HOTEN FROM GIAOVIEN";
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
                MessageBox.Show("Can not open connection ! \n"+ex);
            }
        }
        private void getData2(AutoCompleteStringCollection dataCollection)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT MSGV FROM GIAOVIEN";
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
                MessageBox.Show("Can not open connection ! \n"+ex);
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
                    txtMSGV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtHoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dataGridView1.CurrentRow.Selected = true;
                    txtCCCD.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    cbboxGioitinh.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtQuocGia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    cbboxDanToc1.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    cbboxTonGiao.SelectedItem = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    cbboxKhoa.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    txtSDT.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    txtEmail.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    txtDiaChi.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                }
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
            cbboxchonkhoa.DroppedDown = true;
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            string str = cbboxchonkhoa.Text.Substring(0, cbboxchonkhoa.SelectionStart) + e.KeyChar;
            Int32 index = cbboxchonkhoa.FindStringExact(str);
            if (index == -1)
            {
                index = cbboxchonkhoa.FindString(str);
            }
            this.cbboxchonkhoa.SelectedIndex = index;
            this.cbboxchonkhoa.SelectionStart = str.Length;
            this.cbboxchonkhoa.SelectionLength = this.cbboxchonkhoa.Text.Length - this.cbboxchonkhoa.SelectionStart;
            e.Handled = true;
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void HienThiAllGV()
        {
            con.Open();
            ds.Clear();
            start = 0;
            page = 1;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SELECTALLGV";
            adapter.SelectCommand = cmd;
            double c = (double)count() / (double)18;
            lblPageMAx.Text = "/" + (int)Math.Ceiling(c);

            adapter.Fill(ds, start, 17, "OP");

            dataGridView1.DataSource = ds.Tables[0];

            lblPageNumber.Text = "Trang: 1";
            btnback.Enabled = false;
            btnnext.Enabled = true;
            btnfullnext.Enabled = true;
            btnfullback.Enabled = false;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Cập Nhật Toàn Bộ GV?", "Hiển Thị Toàn Bộ GV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                click = true;
                HienThiAllGV();
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
                lblPageNumber.Text = "Trang:" + page;
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
            String sql = "SELECT COUNT(*)FROM Sinhvien";
            SqlCommand cmd = new SqlCommand(sql, con);
            kq = (int)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            start = start + 17;
            btnback.Enabled = true;
            if (start>count())
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
                lblPageNumber.Text = "Trang:" + page;
                if(start+18 >= count())
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
            lblPageNumber.Text = "Trang:" + page;
        }

        private void btnfullnext_Click(object sender, EventArgs e)
        {
            int phandu = count() % 18;
            if (phandu == 0)
            {
                start = count() - 18;
            }
            else
            {
                start = count() - phandu;
            }
            ds.Clear();
            adapter.Fill(ds, start, 18, "OP");
            btnfullnext.Enabled = false;
            btnfullback.Enabled = true;
            btnback.Enabled = true;
            btnnext.Enabled = false;
            double c = (double) count() / (double) 18;
            page = (int)Math.Ceiling(c);
            lblPageNumber.Text = "Trang:" + page;
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

        private void btThemGV_Click(object sender, EventArgs e)
        {
            FrmThemGV frm = new FrmThemGV();
            frm.ShowDialog();
        }

        private void TimGV()
        {
            if (txtTimKiem.Text != "")
            {
                click = true;
                if (IsNumber(txtTimKiem.Text) == true)
                {
                    string query = String.Format("SELECTGV '" + txtTimKiem.Text + "'");
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
                        MessageBox.Show("Không có giáo viên này");
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
                        cmd2.CommandText = "FINDGV";
                        cmd2.Parameters.Add(new SqlParameter("@HOTEN", txtTimKiem.Text));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                        adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có giáo viên này");
                    }
                    TimKiem = txtTimKiem.Text;
                }
            }
        }

        private void btTimGV_Click(object sender, EventArgs e)
        {
            click = true;
            page = 1;
            lblPageMAx.Text = "";
            btnback.Enabled = false;
            btnnext.Enabled = false;
            btnfullnext.Enabled = false;
            btnfullback.Enabled = false;
            trangthai = "TK";
            TimGV();
        }

        private void HienThiGVTheoKhoa()
        {
            string query = String.Format("SELECTGVKHOA N'" + cbboxchonkhoa.SelectedItem + "'");
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

        private void btLoadGV_Click(object sender, EventArgs e)
        {
            if (cbboxchonkhoa.Text != "")
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                start = 0;
                page = 1;
                lblPageNumber.Text = "Trang : " + page;
                lblPageMAx.Text = "";
                HienThiGVTheoKhoa();
                click = true;
                btnback.Enabled = false;
                btnnext.Enabled = false;
                btnfullnext.Enabled = false;
                btnfullback.Enabled = false;
                trangthai = "L";
            }
            else
            {
                MessageBox.Show("Hãy Chọn Khoa");
            }
        }

        private void btXoaGV_Click(object sender, EventArgs e)
        {
            if (txtMSGV.Text != "")
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Delete Giao Vien", "Delete ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (thongbao == DialogResult.OK)
                {
                    #region truyền tham số
                    List<CustomParameter> lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter()
                        {
                            key = "@MSSV",
                            value = txtMSGV.Text
                        },
                    };
                    #endregion

                    var rs = new Database().ExeCute("XOAGV", lstPara);  //truyền câu lệnh sql và các tham số
                    if (rs == 1)      //nếu thực thi thành công
                    {
                        MessageBox.Show("Xóa sinh viên thành công");
                        txtMSGV.Clear();
                        txtHoten.Clear();
                        cbboxGioitinh.Items.Clear();
                        cbboxDanToc1.Items.Clear();
                        cbboxTonGiao.Items.Clear();
                        cbboxKhoa.Items.Clear();
                        txtSDT.Clear();
                        txtEmail.Clear();
                        txtQuocGia.Clear();
                        txtCCCD.Clear();
                        txtDiaChi.Clear();
                    }
                    else        //thực thi lỗi
                    {
                        MessageBox.Show("Thực hiện thất bại");
                    };

                    if (trangthai == "L")
                    {
                        HienThiGVTheoKhoa();
                    }
                    else if (trangthai == "TK" && TimKiem != "")
                    {
                        TimGV();
                    }
                    else if (trangthai == "All")
                    {
                        ds.Clear();
                        HienThiAllGV();
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tượng");
            }
        }
    }
}
