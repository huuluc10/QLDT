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
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLDT
{
    public partial class FrmTBTL : Form
    {
        public FrmTBTL()
        {
            InitializeComponent();

        }
        static String duongdan = null;
        private static String Trangthai=null;
        private void FrmTBTL_Load(object sender, EventArgs e)
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
                        cbboxChonkhoa.Items.Add(khoa);
                    }
                }
                con1.Close();
            }

            Trangthai = null;
            duongdan = null;
            simpleButton1.Enabled = true;
            simpleButton1.Text = "XEM ĐIỂM";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cbboxchonlop.Text == "")
            {
                MessageBox.Show("Trống Lớp OR Năm Học...");
            }
            else
            {
                //List<CustomParameter> lst = new List<CustomParameter>();
                //lst.Add(new CustomParameter()
                //{
                //    key = "@TENKHOA",
                //    value = cbboxChonkhoa.SelectedItem.ToString()
                //});
                //lst.Add(new CustomParameter()
                //{
                //    key = "@MALOP",
                //    value = cbboxchonlop.SelectedItem.ToString()
                //});
                //var chk = new Database().ExeCute("XEMDTBTL", lst);
                DataTable data = new DataTable();
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "XEMDTBTL";
                    cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxChonkhoa.SelectedItem.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@MALOP", cbboxchonlop.SelectedItem.ToString()));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    con.Close();
                }
                dataGridView1.DataSource = data; 
                simpleButton1.Enabled = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            Trangthai = "Xem Điểm";
            simpleButton1.Text = "XEM ĐIỂM";
            btnXemDiem.Enabled = false;
            btnNhapSuaDiem.Enabled = true;
            
            btnXemDiem.BackColor = System.Drawing.Color.Red;
            btnNhapSuaDiem.BackColor = System.Drawing.Color.Empty;
        }

        private void btnChonDuongDan_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Title = "Select Location";
                dlg.Filter = "Excel Worksheets|*.xls";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    duongdan = dlg.FileName.ToString();
                    lblDuongDanFile.Text = duongdan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void export2Excel(DataGridView g, String duongdan)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan);
            obj.ActiveWorkbook.Saved = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Ko co gi de xuat Excel");
            }
            else
            {
                if (duongdan == null)
                {
                    MessageBox.Show("Bạn Hãy Chọn Nơi Lưu File");
                }
                else
                {
                    if (File.Exists(duongdan))
                    {
                        MessageBox.Show("Đã Có Tên File Này Rồi. Bạn Nên Chọn Tên Khác");
                    }
                    else
                    {
                        FrmLoad a = new FrmLoad(dataGridView1, duongdan);
                        a.Show();
                        duongdan = null;
                        lblDuongDanFile.Text = "";
                    }
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

        private void cbboxchonlop_SelectedValueChanged(object sender, EventArgs e)
        {
            String t;
            t = cbboxchonlop.SelectedItem.ToString();
            if (t == "System.Data.DataRowView")
            {

            }
            else
            {
                simpleButton1.Enabled = true;
            }
        }
    }
}
