using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDT
{
    public partial class FrmXemDiem : Form
    {
        private String MaSinhVien;
        public FrmXemDiem(String MaSV)
        {
            InitializeComponent();
            this.MaSinhVien = MaSV;
        }

        private void FrmXemDiem_Load(object sender, EventArgs e)
        {
            lblhienthithongtinsinhvien.Text = "MSV: " + MaSinhVien;
            using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
            {
                con1.Open();
                string queryKhoa = "SELECT DISTINCT NAM FROM GIANGDAY ORDER BY NAM";
                SqlCommand cmd = new SqlCommand(queryKhoa, con1);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxNamHoc.Items.Add(khoa);
                    }
                }
                con1.Close();
            }
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "KQHT '"+ MaSinhVien +"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.Parameters.Add(new SqlParameter("@MSSV", MaSinhVien));
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(data);
                con.Close();
            }
            dataGridView2.DataSource = data;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (radioButtonTatCa.Checked)
            {
                DataTable data = new DataTable();
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    String sql = "XEMDIEMALL @MSSV";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@MSSV", MaSinhVien));
                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                    Adapter.Fill(data);
                    con.Close();
                }
                dataGridView1.DataSource = data;
            }
            else if (radioTheoNHHK.Checked)
            {
                if (cbboxNamHoc.Text == "")
                {

                }
                else
                {
                    DataTable data = new DataTable();
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        String sql = "XEMDIEMNAMKY @MSSV, @HOCKY, @NAMHOC";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.Add(new SqlParameter("@MSSV", MaSinhVien));
                        cmd.Parameters.Add(new SqlParameter("@HOCKY", numericUpDown1.Value.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@NAMHOC", cbboxNamHoc.SelectedItem.ToString()));
                        SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                        Adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn");
            }
        }

        private void radioTheoNHHK_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (radioButtonTatCa.Checked)
            {
                DataTable data = new DataTable();
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    String sql = "XEMDIEMALL @MSSV";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@MSSV", MaSinhVien));
                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                    Adapter.Fill(data);
                    con.Close();
                }
                dataGridView1.DataSource = data;
            }
            else if (radioTheoNHHK.Checked)
            {
                if (cbboxNamHoc.Text == "")
                {

                }
                else
                {
                    DataTable data = new DataTable();
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        String sql = "XEMDIEMNAMKY @MSSV, @HOCKY, @NAMHOC";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.Add(new SqlParameter("@MSSV", MaSinhVien));
                        cmd.Parameters.Add(new SqlParameter("@HOCKY", numericUpDown1.Value.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@NAMHOC", cbboxNamHoc.SelectedItem.ToString()));
                        SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                        Adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn");
            }
        }

        private void radioButtonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonTatCa.Checked)
            {
                cbboxNamHoc.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {
                cbboxNamHoc.Enabled = true;
                numericUpDown1.Enabled = true;
            }
        }
    }
}
