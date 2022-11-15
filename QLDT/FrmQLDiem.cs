using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLDT
{
    public partial class FrmQLDiem : Form
    {
        public FrmQLDiem()
        {
            InitializeComponent();
        }
        static String trangthai;
        static String chucnang;
        private int hocky = 1;
        static String TMH;
        static int? MaDiemXoa = null;
        private String NamHoc = null;
        private static String duongdan = null;
        private void FrmQLDiem_Load(object sender, EventArgs e)
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
            using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
            {
                con1.Open();
                string queryKhoa = "SELECT DISTINCT NAM FROM GIANGDAY ORDER BY NAM";
                SqlCommand cmd = new SqlCommand(queryKhoa, con1);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxNamHoc.Items.Add(khoa);
                    }
                }
                con1.Close();
            }
            duongdan = null;
        }

        private void cbboxNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbboxMonHoc.DataSource = null;
        }

        private void radioButtonHK1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHK1.Checked)
            {
                hocky = 1;
            }
            else
            {
                hocky = 2;
            }
            cbboxMonHoc.Items.Clear();
            cbboxMonHoc.Text = "";

            if (cbboxChonkhoa.Text != "" && cbboxNamHoc.Text != "")
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();

                    string query = String.Format("LOADMONHOCTHEOKHOANAMHOCKY N'" + cbboxChonkhoa.SelectedItem.ToString() + "', '" + (cbboxNamHoc.SelectedItem.ToString()).Substring(0, 11) + "', '" + hocky + "'");
                    SqlCommand cmd = new SqlCommand(query, con);

                    using (SqlDataReader saReader = cmd.ExecuteReader())
                    {
                        while (saReader.Read())
                        {
                            string LOP = saReader.GetString(0);
                            cbboxMonHoc.Items.Add(LOP);
                        }
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đủ tên khoa và năm học");
            }
        }

        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            if (radioButtonXEMDIEM.Checked)
            {
                if (cbboxMonHoc.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Chọn Môn Học");
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.ColumnCount = 8;
                    dataGridView1.Columns[0].Name = "MSSV";
                    dataGridView1.Columns[0].DataPropertyName = "MSSV";
                    dataGridView1.Columns[1].Name = "Họ Tên";
                    dataGridView1.Columns[1].DataPropertyName = "HOTEN";
                    dataGridView1.Columns[2].Name = "NĂM HOC";
                    dataGridView1.Columns[2].DataPropertyName = "NAM";
                    dataGridView1.Columns[3].Name = "HỌC KỲ";
                    dataGridView1.Columns[3].DataPropertyName = "HOCKY";
                    dataGridView1.Columns[4].Name = "ĐIỂM QT";
                    dataGridView1.Columns[4].DataPropertyName = "DIEMQUATRINH";
                    dataGridView1.Columns[5].Name = "Điểm GK";
                    dataGridView1.Columns[5].DataPropertyName = "DIEMGIUAKY";
                    dataGridView1.Columns[6].Name = "Điểm CK";
                    dataGridView1.Columns[6].DataPropertyName = "DIEMCUOIKY";
                    dataGridView1.Columns[7].Name = "Điểm Tổng Kết";
                    dataGridView1.Columns[7].DataPropertyName = "DIEMTONGKET";

                    DataTable data = new DataTable();
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.CommandText = "XEMDIEMSV_THEO_KHOA_LOP_MON_NAM_KY N'@TENKHOA', '@MALOP', N'@TENMONHOC', '@NAM', '@HOCKY'";
                        cmd.CommandText = "XEMDIEMSV_THEO_KHOA_LOP_MON_NAM_KY";
                        cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxChonkhoa.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@MALOP", cbboxChonlop.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@TENMONHOC", cbboxMonHoc.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@NAM", cbboxNamHoc.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@HOCKY", hocky));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                    trangthai = "Xem Điểm";
                    dataGridView1.ReadOnly = true;

                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            else if (radioButtonNHAPDIEM.Checked)
            {
                if (cbboxMonHoc.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Chọn Môn Học");
                }
                else
                {

                    dataGridView1.DataSource = null;
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].Name = "MSSV";
                    dataGridView1.Columns[0].DataPropertyName = "MSSV";
                    dataGridView1.Columns[1].Name = "Họ Tên";
                    dataGridView1.Columns[1].DataPropertyName = "HOTEN";
                    dataGridView1.Columns[2].Name = "Năm Học";
                    dataGridView1.Columns[2].DataPropertyName = "NAM";
                    dataGridView1.Columns[3].Name = "Học kỳ";
                    dataGridView1.Columns[3].DataPropertyName = "HOCKY";
                    dataGridView1.Columns[4].Name = "Điểm QT";
                    dataGridView1.Columns[4].DataPropertyName = "DIEMQUATRINH";
                    dataGridView1.Columns[5].Name = "Điểm GK";
                    dataGridView1.Columns[5].DataPropertyName = "DIEMGIUAKY";
                    dataGridView1.Columns[6].Name = "Điểm CK";
                    dataGridView1.Columns[6].DataPropertyName = "DIEMCUOIKY";
                    DataTable data = new DataTable();
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.CommandText = "XEMDIEMSV_THEO_KHOA_LOP_MON_NAM_KY N'@TENKHOA', '@MALOP', N'@TENMONHOC', '@NAM', '@HOCKY'";
                        cmd.CommandText = "DSSVSUADIEM_THEO_KHOA_MON_LOP_NAM_KY";
                        cmd.Parameters.Add(new SqlParameter("@TENKHOA", cbboxChonkhoa.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@MALOP", cbboxChonlop.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@TENMONHOC", cbboxMonHoc.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@NAM", cbboxNamHoc.SelectedItem.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@HOCKY", hocky));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);
                        con.Close();
                    }
                    dataGridView1.DataSource = data;
                    trangthai = "Nhập Điểm";
                    TMH = cbboxMonHoc.SelectedItem.ToString();
                    dataGridView1.ReadOnly = false;
                    String hk = "";
                    if (radioButtonHK1.Checked)
                    {
                        hk = "1";
                    }
                    else if (radioButtonHK2.Checked)
                    {
                        hk = "2";
                    }
                    NamHoc = cbboxNamHoc.Text;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                }
            }
            else
            {
                MessageBox.Show("HÃY LỰA CHỌN NHẬP ĐIỂM HOẶC XEM ĐIỂM");
            }
        }

    
        private void radioButtonNHAPDIEM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (trangthai == "Xem Điểm")
            {
                if (dataGridView1.Rows.Count == 0)
                {

                }
                else
                {
                    MaDiemXoa = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
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

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void btnDuongDan_Click(object sender, EventArgs e)
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

        private void btnXuatExcel_Click_1(object sender, EventArgs e)
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
                        FrmLoad f = new FrmLoad(dataGridView1, duongdan);
                        f.Show();
                        duongdan = null;
                        lblDuongDanFile.Text = "";
                    }
                }
            }
        }

        private void cbboxChonkhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            cbboxChonlop.Items.Clear();
            cbboxChonlop.Text = "";
            cbboxMonHoc.Items.Clear();
            cbboxMonHoc.Text = "";

            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                string query = String.Format("SELECT DISTINCT MALOP FROM LOPQUANLY WHERE MAKHOA = (SELECT MAKHOA FROM KHOA WHERE TENKHOA = N'" + cbboxChonkhoa.SelectedItem.ToString() + "') ORDER BY MALOP");
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (trangthai == "Nhập Điểm")
            {
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        String MSSV = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        String HOTEN = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        double? Diem1 = null;
                        double? Diem2 = null;
                        double? DiemThi = null;
                        double? DiemTongKet = null;
                        String NH = null;

                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() != "")
                        {
                            NH = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        }
                        else
                        {
                            NH = NamHoc;
                        }

                        if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "")
                        {
                            hocky = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        }

                        if (dataGridView1.Rows[i].Cells[4].Value.ToString() != "")
                        {
                            Diem1 = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        }
                        if (dataGridView1.Rows[i].Cells[5].Value.ToString() != "")
                        {
                            Diem2 = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        }
                        if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "")
                        {
                            DiemThi = double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                        }

                        if (Diem1 != null && Diem2 != null && DiemThi != null)
                        {
                            if (Diem1 > 10 || Diem2 > 10 || DiemThi > 10  || Diem1 < 0 || Diem2 < 0 || DiemThi < 0)
                            {
                                MessageBox.Show("Cảnh Báo. Điểm Nhập Ko Hợp Lệ: MSV:" + MSSV);
                                break;
                            }
                        }
                        List<CustomParameter> lstPara = new List<CustomParameter>();
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@MSSV",
                            value = MSSV
                        });
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@TENKHOA",
                            value = cbboxChonkhoa.SelectedItem.ToString()
                        });
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@MALOP",
                            value = cbboxChonlop.SelectedItem.ToString()
                        });
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@TENMONHOC",
                            value = cbboxMonHoc.SelectedItem.ToString()
                        });
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@NAM",
                            value = (cbboxNamHoc.SelectedItem.ToString()).Substring(0,11)
                        });
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@HOCKY",
                            value = hocky.ToString()
                        }); ;
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@DIEM1",
                            value = (Diem1.ToString()).Replace(",", ".")
                        });
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@DIEM2",
                            value = (Diem2.ToString()).Replace(",", ".")
                        });
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@DIEM3",
                            value = (DiemThi.ToString()).Replace(",", ".")
                        });
                        var chk = new Database().ExeCute("SUADIEMSV_THEO_KHOA_MON_LOP_NAM_KY", lstPara);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chức Năng Này chỉ hoạt động khi bạn chọn Nhập Điểm");
            }
        }
    }
}
