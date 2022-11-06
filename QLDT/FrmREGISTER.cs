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
    public partial class FrmREGISTER : Form
    {
        private String _name;
        private String _value;
        String oldPass;
        Database db = new Database();
        public FrmREGISTER(String user, String value)
        {
            InitializeComponent();
            _name = user;
            _value = value;
        }

        private void getDataFromSQL()
        {
            
            var data = db.Select("SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = '" + txbTaiKhoan.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS");
            oldPass = data["MATKHAU"].ToString();
        }

        private void FrmREGISTER_Load(object sender, EventArgs e)
        {
            //txtMatKhauCu.MaxLength = 20;
            //txtmatkhaumoi.MaxLength = 20;
            //txtNhapLaiMKmoi.MaxLength = 20;
            txbTaiKhoan.Text = _name;
            getDataFromSQL();
            if (_value == "1")
            {
                txtMatKhauCu.Enabled = false;
                txtMatKhauCu.Text = oldPass;
            } else
            {
                txbTaiKhoan.Enabled = false;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "" || txtmatkhaumoi.Text == "" || txtNhapLaiMKmoi.Text == "")
            {
                MessageBox.Show("Hãy Nhập Đầy Đủ");
            }
            else
            {
                if (txtMatKhauCu.Text == oldPass)
                {
                    if (txtmatkhaumoi.Text == txtNhapLaiMKmoi.Text)
                    {
                        //Cập nhật
                        #region truyền tham số
                        List<CustomParameter> lstPara = new List<CustomParameter>()
                        {
                            new CustomParameter()
                            {
                                key = "@TENDANGNHAP",
                                value = txbTaiKhoan.Text
                            },
                            new CustomParameter()
                            {
                                key = "@MATKHAUMOI",
                                value = txtmatkhaumoi.Text
                            }
                        };
                        #endregion
                        var rs = db.ExeCute("DOIMATKHAU", lstPara);  //truyền câu lệnh sql và các tham số
                        if (rs == 1)      //nếu thực thi thành công
                        {
                            MessageBox.Show("Đổi Mật Khẩu Thành Công");
                            this.Dispose();     //đóng form sau khi thực hiện thành công
                        }
                        else        //thực thi lỗi
                        {
                            MessageBox.Show("Thực hiện thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới ko trùng khớp");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                }
            }
        }
    }
}
