using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    public class Database
    {
        private string connectionString = @"Data Source=DESKTOP-5MM4CTB;Initial Catalog = QLDT; Trusted_Connection=True";   //khai báo chuỗi kết nối
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()   //hàm khởi tạo 
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Kết nối lỗi: "+e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> lstPara)   //hàm truy xuất dữ liệu từ bảng sinh viên
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();       //Nếu kết nối chưa đóng thì đóng để không lỗi
                conn.Open();
                cmd = new SqlCommand(sql, conn);    //nội dung sql  được truyền vào
                cmd.CommandType = CommandType.StoredProcedure;      //set command type cho cmd
                foreach (var p in lstPara)      //truyền tham số vào cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;  //kiểu trả về là 1 database
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + e.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();        //mở kết nối
                cmd = new SqlCommand(sql,conn); //truyền giá trị vào cmd
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());   //thực thi câu lệnh
                return dt.Rows[0];  //trả về kết quả
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + e.Message);
                    return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public int ExeCute(string sql, List<CustomParameter> lstPara)       //hàm để thực thi thêm, sửa, xóa
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                cmd = new SqlCommand(sql, conn);    //thực thi câu lệnh sql
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)      //gán cách tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();  //lấy kết quả thực thi truy vấn
                return (int)rs;    //trả về kết quả
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + e.Message);
                return -100;
            }finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
