using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    public partial class FrmThemGV : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public FrmThemGV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMSGV.Text != "" && txtHoten.Text != "" && cbboxGioitinh.SelectedItem != "" && dateTimePicker1.Text != "" && txtQuocGia.Text != "" && cbboxDanToc.SelectedItem != "" && cbboxTonGiao.SelectedItem != "" && txtSDT.Text != "" && txtCCCD.Text != "" && txtEmail.Text != "" && txtDiaChi.Text != "")
            {
                try
                {
                    using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
                    {
                        con1.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con1;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "THEMMOIGV";
                        cmd.Parameters.Add("@MSSV", SqlDbType.Char, 8);
                        cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50);
                        cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date);
                        cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 30);
                        cmd.Parameters.Add("@DANTOC", SqlDbType.NVarChar, 15);
                        cmd.Parameters.Add("@DIENTHOAI", SqlDbType.Char, 10);
                        cmd.Parameters.Add("@SOCCCD", SqlDbType.Char, 12);
                        cmd.Parameters.Add("@TONGIAO", SqlDbType.NVarChar, 20);
                        cmd.Parameters.Add("@QUOCGIA", SqlDbType.NVarChar, 15);
                        cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 30);
                        cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100);

                        cmd.Parameters["@MSGV"].Value = txtMSGV.Text;
                        cmd.Parameters["@HOTEN"].Value = txtHoten.Text;
                        cmd.Parameters["@GIOITINH"].Value = cbboxGioitinh.SelectedItem;
                        cmd.Parameters["@NGAYSINH"].Value = dateTimePicker1.Value.ToString();
                        cmd.Parameters["@DANTOC"].Value = cbboxDanToc.SelectedItem;
                        cmd.Parameters["@DIENTHOAI"].Value = txtSDT.Text;
                        cmd.Parameters["@SOCCCD"].Value = txtCCCD.Text;
                        cmd.Parameters["@TONGIAO"].Value = cbboxTonGiao.SelectedItem;
                        cmd.Parameters["@QUOCGIA"].Value = txtQuocGia.Text;
                        cmd.Parameters["@EMAIL"].Value = txtEmail.Text;
                        cmd.Parameters["@DIACHI"].Value = txtDiaChi.Text;
                        cmd.ExecuteNonQuery();
                        con1.Close();
                    }
                    MessageBox.Show("Thêm Thành Công");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Cần thiết ...");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmThemGV_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
