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
    public partial class FrmThemSV : Form
    {
        static String imgLoc = "";
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public FrmThemSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text !="" && txtHoten.Text != "" && cbboxGioitinh.SelectedItem != "" && dateTimePicker1.Text != "" && txtQuocGia.Text != "" && cbboxDanToc.SelectedItem != "" && cbboxTonGiao.SelectedItem != "" && txtSDT.Text != "" && txtCCCD.Text != "" && txtEmail.Text != "" && cbboxKhoa.SelectedItem != "" && cbboxLop.SelectedItem != "" && cbbCN.SelectedItem != "" && txtDiaChi.Text != "")
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new System.IO.FileStream(imgLoc, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs); //Doc nhi phan
                    img = br.ReadBytes((int)fs.Length);

                    SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                    con.Open();
                    String sql = "INSERT INTO SINHVIEN (\r\n        MSSV, HOTEN,\r\n        GIOITINH, NGAYSINH,\r\n        DIACHI, MAKHOA,\r\n        MACHUYENNGANH, MALOP,\r\n        SOCCCD, TONGIAO,\r\n        DANTOC, QUOCGIA,\r\n        EMAIL, ANHSV, DIENTHOAI\r\n    )VALUES(\r\n        @MSSV, @HOTEN,\r\n        @GIOITINH, @NGAYSINH,\r\n        @DIACHI, @MAKHOA,\r\n        @MACHUYENNGANH, @MALOP,\r\n        @SOCCCD, @TONGIAO,\r\n        @DANTOC, @QUOCGIA,\r\n        @EMAIL, @ANHSV,@DIENTHOAI\r\n    );";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@MSSV", SqlDbType.Char, 8);
                    cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@NGAYSINH",SqlDbType.Date);
                    cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 30);
                    cmd.Parameters.Add("@DANTOC", SqlDbType.NVarChar, 15);
                    cmd.Parameters.Add("@DIENTHOAI", SqlDbType.Char, 10);
                    cmd.Parameters.Add("@SOCCCD", SqlDbType.Char, 12);
                    cmd.Parameters.Add("@MAKHOA", SqlDbType.VarChar, 8);
                    cmd.Parameters.Add("@MACHUYENNGANH", SqlDbType.Char, 10);
                    cmd.Parameters.Add("@TONGIAO", SqlDbType.NVarChar, 20);
                    cmd.Parameters.Add("@QUOCGIA", SqlDbType.NVarChar, 15);
                    cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 30);
                    cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@MALOP", SqlDbType.VarChar, 12);
                    cmd.Parameters.Add(new SqlParameter("@ANHSV", img));

                    cmd.Parameters["@MSSV"].Value = txtMSSV.Text;
                    cmd.Parameters["@HOTEN"].Value = txtHoten.Text;
                    cmd.Parameters["@GIOITINH"].Value = cbboxGioitinh.SelectedItem;
                    cmd.Parameters["@NGAYSINH"].Value = dateTimePicker1.Value.ToString();
                    cmd.Parameters["@DANTOC"].Value = cbboxDanToc.SelectedItem;
                    cmd.Parameters["@DIENTHOAI"].Value = txtSDT.Text;
                    cmd.Parameters["@SOCCCD"].Value = txtCCCD.Text;
                    cmd.Parameters["@MAKHOA"].Value = cbboxKhoa.SelectedItem;
                    cmd.Parameters["@MACHUYENNGANH"].Value = cbbCN.SelectedItem;
                    cmd.Parameters["@TONGIAO"].Value = cbboxTonGiao.SelectedItem;
                    cmd.Parameters["@QUOCGIA"].Value = txtQuocGia.Text;
                    cmd.Parameters["@EMAIL"].Value = txtEmail.Text;
                    cmd.Parameters["@DIACHI"].Value = txtDiaChi.Text;
                    cmd.Parameters["@MALOP"].Value = cbboxLop.SelectedItem;

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Thêm Thành Công");
                    this.Close();
                    imgLoc = "";
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

        private void FrmThemSV_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            con.Open();

            string queryKhoa = "SELECT DISTINCT MAKHOA FROM KHOA ORDER BY MAKHOA";
            SqlCommand cmd = new SqlCommand(queryKhoa, con);
            using (SqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string khoa = saReader.GetString(0);
                    cbboxKhoa.Items.Add(khoa);
                }
            }

            string queryLop = String.Format("SELECT DISTINCT MALOP FROM LOPQUANLY ORDER BY MALOP");
            cmd = new SqlCommand(queryLop, con);
            using (SqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string lop = saReader.GetString(0);
                    cbboxLop.Items.Add(lop);
                }
            }

            string queryCN = String.Format("SELECT DISTINCT MACHUYENNGANH FROM CHUYENNGANH\r\nORDER BY MACHUYENNGANH");
            cmd = new SqlCommand(queryCN, con);
            using (SqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string chuyenNganh = saReader.GetString(0);
                    cbbCN.Items.Add(chuyenNganh);
                }
            }

            con.Close();
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

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Student Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picstudent.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
