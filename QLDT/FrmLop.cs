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
    public partial class FrmLop : Form
    {
        public FrmLop()
        {
            InitializeComponent();
        }
        public Boolean click = false;
        public Boolean click2 = false;
        private void FrmLop_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                        cbboxKhoa.Items.Add(khoa);
                        cbboxKhoa1.Items.Add(khoa);
                    }
                }
                con1.Close();
            }
            using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
            {
                con1.Open();
                string query = string.Format("SELECT DISTINCT HOTEN FROM GIAOVIEN");
                SqlCommand cmd = new SqlCommand(query, con1);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        cbbGVCV.Items.Add(saReader.GetString(0));
                        cbbGVCV1.Items.Add(saReader.GetString(0));
                    }
                }
                con1.Close();
            }
            LoadLop();
        }

        private void LoadLop()
        {
            DataTable data = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SELECTALLLOP";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            dataGridView1.DataSource = data;
            click = true;
        }

        private void btLoadLop_Click(object sender, EventArgs e)
        {
            LoadLop();
        }

        private void btThemLop_Click(object sender, EventArgs e)
        {
            if (txbTenlop1.Text != "" && txtMalop1.Text != "" && cbboxKhoa1.SelectedItem.ToString() != "" && cbbGVCV1.SelectedItem.ToString() != "")
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "THEMLOP";
                    cmd.Parameters.Add(new SqlParameter("@MALOP", txtMalop1.Text));
                    cmd.Parameters.Add(new SqlParameter("@TENLOP", txbTenlop1.Text));
                    cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxKhoa1.SelectedItem.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@HOTEN", cbbGVCV1.SelectedItem.ToString()));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Thêm khoa thành công");
                LoadLop();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }



        private void btsuaLop_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Xác Nhận Chỉnh Sửa?", "Chỉnh sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SUALOP";
                    cmd.Parameters.Add(new SqlParameter("@MALOP", txtMalop.Text));
                    cmd.Parameters.Add(new SqlParameter("@HOTEN", cbbGVCV.SelectedItem.ToString()));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Sửa khoa thành công");
                LoadLop();
                txtMalop.Clear();
                txtTenlop.Clear();
            }
        }

        private void btXoaLop_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Delete", "Bạn thực sự muốn xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "XOALOP";
                    cmd.Parameters.Add(new SqlParameter("@MALOP", txtMalop.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Xóa khoa thành công");
                LoadLop();
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
                    txtMalop.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtTenlop.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    cbboxKhoa.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    cbbGVCV.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
