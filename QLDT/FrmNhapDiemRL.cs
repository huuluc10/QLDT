using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    public partial class FrmNhapDiemRL : Form
    {
        string username;
        string quyenhan;

        static String namHoc;
        static String hocKy;

        public FrmNhapDiemRL(string username, string quyenhan)
        {
            InitializeComponent();
            this.username = username;
            this.quyenhan = quyenhan;
        }

        public Boolean click = false;

        private string HocKy(string msv)
        {
            string mk;
            var r = new Database().Select(String.Format("SELECT MAX(HOCKY) + 1  as HOCKY FROM DIEMRENLUYEN\r\nWHERE MSSV = '" + msv + "'"));
            mk = r["HOCKY"].ToString();
            return mk;
        }
        private void FrmNhapDiemRL_Load(object sender, EventArgs e)
        {
            txtTongDiemRL.MaxLength = 3;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DateTime today = DateTime.Now;
            int year = today.Year;
            int month = today.Month;
            if (month <= 6)
            {
                namHoc = year - 1 + " - " + year;
            }
            else if (month > 6)
            {
                namHoc = year + " - " + (year + 1);
            }
            txtNamHocHienTai.Text = namHoc;
            txtHocKy.Text = hocKy;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                string queryKhoa = "SELECT DISTINCT TENKHOA FROM KHOA ORDER BY TENKHOA";
                SqlCommand cmd = new SqlCommand(queryKhoa, con);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxChonkhoa.Items.Add(khoa);
                    }
                }
                con.Close();
            }

        }

        public DataTable LoadDanhSachSinhVien(String Malop)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "DSCHAMDRL '" + Malop + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        private void btnLoadSV_Click(object sender, EventArgs e)
        {
            if (cbboxchonlop.Text != "")
            {
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.DataSource = LoadDanhSachSinhVien(cbboxchonlop.SelectedItem.ToString());
                click = true;
            }
            else
            {
                MessageBox.Show("Hãy Chọn Lớp");
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
                    
                    txtMSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string hk = HocKy(txtMSV.Text);
                    txtHoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtLop.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtHocKy.Text = hk;
                }
            }
        }

        public Boolean TinhTK(String Namhoc,String msv)
        {
     
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "SELECT COUNT(*)FROM DiemRL where NamHoc=@namhoc and MSVien=@msv";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@namhoc", Namhoc));
                cmd.Parameters.Add(new SqlParameter("@msv", msv));
                int kq = (int)cmd.ExecuteScalar();
                con.Close();
                if (kq == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
      
        }
        public int DiemHocKy(String HocKy,String NamHoc,String MSV)
        {
            int Diem;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "SELECT Tongdiem FROM DiemRL where MSVien=@msv and Namhoc=@namhoc and Hocky=@hocky";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@msv", MSV));
                cmd.Parameters.Add(new SqlParameter("@namhoc", NamHoc));
                cmd.Parameters.Add(new SqlParameter("@hocky", HocKy));
                Diem = (int)cmd.ExecuteScalar();
                con.Close();
            }
            return Diem;
        }
        public Boolean KTraTrung(String msv,String namhoc,String hocky)  
        {
            Boolean check;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "SELECT COUNT(*)FROM DiemRL WHERE MSVien=@msv and Namhoc=@namhoc and Hocky=@hocky";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@msv", SqlDbType.NVarChar, 10);
                cmd.Parameters["@msv"].Value = msv;
                cmd.Parameters.Add("@namhoc", SqlDbType.NVarChar, 30);
                cmd.Parameters["@namhoc"].Value = namhoc;
                cmd.Parameters.Add("@hocky", SqlDbType.NVarChar, 20);
                cmd.Parameters["@hocky"].Value = hocky;
                int b = (int)cmd.ExecuteScalar();
                if (b == 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                con.Close();
            }
            return check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 sinh viên nào đó");
            }
            else
            {
                if (txtTongDiemRL.Text == "")
                {
                    MessageBox.Show("Hãy điền điểm");
                }
                else
                {
                    if (int.Parse(txtTongDiemRL.Text) >= 0 && int.Parse(txtTongDiemRL.Text) <= 100)
                    {
                        using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                        {
                            con.Open();
                            String sql = "NHAPDRL @MSSV, @HOCKY, @DIEM";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.Parameters.Add("@MSSV", SqlDbType.Char, 8);
                            cmd.Parameters.Add("@HOCKY", SqlDbType.Char, 1);
                            cmd.Parameters.Add("@DIEM", SqlDbType.TinyInt);
                            cmd.Parameters["@MSSV"].Value = txtMSV.Text;
                            cmd.Parameters["@HOCKY"].Value = txtHocKy.Text;
                            cmd.Parameters["@DIEM"].Value = txtTongDiemRL.Text;
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn Nhập Điểm Ko hợp lệ");
                    }
                }
            }
        }

        private void txtTongDiemRL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongDiemRL_TextChanged(object sender, EventArgs e)
        {
            if (txtTongDiemRL.Text == "") { }
            else
            {
                if (int.Parse(txtTongDiemRL.Text) > 100)
                {
                    txtTongDiemRL.Text = "100";
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void cbboxChonkhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                string query = String.Format("SELECT DISTINCT MALOP FROM LOPQUANLY WHERE MAKHOA = (SELECT MAKHOA FROM KHOA WHERE TENKHOA = N'" + cbboxChonkhoa.SelectedItem.ToString() + "') ORDER BY MALOP"); ;
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string LOP = saReader.GetString(0);
                        cbboxchonlop.Items.Add(LOP);
                    }
                }
                con.Close();
            }
        }
    }
}
