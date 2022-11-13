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
    public partial class FrmKhoa : Form
    {
        public FrmKhoa()
        {
            InitializeComponent();
        }
        public Boolean click = false;

        private void LoadKhoa()
        {
            DataTable data = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DANHSACHKHOA";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            dataGridView1.DataSource = data;
            click = true;
        }

        private void btLoadkhoa_Click(object sender, EventArgs e)
        {
            LoadKhoa();
        }

        private void btThemkhoa_Click(object sender, EventArgs e)
        {
            var f = new FrmAddKhoa();
            f.Show();
            LoadKhoa();
        }

        private void SuaKhoa(String maKhoa, String tenTruongKhoa, String diaChi, String website)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SUAKHOA";
                cmd.Parameters.Add(new SqlParameter("@MAKHOA", maKhoa));
                cmd.Parameters.Add(new SqlParameter("@TENTRUONGKHOA", tenTruongKhoa));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", diaChi));
                cmd.Parameters.Add(new SqlParameter("@WEBSITE", website));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btsuakhoa_Click(object sender, EventArgs e)
        {
            if (cbbTK.SelectedItem.ToString() != "" && txtDiaChi.Text != "" && txtWeb.Text != "")
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Xác Nhận Chỉnh Sửa?", "Chỉnh sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (thongbao == DialogResult.OK)
                {
                    SuaKhoa(dataGridView1.CurrentRow.Cells[0].Value.ToString(), cbbTK.SelectedItem.ToString(), txtDiaChi.Text, txtWeb.Text);
                    LoadKhoa();
                }
                cbbTK.Items.Clear();
                txtDiaChi.Clear();
                txtWeb.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void XoaKhoa(String maKhoa)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XOAKHOA";
                cmd.Parameters.Add(new SqlParameter("@MAKHOA", maKhoa));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btXoakhoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Delete Khoa", "Bạn thực sự Muốn Xóa Khoa này ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                XoaKhoa(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                LoadKhoa();
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
                    cbbTK.Items.Clear();
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        string query = String.Format("SELECT DISTINCT HOTEN FROM GIAOVIEN WHERE MAKHOA = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY HOTEN");
                        SqlCommand cmd = new SqlCommand(query, con);
                        using (SqlDataReader saReader = cmd.ExecuteReader())
                        {
                            while (saReader.Read())
                            {
                                string lop = saReader.GetString(0);
                                cbbTK.Items.Add(lop);
                            }
                        }
                    }
                    cbbTK.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtDiaChi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txtWeb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                }
            }
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                    }
                }

                string queryLop = String.Format("SELECT DISTINCT MAKHOA, TENKHOA FROM KHOA ORDER BY TENKHOA");
                cmd = new SqlCommand(queryLop, con);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string lop = saReader.GetString(0);
                        cbboxChonKhoaCapNhat.Items.Add(lop);
                    }
                }

                con.Close();
            }
            LoadKhoa();
            LoadChuyenNganh();
        }

        private void ThemChuyenNganh(String machuyennganh,String tenchuyennganh,String makhoa)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TAOCHUYENNGANH";
                cmd.Parameters.Add(new SqlParameter("@MACHUYENNGANH", machuyennganh));
                cmd.Parameters.Add(new SqlParameter("@TENCHUYENNGANH", tenchuyennganh));
                cmd.Parameters.Add(new SqlParameter("@MAKHOA", makhoa));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void XoaChuyenNganh(String machuyennganh)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XOACHUYENNGANH";
                cmd.Parameters.Add(new SqlParameter("@MACHUYENNGANH", machuyennganh));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void SuaChuyenNganh(String machuyennganh, String tenchuyennganh, String makhoa)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SUACHUYENNGANH";
                cmd.Parameters.Add(new SqlParameter("@MACHUYENNGANH", machuyennganh));
                cmd.Parameters.Add(new SqlParameter("@TENCHUYENNGANH", tenchuyennganh));
                cmd.Parameters.Add(new SqlParameter("@MAKHOA", makhoa));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        private void LoadChuyenNganh()
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DANHSACHTATCACHUYENNGANH";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            dataGridView2.DataSource = data;
        }

        private DataTable LoadChuyenNganhTheoKhoa(String makhoa)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DANHSACHTATCACHUYENNGANHTHEOKHOA";
                cmd.Parameters.Add(new SqlParameter("@makhoa", makhoa));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtTenChuyenNganh.Text!="" && txtMaChuyenNganh.Text!="")
            {
                try
                {
                    ThemChuyenNganh(txtMaChuyenNganh.Text, txtTenChuyenNganh.Text, cbboxKhoa.SelectedValue.ToString());
                    MessageBox.Show("Thêm Thành Công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Trùng Mã CN\n"+ex);
                } 
            }
            else
            {
                MessageBox.Show("Điền Đầy Đủ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChuyenNganh();
        }

        private void btnCapNhatCNTheoKhoa_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = LoadChuyenNganhTheoKhoa(cbboxChonKhoaCapNhat.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenNganh.Text != "")
            {
                SuaChuyenNganh(txtMaChuyenNganh.Text, txtTenChuyenNganh.Text, cbboxKhoa.SelectedValue.ToString());
                MessageBox.Show("Done :)");
            }
            else
            {
                MessageBox.Show("Chọn đối tượng");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.Rows.Count==0)
            {

            }
            else
            {
                txtMaChuyenNganh.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtTenChuyenNganh.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                cbboxKhoa.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            cbboxKhoa.Items.Clear();
            txtMaChuyenNganh.Clear();
            txtTenChuyenNganh.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenNganh.Text != "")
            {
                XoaChuyenNganh(txtMaChuyenNganh.Text);
                MessageBox.Show("Done :)");
            }
            else
            {
                MessageBox.Show("Chọn đối tượng");
            }
        }
    }
}
