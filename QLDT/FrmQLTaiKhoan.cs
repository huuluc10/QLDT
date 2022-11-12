using DevExpress.ClipboardSource.SpreadsheetML;
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

namespace QLDT
{
    public partial class FrmQLTaiKhoan : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public FrmQLTaiKhoan()
        {
            InitializeComponent();
        }
        static String trangthai = "";
        static String Lop= "";
        static String khoa = "";

        private void FrmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            con.Open();

            string queryKhoa = "SELECT TENQUYEN FROM QUYEN ORDER BY MAQUYEN";
            SqlCommand cmd = new SqlCommand(queryKhoa, con);
            using (SqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string quyen = saReader.GetString(0);
                    cbboxloaitaikhoan.Items.Add(quyen);
                    cbbQuyen.Items.Add(quyen);
                }
            }
            con.Close();
        }

        private void LoadDSTK(String loaiTK)
        {
            var query = String.Format("XEMTAIKHOAN N'" + loaiTK + "'");
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                adapter.Fill(data);
                con.Close();
            }
            dataGridView1.DataSource = data;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[4, i] = linkCell;
            }
        }

        private void btncapnhattaikhoan_Click(object sender, EventArgs e)
        {
            if (cbboxloaitaikhoan.Text == "")
            {
                MessageBox.Show("Hãy Chọn Loại Tài Khoản Hiển Thị");
            }
            else
            {
                LoadDSTK(cbboxloaitaikhoan.SelectedItem.ToString());
            }
        }

        private void btnThemTKQL_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.Text == "" || txtMAQTV.Text == "" || txthoten.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ User và Pass/Nhập Lại Pass");
            }
            else
            {
                String sql = "THEMQTV";
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@MAQTV",
                    value = txtMAQTV.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@HOTENQTV",
                    value = txthoten.Text
                });
                
                lstPara.Add(new CustomParameter()
                {
                    key = "@MATKHAU",
                    value = txtmatkhau.Text
                });
                var rs = new Database().ExeCute(sql, lstPara);  //truyền câu lệnh sql và các tham số
                if (rs >= 1)      //nếu thực thi thành công
                {
                    MessageBox.Show("Tạo Tài Khoản Thành Công");
                }
                else        //thực thi lỗi
                {
                    MessageBox.Show("Tạo Tài Khoản thất bại");
                }
                cbboxloaitaikhoan.Text = "Quản trị viên";
                LoadDSTK("Quản trị viên");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {

            }
            else
            {
                if (e.ColumnIndex == 4)
                {
                    string Task = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    if (Task == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            String tenDangNhap = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                            String loaiTK = cbboxloaitaikhoan.SelectedItem.ToString();
                            String sql = "";
                            var rs = 0;
                            if (loaiTK == "Quản trị viên")
                            {
                                sql = "XOAQTV";
                                List<CustomParameter> lstPara = new List<CustomParameter>();
                                lstPara.Add(new CustomParameter()
                                {
                                    key = "@MAQTV",
                                    value = tenDangNhap
                                });
                                rs = new Database().ExeCute(sql, lstPara);
                            } 
                            else if (loaiTK == "Giáo viên")
                            {
                                sql = "XOAGV";
                                List<CustomParameter> lstPara = new List<CustomParameter>();
                                lstPara.Add(new CustomParameter()
                                {
                                    key = "@MSGV",
                                    value = tenDangNhap
                                });
                                rs = new Database().ExeCute(sql, lstPara);
                            } 
                            else
                            {
                                sql = "XOASV";
                                List<CustomParameter> lstPara = new List<CustomParameter>();
                                lstPara.Add(new CustomParameter()
                                {
                                    key = "@MSSV",
                                    value = tenDangNhap
                                });
                                rs = new Database().ExeCute(sql, lstPara);
                            }
                              //truyền câu lệnh sql và các tham số
                            if (rs >= 1)      //nếu thực thi thành công
                            {
                                MessageBox.Show("Thực hiện thành công");
                            }
                            else        //thực thi lỗi
                            {
                                MessageBox.Show("Thực hiện thất bại");
                            }
                            cbboxloaitaikhoan.Text = loaiTK;
                            LoadDSTK(loaiTK);
                        }
                    }
                }
         
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //GiangVien a = new GiangVien();
            //if(radioButtonSinhVien.Checked)
            //{
            //    if(cbboxLocLop.Text=="")
            //    {
            //        MessageBox.Show("Vui lòng chọn lớp để lọc sinh viên");
            //    }
            //    else
            //    {
            //        dataGridView2.DataSource = a.DanhSachTatCaSVThemTaiKhoan(cbboxLocLop.SelectedValue.ToString());
            //        trangthai = "Sinh Viên";
            //        Lop = cbboxLocLop.SelectedValue.ToString();
            //    }
            //}
            //else if(radioButtonGV.Checked)
            //{
            //    dataGridView2.DataSource = a.DanhSachTatCaGVThemTaiKhoan(cbboxLocKhoa.SelectedValue.ToString());
            //    trangthai = "Giảng Viên";
            //    khoa = cbboxLocKhoa.SelectedValue.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn Cần Chọn Sinh Viên Hoặc Giảng Viên trước Khi Cập Nhật Danh Sách");
            //}
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void btThemTKSV_Click_1(object sender, EventArgs e)
        {
            if (txtMSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản");
            }
            else
            {
                String sql = "DOITTTK";
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@TENDANGNHAP",
                    value = txtMSV.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MATKHAUMOI",
                    value = txtMKMSV.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@TENQUYEN",
                    value = cbbQuyen.SelectedItem.ToString()
                });
                var rs = new Database().ExeCute(sql, lstPara);  //truyền câu lệnh sql và các tham số
                if (rs >= 1)      //nếu thực thi thành công
                {
                    MessageBox.Show("Thực hiện thành công");
                }
                else        //thực thi lỗi
                {
                    MessageBox.Show("Thực hiện thất bại");
                }
                cbboxloaitaikhoan.Text = cbbQuyen.SelectedItem.ToString();
                LoadDSTK(cbbQuyen.SelectedItem.ToString());
            } 
                
        }
    }
}
