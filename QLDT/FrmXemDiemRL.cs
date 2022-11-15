using DevExpress.CodeParser;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using app = Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel;
//using Syncfusion.XlsIO;
using DataTable = System.Data.DataTable;
using DevExpress.Spreadsheet;

namespace QLDT
{
    public partial class FrmXemDiemRL : Form
    {
        private String quyenhan;
        private String username;
        public FrmXemDiemRL(String quyenhan, String MaSV)
        {
            InitializeComponent();
            this.quyenhan = quyenhan;
            this.username = MaSV;
        }

        static String duongdan = null;
        public Boolean click = false;

        private void FrmXemDiemRL_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            duongdan = null;
            click = false;
            if (quyenhan != "1")
            {
                groupBox1.Visible = false;
                dataGridView1.Enabled = false;
                btnLoadDanhSach.Enabled = false;
                DataTable data = new DataTable();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SVXEMDRL";
                    cmd.Parameters.Add(new SqlParameter("@MSSV", username));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    con.Close();
                }
                dataGridView1.DataSource = data;
                dataGridView1.ReadOnly = true;
            }
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
                        cbboxChonkhoa.Items.Add(khoa);
                    }
                }
                con.Close();
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

        private void cbboxChonlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String t;
            t = cbboxChonlop.Text;
            if (t == "System.Data.DataRowView")
            {

            }
            else
            {
                //DiemRL drl = new DiemRL();
                //DataTable ds = new DataTable();
                //if (drl.KiemtratontaiSV(drl.Malop(t)) == true)
                //{
                //    ds = drl.Danhsachnamhoc(drl.NamNhapHoc(drl.Malop(t)));
                //    cbboxNamHoc.DataSource = ds;
                //    cbboxNamHoc.DisplayMember = "Nam";
                //    cbboxNamHoc.ValueMember = "Nam";
                //}
                //else
                //{
                //    MessageBox.Show("Không tồn tại sinh viên trong lớp nên không thể cập nhật Mới các niên khóa học tập");
                //}
            }
        }

        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            if (cbboxChonlop.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn lớp cần hiển thị");
            }
            else
            {
                if (radioButtonHK1.Checked)
                {
                    DataTable data = new DataTable();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "XEMDIEMHOCKY1";
                        cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxChonkhoa.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@MALOP", cbboxChonlop.SelectedItem.ToString()));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                    click = true;
                }
                else if (radioButtonHK2.Checked)
                {
                    DataTable data = new DataTable();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "XEMDIEMHOCKY2";
                        cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxChonkhoa.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@MALOP", cbboxChonlop.SelectedItem.ToString()));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                    click = true;
                }
                else if (radioButtonCaNam.Checked)
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataTable data = new DataTable();
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "XEMDRL";
                        cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxChonkhoa.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@MALOP", cbboxChonlop.SelectedItem.ToString()));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                    click = false;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn học kỳ nào đó cần hiển thị");
                }
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
                    String MSV = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    String Hoten = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    String Lop = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    String Namhoc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    String Hocky = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    String Tongdiem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                }
            }
        }

        //private void copyAlltoClipboard()
        //{
        //    dataGridView1.SelectAll();
        //    DataObject dataObj = dataGridView1.GetClipboardContent();
        //    if (dataObj != null)
        //        Clipboard.SetDataObject(dataObj);
        //}

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


                        //copyAlltoClipboard();
                        //Microsoft.Office.Interop.Excel.Application xlexcel;
                        //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                        //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                        //object misValue = System.Reflection.Missing.Value;
                        //xlexcel = new Excel.Application();
                        //xlexcel.Visible = true;
                        //xlWorkBook = xlexcel.Workbooks.Add(misValue);
                        //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                        //Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                        //CR.Select();
                        //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                        //using (ExcelEngine excelEngine = new ExcelEngine())
                        //{
                        //    IApplication application = excelEngine.Excel;
                        //    application.DefaultVersion = ExcelVersion.Excel2016;
                        //    IWorkbook workbook = application.Workbooks.Create(1);
                        //    IWorksheet worksheet = workbook.Worksheets[0];
                        //    //Adding text to a cell
                        //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                        //    {
                        //        worksheet.Range[1, i].Text = dataGridView1.Columns[i - 1].HeaderText;
                        //    }

                        //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        //    {
                        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        //        {
                        //            worksheet.Range[i + 2, j + 1].Text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        //        }
                        //    }
                        //    //Saving the workbook to disk in XLSX format
                        //    Stream excelstream = File.Create(Path.GetFullPath(@"MyExcelFile.xlsx"));
                        //    workbook.SaveAs(excelstream);
                        //    excelstream.Dispose();
                        //}


                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnChonDuongDan_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Title = "Select Location";
                dlg.Filter = "Excel Worksheets|*.xlsx";
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
                        cbboxChonlop.Items.Add(LOP);
                    }
                }
                con.Close();
            }
        }
    }
}
