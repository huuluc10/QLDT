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
    public partial class FrmGiangVienNhapDiemMonHoc : Form
    {
        private String magiangvien;
        private static String duongdan = null;
        static String MMH;
        static String NamHocCuaLopHocPhan;
        public FrmGiangVienNhapDiemMonHoc(String mgv)
        {
            InitializeComponent();
            this.magiangvien = mgv;
        }


        private String MAMONHOCTRONGLOPHOCPHAN(String malophocphan)
        {
            String kq = null;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MAMONHOCTRONGLOPHOCPHAN";
                cmd.Parameters.Add(new SqlParameter("@malophocphan", malophocphan));
                var result = cmd.ExecuteScalar();
                con.Close();
                if (result != null)
                {
                    kq = result.ToString();
                }
            }
            return kq;
        }



        private void FrmGiangVienNhapDiemMonHoc_Load(object sender, EventArgs e)
        {
            NamHocCuaLopHocPhan = null;
            MMH = null;
            duongdan = null;
            using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
            {
                con1.Open();
                string queryKhoa = "DANHSACH_CACLOPDANGDAY '" + magiangvien +"'";
                SqlCommand cmd = new SqlCommand(queryKhoa, con1);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        comboBox1.Items.Add(khoa);
                    }
                }
                con1.Close();
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
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
        private DataTable LoadSVTRONGLOP(String malophocphan)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DANHSACHSINHVIENTRONGLOPHOCPHAN";
                cmd.Parameters.Add(new SqlParameter("@MAKHOAHOC", malophocphan));
                cmd.Parameters.Add(new SqlParameter("@MSGV", magiangvien));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }


        private void btnloadsv_Click(object sender, EventArgs e)
        {
            if(cbboxLopHocDangDay.Text=="")
            {
                MessageBox.Show("Empty");
            }
            else
            {
                
                MMH = cbboxLopHocDangDay.SelectedItem.ToString();
                dataGridView1.DataSource = LoadSVTRONGLOP(MMH);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Empty");
            }
            else
            {
                int chk = 1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    String MSV = dataGridView1.Rows[i].Cells["MSSV"].Value.ToString();
                    double? Diem1 = null;
                    double? Diem2 = null;
                    double? DiemThi = null;
                    double? DiemTongKet = null;
                    double? DiemHe4 = null;
                    String DiemChu = null;
                    String DanhGia = null;
                    if (dataGridView1.Rows[i].Cells["DiemKT1"].Value.ToString() != "")
                    {
                        Diem1 = double.Parse(dataGridView1.Rows[i].Cells["DiemKT1"].Value.ToString());
                    }
                    if (dataGridView1.Rows[i].Cells["DiemKT2"].Value.ToString() != "")
                    {
                        Diem2 = double.Parse(dataGridView1.Rows[i].Cells["DiemKT2"].Value.ToString());
                    }
                    if (dataGridView1.Rows[i].Cells["DiemKT3"].Value.ToString() != "")
                    {
                        DiemThi = double.Parse(dataGridView1.Rows[i].Cells["DiemKT3"].Value.ToString());
                    }
                    if (Diem1 != null && Diem2 != null && DiemThi != null)
                    {
                        if (Diem1 > 10 || Diem2 > 10 || DiemThi > 10 || Diem1 < 0 || Diem2 < 0 || DiemThi < 0)
                        {
                            MessageBox.Show("Cảnh Báo. Điểm Nhập Ko Hợp Lệ: MSV:" + MSV);
                            break;
                        }
                    }
                    List<CustomParameter> lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MSSV",
                        value = MSV
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MAKHOAHOC",
                        value = MMH
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@DIEMQUATRINH",
                        value = (dataGridView1.Rows[i].Cells["DiemKT1"].Value.ToString()).Replace(",",".")
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@DIEMGIUAKY",
                        value = (dataGridView1.Rows[i].Cells["DiemKT3"].Value.ToString()).Replace(",", ".")
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@DIEMCUOIKY",
                        value = (dataGridView1.Rows[i].Cells["DiemKT3"].Value.ToString()).Replace(",", ".")
                    });
                    chk = new Database().ExeCute("chamdiem", lstPara);
                }
                
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            cbboxLopHocDangDay.Items.Clear();
            cbboxLopHocDangDay.Text = "";
            using (SqlConnection con1 = new SqlConnection(ConnectionString.connectionString))
            {
                con1.Open();
                string queryKhoa = "DSKHOAHOCTHEOMON N'" + comboBox1.SelectedItem.ToString() + "', '" + magiangvien + "'";
                SqlCommand cmd = new SqlCommand(queryKhoa, con1);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string khoa = saReader.GetString(0);
                        cbboxLopHocDangDay.Items.Add(khoa);
                    }
                }
                con1.Close();
            }
        }
    }
}
