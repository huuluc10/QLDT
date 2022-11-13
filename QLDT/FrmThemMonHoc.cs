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
    public partial class FrmThemMonHoc : Form
    {
        public FrmThemMonHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "THEMMON";
                cmd.Parameters.Add(new SqlParameter("@MAMONHOC", txbMaMH.Text));
                cmd.Parameters.Add(new SqlParameter("@TENMONHOC", txbTenMH.Text));
                cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxKhoa.SelectedItem.ToString()));
                cmd.Parameters.Add(new SqlParameter("@TENCHUYENNGANH", cbboxCN.SelectedItem.ToString()));
                cmd.Parameters.Add(new SqlParameter("@SOTC", numericUpDownSoTC1.Value));
                cmd.Parameters.Add(new SqlParameter("@TSCHUYENCAN", txbChuyenCan.Text));
                cmd.Parameters.Add(new SqlParameter("@TSGIUAKY", txbGK.Text));
                cmd.Parameters.Add(new SqlParameter("@TSCUOIKY", txbCK.Text));
                cmd.Parameters.Add(new SqlParameter("@DONGIA", txbDonGia.Text));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Thêm khoa thành công");
            this.Dispose();
        }

        private void FrmThemMonHoc_Load(object sender, EventArgs e)
        {
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
                    }
                }
                con1.Close();
            }
        }

        private void cbboxKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            cbboxCN.Items.Clear();
            cbboxCN.Text = "";
            using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
            {
                con1.Open();
                string queryKhoa = String.Format("SELECT DISTINCT TENCHUYENNGANH FROM CHUYENNGANH WHERE MAKHOA = (SELECT MAKHOA FROM KHOA WHERE TENKHOA = N'" + cbboxKhoa.SelectedItem.ToString() + "') ORDER BY TENCHUYENNGANH");
                SqlCommand cmd = new SqlCommand(queryKhoa, con1);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxCN.Items.Add(khoa);
                    }
                }
                con1.Close();
            }
        }
    }
}
