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
using System.Text.RegularExpressions;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Threading;
using System.IO;

namespace QLDT
{
    public partial class FrmXetHocBong : Form
    {

        static String namHoc;
        static String hocKy;

        public FrmXetHocBong()
        {
            InitializeComponent();
        }
        static String duongdan;
        static String makhoa;
        static String hockythu;
        private void FrmXetHocBong_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int year = today.Year;
            int month = today.Month;
            if (month <= 6)
            {
                namHoc = year - 1 + " - " + year;
                hocKy = "1";
            }
            else if (month > 6)
            {
                namHoc = year - 1 + " - " + year;
                hocKy = "2";
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
                        cbboxChonkhoa.Items.Add(khoa);
                    }
                }
                con.Close();
            }
            //KhoaDT khoa = new KhoaDT();
            //DataSet ds1 = new DataSet();
            //ds1 = khoa.Loadkhoa();
            //cbboxChonkhoa.DataSource = ds1.Tables[0];
            //cbboxChonkhoa.DisplayMember = "Tenkhoa";
            //cbboxChonkhoa.ValueMember = "Makhoa";


            //cbboxKhoaHoc.DataSource = khoa.Loadkhoahoc();

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

            txtMucDiemXet.Enabled = false;
            duongdan = null;
            makhoa = null;
            hockythu = null;
        }

        

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private int SoTien1TC(String makhoa)
        {
            int Sotien = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SOTIEN_1TC";
                cmd.Parameters.Add(new SqlParameter("@makhoa", makhoa));
                var result = cmd.ExecuteScalar();
                if(result == null)
                {

                }
                else
                {
                    Sotien = int.Parse(result.ToString());
                }
                con.Close();
            }
            return Sotien;
        }

        private int SoTCTrongHocKyTheoKhoa(String makhoa,String hockythu)
        {
            int Sotinchi = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TinhSoTinChiTrongHocKy_THEOKHOA";
                cmd.Parameters.Add(new SqlParameter("@makhoa", makhoa));
                cmd.Parameters.Add(new SqlParameter("@hockythu", hockythu));
                var result = cmd.ExecuteScalar();
                if (result == null)
                {

                }
                else
                {
                    Sotinchi = int.Parse(result.ToString());
                }
                con.Close();
            }
            return Sotinchi;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(cbboxChonkhoa.Text=="" || txtMucDiemXet.Text=="")
            {
                MessageBox.Show("Hãy Lựa Chọn Đầy Đủ");
            }
            else if (IsNumber(txtMucDiemXet.Text) == false)
            {
                MessageBox.Show("Nhập Điểm Xét k hợp lệ");
            }
            else
            {
                    DataTable data = new DataTable();
                    //data.Columns.Add("MSSV");
                    //data.Columns.Add("Hoten");
                    //data.Columns.Add("Tenlop");
                    //data.Columns.Add("NAM");
                    //data.Columns.Add("HOCKY");
                    //data.Columns.Add("Tongdiem");
                    //data.Columns.Add("DTBHE10");
                    //data.Columns.Add("TongSoTCHocTrongKy");
                    //data.Columns.Add("LoaiHocBong");
                    //data.Columns.Add("SoTien");
                //using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                //{
                //    con.Open();
                //    SqlCommand cmd = new SqlCommand();
                //    cmd.Connection = con;
                //    cmd.CommandType = CommandType.StoredProcedure;
                //    cmd.CommandText = "DSSV_XETHB";
                //    cmd.Parameters.Add(new SqlParameter("@namhoc", cbboxNamHoc.Text));
                //    cmd.Parameters.Add(new SqlParameter("@khoahoc", cbboxKhoaHoc.SelectedValue.ToString()));
                //    string[] arrListStr = (cbboxNamHoc.Text).Split('_');
                //    cmd.Parameters.Add(new SqlParameter("@namhocdiemrl", arrListStr[0].ToString()));
                //    String hk;
                //    if (arrListStr[1].ToString() == "1")
                //    {
                //        hk = "Học Kỳ I";
                //    }
                //    else
                //    {
                //        hk = "Học Kỳ II";
                //    }
                //    cmd.Parameters.Add(new SqlParameter("@diemrlhocky", hk));
                //    cmd.Parameters.Add(new SqlParameter("@makhoa", cbboxChonkhoa.SelectedValue.ToString()));
                //    cmd.Parameters.Add(new SqlParameter("@diemxet", float.Parse(txtMucDiemXet.Text)));
                //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //    adapter.Fill(data);
                //    /*
                //    SqlDataReader rdr = cmd.ExecuteReader();
                //    while (rdr.Read())
                //    {
                //        String MSv = rdr["MaSV"].ToString();
                //        String Hoten = rdr["Hoten"].ToString();
                //        String Tenlop = rdr["Tenlop"].ToString();
                //        String NamHoc = rdr["NamHoc"].ToString();
                //        int? diemrl = null;
                //        double? DTBHE10 = null;
                //        double? DTBHE4 = null;
                //        int? TongTC = null;
                //        if (rdr["Tongdiem"].ToString() != "")
                //        {
                //            diemrl = (int)rdr["Tongdiem"];
                //        }
                //        if (rdr["DTBHE10"].ToString() != "")
                //        {
                //            DTBHE10 = (double)rdr["DTBHE10"];
                //        }
                //        if (rdr["DTBHE4"].ToString() != "")
                //        {
                //            String DTBHE4i = rdr["DTBHE4"].ToString();
                //            DTBHE4 = Math.Round(Convert.ToDouble(DTBHE4i), 2);
                //        }
                //        if (rdr["TongSoTCHocTrongKy"].ToString() != "")
                //        {
                //            TongTC = (int)rdr["TongSoTCHocTrongKy"];
                //        }
                //        DataRow row = data.NewRow();
                //        row["MaSV"] = MSv;
                //        row["Hoten"] = Hoten;
                //        row["Tenlop"] = Tenlop;
                //        row["NamHoc"] = NamHoc;
                //        row["Tongdiem"] = diemrl;
                //        row["DTBHE10"] = DTBHE10;
                //        row["DTBHE4"] = DTBHE4;
                //        row["TongSoTCHocTrongKy"] = TongTC;
                //        data.Rows.Add(row);
                //    }
                //    */
                //    dataGridView1.DataSource = data;
                //    con.Close();
                //}
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DSSV_DE_XETHB";
                    cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxChonkhoa.SelectedItem.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@NAMHOC", namHoc));
                    cmd.Parameters.Add(new SqlParameter("@HOCKY", hocKy));
                    cmd.Parameters.Add(new SqlParameter("@MUCDIEMXET", txtMucDiemXet.Text));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    con.Close();
                }
                dataGridView1.DataSource = data;
                makhoa = cbboxChonkhoa.SelectedItem.ToString();
                    hockythu = hocKy;
                    simpleButton3.Enabled = true;
                    simpleButton2.Enabled = true;
                    btnLoaiHocLai.Enabled = true;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
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

        private void btnXuatExCel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Ko co gi de xuat");
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

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("KHÔNG CÓ DỮ LIỆU ĐỂ LỌC");
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    String MSV = dataGridView1.Rows[i].Cells["MSSV"].Value.ToString();
                    String NamHoc = dataGridView1.Rows[i].Cells["NAM"].Value.ToString();
                    if (loaisvdiemduoi5(MSV,NamHoc,makhoa) == false)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i = i - 1;
                    }
                }
                MessageBox.Show("Đã loại tất cả sinh viên có môn học thi điểm dưới 5.5");
                simpleButton2.Enabled = false;
                checkBox2.Checked = true;
            }
        }

        private Boolean loaisvdiemduoi5(String msv, String namhoc, String makhoamonhoc)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DIEMTHISV_HOCKY";
                cmd.Parameters.Add(new SqlParameter("@MSSV", msv));
                cmd.Parameters.Add(new SqlParameter("@NAM", namhoc));
                cmd.Parameters.Add(new SqlParameter("@HOCKY", hocKy));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int xet = Int32.Parse(rdr["XET"].ToString());
                    if (xet >= 1)
                    {
                        return false;
                    }
                }
                con.Close();
            }
            return true;
        }

        private Boolean loaisvdiemduoi5TCQP(String msv, String namhoc)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TONGTC_DRLSV_HOCKY";
                cmd.Parameters.Add(new SqlParameter("@MSSV", msv));
                cmd.Parameters.Add(new SqlParameter("@NAM", namhoc));
                cmd.Parameters.Add(new SqlParameter("@HOCKY", hocKy));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["TONGTC"].ToString() != "" && rdr["DIEM"].ToString() != "")
                    {
                        int TONGTC = (int)rdr["TONGTC"];
                        int Diem = (int)rdr["DIEM"];
                        if (TONGTC < 15)
                        {
                            return false;
                        }
                        if (Diem < 70)
                        {
                            return false;
                        }
                    }
                }
                con.Close();
            }
            return true;
        }


        private Boolean loaisvhoclai(String msv, String namhoc)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LOCSVHOCLAI";
                cmd.Parameters.Add(new SqlParameter("@MSSV", msv));
                cmd.Parameters.Add(new SqlParameter("@NAM", namhoc));
                cmd.Parameters.Add(new SqlParameter("@HOCKY", hocKy));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    float xet = float.Parse(rdr["XET"].ToString());
                    if (xet < 5)
                    {
                        return false;
                    }
                }
                con.Close();
            }
            return true;
        }



        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("KHÔNG CÓ DỮ LIỆU ĐỂ LỌC");
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    String MSV = dataGridView1.Rows[i].Cells["MSSV"].Value.ToString();
                    String NamHoc = dataGridView1.Rows[i].Cells["NAM"].Value.ToString();
                    if (loaisvdiemduoi5TCQP(MSV, NamHoc) == false)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i = i - 1;
                    }
                }
                MessageBox.Show("Đã loại tất cả sinh viên có số tín chỉ < 15 và DRL < 70");
                simpleButton3.Enabled = false;
                checkBox3.Checked = true;
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("KHÔNG CÓ DỮ LIỆU ĐỂ LỌC");
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    String MSV = dataGridView1.Rows[i].Cells["MSSV"].Value.ToString();
                    String NamHoc = dataGridView1.Rows[i].Cells["NAM"].Value.ToString();
                    if (loaisvhoclai(MSV, NamHoc) == false)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i = i - 1;
                    }
                }
                MessageBox.Show("Đã loại tất cả sinh viên có học phần bị học lại");
                btnLoaiHocLai.Enabled = false;
                checkBox1.Checked = true;
            }
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
            }
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Ko Có Cái Gì Hết :(");
            }
            else
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Khi Bạn Thiết Lập Danh Sách Là Ko thể Sửa Được. Bạn chắc chắn chưa?", "Lập Danh Sách", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (thongbao == DialogResult.OK)
                {

                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
