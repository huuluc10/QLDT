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
    public partial class FrmTaoLopDangKyHoc : Form
    {
        static String namHoc;
        static String hocKy;
        public FrmTaoLopDangKyHoc()
        {
            InitializeComponent();
        }

        private void FrmTaoLopDangKyHoc_Load(object sender, EventArgs e)
        {
            namHoc = null;

            DateTime today = DateTime.Now;
            int year = today.Year;
            int month = today.Month;
            if (month <= 6)
            {
                namHoc = year - 1 + " - " + year ;
                hocKy = "2";
            }
            else if (month > 6)
            {
                namHoc = year + " - " + (year + 1);
                hocKy = "1";
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
                        cbboxKhoa.Items.Add(khoa);
                        cbboxLoadKhoa.Items.Add(khoa);
                    }
                }
                con.Close();
            }
        }

        private void XoaLop(String Malop)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XOALOPHP";
                cmd.Parameters.Add(new SqlParameter("@MAKHOAHOC", Malop));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private DataTable LoadLopMo()
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LIST_LOPHOC";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }


        private DataTable LoadLopMoTheoKhoa(String makhoa)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LIST_LOPHOCTHEOKHOA";
                cmd.Parameters.Add(new SqlParameter("@TENKHOA", makhoa));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMaLopHP.Text=="" || cbboxMonHoc.Text=="" || cbboxGiangVien.Text=="")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin lớp học cần mở");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "MOLOPHOC";
                    cmd.Parameters.Add(new SqlParameter("@MAKHOAHOC", txtMaLopHP.Text));
                    cmd.Parameters.Add(new SqlParameter("@HOTEN", cbboxGiangVien.SelectedItem.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@TENMONHOC", cbboxMonHoc.SelectedItem.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@HOCKY", hocKy));
                    cmd.Parameters.Add(new SqlParameter("@NAM", namHoc));
                    MessageBox.Show(cbboxGiangVien.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Mở Thành Công Lớp");
                dataGridView1.DataSource = LoadLopMo();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[5, i] = linkCell;
                }
                txtMaLopHP.Clear();
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {

            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    string Task = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    if (Task == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            String ID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                            XoaLop(ID);
                            dataGridView1.DataSource = LoadLopMo();
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                                dataGridView1[5, i] = linkCell;
                            }
                        }
                    }
                }

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadLopMo();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[5, i] = linkCell;
            }
        }


        private void btnLoadTheoKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbboxLoadKhoa.SelectedItem.ToString() != "")
                {
                    dataGridView1.DataSource = LoadLopMoTheoKhoa(cbboxLoadKhoa.SelectedItem.ToString());
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                        dataGridView1[5, i] = linkCell;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void cbboxKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                string queryKhoa = "SELECT DISTINCT HOTEN FROM GIAOVIEN WHERE MAKHOA = (SELECT MAKHOA FROM KHOA WHERE TENKHOA = N'" + cbboxKhoa.SelectedItem.ToString() + "') ORDER BY HOTEN";
                SqlCommand cmd = new SqlCommand(queryKhoa, con);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxGiangVien.Items.Add(khoa);
                    }
                }
                queryKhoa = String.Format("HIENTHIMONTHEOKHOA N'" + cbboxKhoa.SelectedItem.ToString() + "'");
                cmd = new SqlCommand(queryKhoa, con);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxMonHoc.Items.Add(khoa);
                    }
                }
                con.Close();
            }
        }
    }
}
