using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    
    public partial class FrmLogin : Form
    {
        public SendMessage send;
        public FrmLogin()
        {
            InitializeComponent();
        }
        public FrmLogin(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0 && txtPassword.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập User và Password");
                this.txtUsername.Focus();

            }
            else if (txtUsername.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập User");
                this.txtUsername.Focus();
            }
            else if (txtPassword.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập Password");
                this.txtPassword.Focus();
            }
            else
            {
                List<CustomParameter> lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@TENDANGNHAP",
                        value = txtUsername.Text
                    },
                    new CustomParameter()
                    {
                        key = "@MATKHAU",
                        value = txtPassword.Text
                    },
                };
                var rs = new Database().SelectData("DANGNHAP", lstPara);
                if (rs.Rows.Count > 0)
                {
                    //MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    var data = new Database().Select("SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = '" + txtUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS");
                    string maquyen = data["MAQUYEN"].ToString();
                    this.send(txtUsername.Text, maquyen);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại!\nTài khoản mật khẩu không đúng", "Thông báo");
                }
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //txtUsername.MaxLength = 15;
            //txtPassword.MaxLength = 15;
        }
    }
}
