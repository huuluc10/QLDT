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
    public partial class FrmMonHoc : Form
    {
        public FrmMonHoc()
        {
            InitializeComponent();
        }
        //MonHoc a = new MonHoc();
        //KhoaDT b = new KhoaDT();
        static Boolean click = false;

        private DataTable LoadMonHocTheoKhoaNganh(String tenKhoa,String tenChuyenNganh)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MONTHEOKHOANGANH";
                cmd.Parameters.Add(new SqlParameter("@TENKHOA", tenKhoa));
                cmd.Parameters.Add(new SqlParameter("@TENCHUYENNGANH", tenChuyenNganh));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        private DataTable LoadTatCaMonHoc()
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LOADTATCAMONHOC";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        private void btLoadMH_Click(object sender, EventArgs e)
        {
            if (radioButtonTatCa.Checked)
            {
                dataGridView1.DataSource = LoadTatCaMonHoc();
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Empty");
                }
                else
                {
                    click = true;
                }
            }
            else if(radioButtonTheoKhoa.Checked)
            {
                if (cbboxchonkhoa.Text != "")
                {
                    if(cbboxLoadChuyenNganh.SelectedItem.ToString()!="")
                    {
                        dataGridView1.DataSource = LoadMonHocTheoKhoaNganh(cbboxchonkhoa.SelectedItem.ToString(), cbboxLoadChuyenNganh.SelectedItem.ToString());
                        if (dataGridView1.Rows.Count == 0)
                        {
                            MessageBox.Show("Empty");
                        }
                        else
                        {
                            click = true;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Chưa chọn chuyên ngành");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn khoa");
                }
            }
            else
            {
                MessageBox.Show("Hãy Lựa Chọn");
            }
        }

        private void btThemMH_Click(object sender, EventArgs e)
        {
            Form frm = new FrmThemMonHoc();
            frm.Show();
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            cbboxchonkhoa.Enabled = false;
            using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
            {
                con1.Open();
                string queryKhoa = "SELECT DISTINCT TENKHOA FROM KHOA ORDER BY TENKHOA";
                SqlCommand cmd = new SqlCommand(queryKhoa, con1);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxchonkhoa.Items.Add(khoa);
                    }
                }
                con1.Close();
            }
        }

        private void btXoaMH_Click(object sender, EventArgs e)
        {
            if (txtMaMH1.Text == "")
            {
                MessageBox.Show("Hãy Chọn 1 môn học nào đó");
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "XOAMON";
                        cmd.Parameters.Add(new SqlParameter("@MAMONHOC", txtMaMH1.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    txtMaMH1.Clear();
                    txtTenMH1.Clear();
                    MessageBox.Show("Đã xóa môn");
                    click = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btsuaMH_Click(object sender, EventArgs e)
        {
            if (txtMaMH1.Text == "")
            {
                MessageBox.Show("Hãy Chọn 1 môn học nào đó");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SUAMON";
                    cmd.Parameters.Add(new SqlParameter("@MAMONHOC", txtMaMH1.Text));
                    cmd.Parameters.Add(new SqlParameter("@SOTC", numericUpDownSoTC1.Value));
                    cmd.Parameters.Add(new SqlParameter("@TSCHUYENCAN", (txtCC.Text).Replace(",",".")));
                    cmd.Parameters.Add(new SqlParameter("@TSGIUAKY", (txtGK.Text).Replace(",", ".")));
                    cmd.Parameters.Add(new SqlParameter("@TSCUOIKY", (txtCK.Text).Replace(",", ".")));
                    cmd.Parameters.Add(new SqlParameter("@DONGIA", txbDonGia.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Sửa môn thành công");
                btLoadMH_Click(null,null);
                txtMaMH1.Clear();
                txtTenMH1.Clear();
                txtCC.Clear();
                txtGK.Clear();
                txtCK.Clear();
                txbDonGia.Clear();
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
                    txtMaMH1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtTenMH1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    numericUpDownSoTC1.Value = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    txtCC.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txtGK.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    txtCK.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    string dongia = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    txbDonGia.Text = dongia.Substring(0, dongia.Length-1);
                }
            }
        }

        private void radioButtonTheoKhoa_CheckedChanged(object sender, EventArgs e)
        {
            cbboxchonkhoa.Enabled = true;
            cbboxLoadChuyenNganh.Enabled = true;
        }

        private void radioButtonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            cbboxchonkhoa.Enabled = false;
            cbboxLoadChuyenNganh.Enabled = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void cbboxchonkhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            cbboxLoadChuyenNganh.Items.Clear();
            cbboxLoadChuyenNganh.Text = "";
            using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
            {
                con1.Open();
                string queryKhoa = String.Format("SELECT DISTINCT TENCHUYENNGANH FROM CHUYENNGANH WHERE MAKHOA = (SELECT MAKHOA FROM KHOA WHERE TENKHOA = N'" + cbboxchonkhoa.SelectedItem.ToString() + "') ORDER BY TENCHUYENNGANH");
                SqlCommand cmd = new SqlCommand(queryKhoa, con1);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxLoadChuyenNganh.Items.Add(khoa);
                    }
                }
                con1.Close();
            }
        }
    }
}
