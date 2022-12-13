using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.Xpo.DB.Helpers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDT
{
    public partial class FrmSinhVienDangKyHoc : Form
    {
        private String msvien;
        private bool MoDKHP;
        static String MMH;
        public FrmSinhVienDangKyHoc(string msvien, bool moDKHP)
        {
            InitializeComponent();
            this.msvien = msvien;
            MoDKHP = moDKHP;
        }

        private string Makhoa(String msv)
        {
            string makhoa;
            //using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "XDKHOASV";
            //    cmd.Parameters.Add(new SqlParameter("@MSSV", msv));
            //    var result = cmd.ExecuteScalar();
            //    con.Close();
            //    if (result.ToString() == "")
            //    {
            //        makhoa = null;
            //    }
            //    else
            //    {
            //        makhoa = (string)result;
            //    }
            //}
            var r = new Database().Select(String.Format("XDKHOASV '" + msv + "'"));
            makhoa = r["MAKHOA"].ToString();
            return makhoa;
        }

        private string MaMon(string tenmon)
        {
            string mamon = null;
            var r = new Database().Select(String.Format("XDMAMON N'" + tenmon + "'"));
            mamon = r["MAMONHOC"].ToString();
            return mamon;
        }

        private DataTable LoadLopMo(String mmh)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LIST_LOPHOCTHEOMONHOC";
                cmd.Parameters.Add(new SqlParameter("@TENMONHOC", cbboxMonHoc.SelectedItem.ToString()));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }


        private void FrmSinhVienDangKyHoc_Load(object sender, EventArgs e)
        {
            if(MoDKHP)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                label3.Visible = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                label3.Visible = true;
            }
            MMH = null;
            string mk = Makhoa(msvien);
            dataGridView2.DataSource = KetQUADANGKY();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(chk);
            chk.HeaderText = "Chọn";
            chk.Name = "chk";


            DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
            dataGridView2.Columns.Add(chk2);
            chk2.HeaderText = "Chọn";
            chk2.Name = "chk2";

            dataGridView3.DataSource = TongCong(dataGridView2);

            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                string sql = String.Format("HIENTHIMONTHEOLOPMO '" + mk.ToString() + "'");
                SqlCommand cmd = new SqlCommand(sql, con);
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        cbboxMonHoc.Items.Add(saReader.GetString(0));
                    }
                }
                con.Close();
            }
        }


        private DataTable TongCong(DataGridView datag)
        {
            DataTable data = new DataTable();
            data.Columns.Add("TongSoTC");
            data.Columns.Add("TongHocPhi");
            if (datag.Rows.Count == 0)
            {
                DataRow row = data.NewRow();
                row["TongSoTC"] = 0;
                row["TongHocPhi"] = 0;
                data.Rows.Add(row);
            }
            else
            {
                int? TongSoTC = 0;
                double? TongHocPhi = 0;
                for (int i = 0; i < datag.Rows.Count; i++)
                {
                    TongSoTC = TongSoTC + int.Parse(datag.Rows[i].Cells["dataGridViewTextBoxColumn5"].Value.ToString());
                    TongHocPhi = TongHocPhi + double.Parse(datag.Rows[i].Cells["HocPhi"].Value.ToString());
                }
                DataRow row = data.NewRow();
                row["TongSoTC"] = TongSoTC;
                row["TongHocPhi"] = TongHocPhi;
                data.Rows.Add(row);
            }
            return data;
        }


        private DataTable KetQUADANGKY()
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DANHSACHLOP_HIENTHIDADANGKY";
                cmd.Parameters.Add(new SqlParameter("@MSSV", msvien));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cbboxMonHoc.Text == "")
            {
                MessageBox.Show("Empty");
            }
            else
            {
                MaMon(cbboxMonHoc.SelectedItem.ToString());
                dataGridView1.DataSource = LoadLopMo(cbboxMonHoc.SelectedItem.ToString());
                MMH = MaMon(cbboxMonHoc.SelectedItem.ToString());
            }
        }

        private void Dangky(String msv,String MLH)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DangKY_LopHoc";
                    cmd.Parameters.Add(new SqlParameter("@MSSV", msv));
                    cmd.Parameters.Add(new SqlParameter("@MAKHOAHOC", MLH));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void HuyDangky(String msv, String MLH)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HuyDangKY_LopHoc";
                cmd.Parameters.Add(new SqlParameter("@MSSV", msv));
                cmd.Parameters.Add(new SqlParameter("@MAKHOAHOC", MLH));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Ko Có Gì Hết");
            }
            else
            {
                String LopHoc = null;
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["chk"].Value == null)
                        {

                        }
                        else
                        {

                            bool checkedCell = (bool)dataGridView1.Rows[i].Cells["chk"].Value;
                            if (checkedCell == true)
                            {
                                LopHoc = dataGridView1.Rows[i].Cells["MaLop"].Value.ToString();
                            }
                        }
                        if (i == dataGridView1.Rows.Count - 1)
                        {
                            if (KIEMTRA_SINHVIENDANGKYHOC(msvien, LopHoc) == true)
                            {
                                Dangky(msvien, LopHoc);
                                MessageBox.Show("ĐK Thành Công. Bạn Hãy Kiểm Tra Ở Kết Quả Đăng Ký");
                                dataGridView2.DataSource = KetQUADANGKY();
                                dataGridView3.DataSource = TongCong(dataGridView2);
                                button2_Click(null, null);
                            } 
                            else
                                MessageBox.Show("Lớp học này bạn đã đăng ký");
                        }
                    }
                }
                catch (Exception)
                {
                    throw;;
                }
            }
        }

        private Boolean KIEMTRA_SINHVIENDANGKYHOC(String msv,String mamonhoc)
        {
            Boolean kq = true;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "KIEMTRA_SINHVIENDANGKYHOC '" + msv + "', '" + mamonhoc +"'";
                SqlDataReader rdr= cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var result1 = rdr["SLDK"];
                    if ((int)result1 < 1)
                    {
                        kq= true;
                    }
                    else
                    {
                        kq = false;
                    }
                }
                con.Close();
            }
            return kq;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
            }
            else
            {
                String LopHoc = null;
                int check = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells["chk2"].Value == null)
                    {

                    }
                    else
                    {
                        bool checkedCell = (bool)dataGridView2.Rows[i].Cells["chk2"].Value;
                        if (checkedCell == true)
                        {
                            check++;
                            LopHoc = dataGridView2.Rows[i].Cells["Malop2"].Value.ToString();
                        }
                    }
                    if (i == dataGridView2.Rows.Count - 1)
                    {
                        if (check > 1)
                        {
                            MessageBox.Show("Bạn Chỉ Có Thể Hủy Từng Lớp");
                        }
                        else if (check == 0)
                        {
                            MessageBox.Show("Bạn chưa Chọn Lớp.");
                        }
                        else
                        {
                            HuyDangky(msvien, LopHoc);
                            MessageBox.Show("Hủy Thành Công");
                            dataGridView2.DataSource = KetQUADANGKY();
                            dataGridView3.DataSource = TongCong(dataGridView2);
                            button2_Click(null, null);
                        }
                    }
                }
            }
        }

        private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView3.ClearSelection();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }
    }
}
