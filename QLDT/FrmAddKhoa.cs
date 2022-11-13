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
    public partial class FrmAddKhoa : Form
    {
        public FrmAddKhoa()
        {
            InitializeComponent();
        }


        private void FrmREGISTER_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                string queryKhoa = "SELECT DISTINCT HOTEN, MAKHOA FROM GIAOVIEN ORDER BY MAKHOA";
                SqlCommand cmd = new SqlCommand(queryKhoa, con);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbbTK.Items.Add(khoa);
                    }
                }
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaKhoa.Text != "" && txbTenKhoa.Text != "" && cbbTK.SelectedItem.ToString() != "" && txbEmail.Text != "" && txbDiaChi.Text != "" && txbDienThoai.Text != "" && txbWeb.Text != "")
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "THEMKHOA";
                    cmd.Parameters.Add(new SqlParameter("@MAKHOA", txbMaKhoa.Text));
                    cmd.Parameters.Add(new SqlParameter("@TENKHOA", txbTenKhoa.Text));
                    cmd.Parameters.Add(new SqlParameter("@TENTRUONGKHOA", cbbTK.SelectedItem.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", txbEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", txbDiaChi.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIENTHOAI", txbDienThoai.Text));
                    cmd.Parameters.Add(new SqlParameter("@WEBSITE", txbWeb.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Thêm khoa thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }
    }
}
