using DevExpress.CodeParser;
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
    public partial class FrmSinhVienDaDKMon : Form
    {
        private String msvien;
        static String MMH;
        public FrmSinhVienDaDKMon(String user)
        {
            InitializeComponent();
            this.msvien=user;

        }

        private int Makhoa(String msv)
        {
            //int makhoa;
            //using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "MaKhoaSV";
            //    cmd.Parameters.Add(new SqlParameter("@msv", msv));
            //    var result = cmd.ExecuteScalar();
            //    con.Close();
            //    if(result.ToString()=="")
            //    {
            //        makhoa = 0;
            //    }
            //    else
            //    {
            //        makhoa = (int)result;
            //    }
            //}
            //return makhoa;
            return 0;
        }


        private DataTable LoadMonHoc(int makhoa)
        {
            DataTable data = new DataTable();
            //using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "LIST_MonHocTheoKhoa";
            //    cmd.Parameters.Add(new SqlParameter("@makhoa", makhoa));
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    adapter.Fill(data);
            //    con.Close();
            //}
            return data;
        }

        private DataTable LoadLopMo(String mmh)
        {
            DataTable data = new DataTable();
            //using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "LIST_LOPHOCTHEOMONHOC";
            //    cmd.Parameters.Add(new SqlParameter("@mmh", mmh));
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    adapter.Fill(data);
            //    con.Close();
            //}
            return data;
        }


        private void FrmSinhVienDangKyHoc_Load(object sender, EventArgs e)
        {

            MMH = null;
            int mk = Makhoa(msvien);
            dataGridView2.DataSource = KetQUADANGKY(DSCACLOPHOCDANGKY(msvien));

            DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
            dataGridView2.Columns.Add(chk2);
            chk2.HeaderText = "Chọn";
            chk2.Name = "chk2";

            dataGridView3.DataSource = TongCong(dataGridView2);
        }
        private List<String> DSCACLOPHOCDANGKY(String msv)
        {
            List<String> Arr = new List<String>();
            //using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "DANHSACHLOP_DK";
            //    cmd.Parameters.Add(new SqlParameter("@masinhvien", msv));
            //    SqlDataReader rdr=cmd.ExecuteReader();
            //    while(rdr.Read())
            //    {
            //        String MH = rdr[0].ToString();
            //        Arr.Add(MH);
            //    }
            //    con.Close();
            //}
            return Arr;
        }

        private double? SoTien(String malophocphan)
        {
            double Sotien = 0;
            //double? Sotien;
            //using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "SOTIEN1TC_SINHVIENDKHOC";
            //    cmd.Parameters.Add(new SqlParameter("@malophocphan", malophocphan));
            //    var result = cmd.ExecuteScalar();
            //    con.Close();
            //    if (result.ToString()=="")
            //    {
            //        Sotien = 306500;
            //    }
            //    else
            //    {
            //        Sotien = (double)result;
            //    }
            //}
            return Sotien;
        }


        private DataTable TongCong(DataGridView datag)
        {
            DataTable data = new DataTable();
            //data.Columns.Add("Tong");
            //data.Columns.Add("TongSoTC");
            //data.Columns.Add("TongHocPhi");
            //if (datag.Rows.Count == 0)
            //{
            //    DataRow row = data.NewRow();
            //    row["Tong"] = "Tổng";
            //    row["TongSoTC"] = 0;
            //    row["TongHocPhi"] = 0;
            //    data.Rows.Add(row);
            //}
            //else
            //{
            //    int? TongSoTC=0;
            //    double? TongHocPhi=0;
            //    for (int i = 0; i < datag.Rows.Count; i++)
            //    {
            //        TongSoTC = TongSoTC + int.Parse(datag.Rows[i].Cells["SoTCG"].Value.ToString());
            //        TongHocPhi = TongHocPhi + double.Parse(datag.Rows[i].Cells["HocPhi"].Value.ToString());
            //    }
            //    DataRow row = data.NewRow();
            //    row["Tong"] = "Tổng";
            //    row["TongSoTC"] = TongSoTC;
            //    row["TongHocPhi"] = TongHocPhi;
            //    data.Rows.Add(row);
            //}
            return data;
        }




        private DataTable KetQUADANGKY(List<String> arr)
        {
            DataTable data = new DataTable();
            data.Columns.Add("MaLopHP");
            data.Columns.Add("TenLopHp");
            data.Columns.Add("TenMonHoc");
            data.Columns.Add("ThoiGian");
            data.Columns.Add("DiaDiem");
            data.Columns.Add("SiSo");
            data.Columns.Add("DaDangKy");
            data.Columns.Add("SoTC");
            data.Columns.Add("HocPhi");
            //using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            //{
            //    foreach (String item in arr)
            //    {
            //        con.Open();
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.Connection = con;
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.CommandText = "DANHSACHLOP_HIENTHIDADANGKY";
            //        cmd.Parameters.Add(new SqlParameter("@malop", item));
            //        SqlDataReader rdr = cmd.ExecuteReader();
            //        while (rdr.Read())
            //        {
            //            String MaLopHP = rdr["MaLopHP"].ToString();
            //            String TenLopHp = rdr["TenLopHp"].ToString();
            //            String TenMonHoc = rdr["TenMonHoc"].ToString();
            //            String ThoiGian = rdr["ThoiGian"].ToString();
            //            String DiaDiem = rdr["DiaDiem"].ToString();
            //            String SiSo = rdr["SiSo"].ToString();
            //            String DaDangKy = rdr["DaDangKy"].ToString();
            //            String SoTC = rdr["SoTC"].ToString();
            //            double? HP = SoTien(MaLopHP) * int.Parse(SoTC);
            //            DataRow row = data.NewRow();
            //            row["MaLopHP"] = MaLopHP;
            //            row["TenLopHp"] = TenLopHp;
            //            row["TenMonHoc"] = TenMonHoc;
            //            row["ThoiGian"] = ThoiGian;
            //            row["DiaDiem"] = DiaDiem;
            //            row["SiSo"] = SiSo;
            //            row["DaDangKy"] = DaDangKy;
            //            row["SoTC"] = SoTC;
            //            row["HocPhi"] = HP;
            //            data.Rows.Add(row);
            //        }
            //        con.Close();
            //    }
            //}
            return data;
        }


        private Boolean KIEMTRA_SINHVIENDANGKYHOC(String msv,String mamonhoc)
        {
            Boolean kq = true;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "KIEMTRA_SINHVIENDANGKYHOC";
                cmd.Parameters.Add(new SqlParameter("@msv", msv));
                cmd.Parameters.Add(new SqlParameter("@mamonhoc", mamonhoc));
                SqlDataReader rdr= cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var result = rdr["Diemchu"];
                    if (result == null || result.ToString() == "F" || result.ToString() == "D" || result.ToString() == "D+")
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

        private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView3.ClearSelection();
        }


        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }
    }
}
