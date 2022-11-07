using QLDTLUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    public delegate void SendMessage (String value,String quyen);
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
        }
        static String quyenhan = "";
        static String username = "";
        private void SetValue(String value,String quyen) //truyền giá trị nhận từ form frmlogin
        {
            //this.lblTrangThaiDN.Text = "Xin chào : " + value;
            this.trangthaidn = true;
            quyenhan = quyen;
            username = value;
            LoadLai(value,quyen);
        }

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public Boolean trangthaidn = false;
        public String tendn;

        public void EnableMenuAdmin()
        {
            btnHoSoSinhVien.Enabled = true;
            btnHoSoGiaoVien.Enabled = true;
            btnDiemRenLuyen.Enabled = true;
            btnDanhSachLop.Enabled = true;
            btnDanhSachKhoa.Enabled = true;
            btnThongKe.Enabled = true;
            btnQLMonHoc.Enabled = true;
            btnQLTaiKhoan.Enabled = true;
            btnQLGiangVien.Enabled = true;
            btnQLDiem.Enabled = true;
            btnTBTL.Enabled = true;
            btnNhapDiem.Enabled = true;
            btnXetHocBong.Enabled = true;
            btnHocPhi.Enabled = true;
        }

        public void DisableMenuAdmin()
        {
            btnHoSoSinhVien.Enabled = false;
            btnHoSoGiaoVien.Enabled = false;
            btnDiemRenLuyen.Enabled = false;
            btnDanhSachLop.Enabled = false;
            btnDanhSachKhoa.Enabled = false;
            btnThongKe.Enabled = false;
            btnQLMonHoc.Enabled = false;
            btnQLTaiKhoan.Enabled = false;
            btnQLGiangVien.Enabled = false;
            btnQLDiem.Enabled = false;
            btnTBTL.Enabled = false;
            btnXetHocBong.Enabled = false;
        }
        public void EnableMenuSV()
        {
            btnHoSoSinhVien.Enabled = true;
            btnHoSoGiaoVien.Enabled = true;
            btnDiemRenLuyen.Enabled = true;
            btnNhapDiem.Enabled = false;
            btnQLMonHoc.Enabled = false;
            btnQLDiem.Enabled = true;
            btnHocPhi.Enabled = true;
        }
        public void EnableMenuGV()
        {
            btnDiemRenLuyen.Enabled = true;
            btnNhapDiem.Enabled = true;
            btnXemDiem.Enabled = true;
            btnQLGiangVien.Enabled = true;
            btnQLGiangVien.Text = "GIẢNG VIÊN";
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisnableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    //panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisnableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void OpenChildFormLogin(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void Reset()
        {
            DisnableButton();
            lblTitle.Text = "HOME";
            /*
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            */
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            if (trangthaidn == false)
            {
                lblTrangThaiDN.Text = "Bạn Chưa Đăng Nhập";
                DisableMenuAdmin();
            }
            else
            {
                btnDangNhap.Enabled=false;
                lblTrangThaiDN.Text = "Xin chào : " + tendn;
                thoatLogin.Text = "Thoát";
                EnableMenuAdmin();
            }
            
        }

        public void LoadLai(String tendnhap,String quyen)
        {
            if (trangthaidn == false)
            {
                lblTrangThaiDN.Text = "Bạn Chưa Đăng Nhập";
                DisableMenuAdmin();
            }
            else
            {
                //btnDangNhap.Enabled = false;
                //btnDangNhap.Hide();
                string tenquyen = "";
                switch(quyen)
                {
                    case "1":
                        tenquyen = "Quản trị viên";
                        break;
                    case "2":
                        tenquyen = "Giảng viên";
                        break;
                    default:
                        tenquyen = "Sinh viên";
                        break;

                }
                lblTrangThaiDN.Text = "Tài khoản: " + tendnhap +" ("+ tenquyen + ")";
                lblTitle.Text = "HOME";
                thoatLogin.Text = "Thoát";
                if (quyen == "1")
                {
                    EnableMenuAdmin();
                    btnDangNhap.Text = "MỞ LỚP HỌC";
                    btnQLDiem.Text = " QUẢN LÝ ĐIỂM";
                    btnQLGiangVien.Text = "  QL GIẢNG VIÊN";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                }
                else if(quyen == "2")
                {
                    btnDangNhap.Text = "";
                    EnableMenuGV();
                    btnQLDiem.Text = "QL ĐIỂM";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                    btnDangNhap.Text = "ĐIỂM SV";
                }
                else
                {
                    
                    EnableMenuSV();
                    btnDangNhap.Text = "ĐĂNG KÝ HỌC";
                    btnQLDiem.Text = "  ĐIỂM MÔN HỌC";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                }
            }
        }


        private void thoatLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableMenuAdmin();
            btnDangNhap.Text = "ĐĂNG NHẬP";
            lblTrangThaiDN.Text = "Bạn Chưa Đăng Nhập";
            thoatLogin.Text = "";
            lblTitle.Text = "HOME";
            btnCloseChildForm.Hide();
            panel4.Visible = false;
            linkdoimatkhau.Visible = false;

            if (activeForm != null)
            {
                activeForm.Close();
            }
            if(btnNhapDiem.Visible==true)
            {
                btnNhapDiem.Visible = false;
                btnXemDiem.Visible = false;
            }
            Reset();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (btnDangNhap.Text == "ĐĂNG NHẬP")
            {
                OpenChildFormLogin(new QLDT.FrmLogin(SetValue), sender);
            }
            else if(btnDangNhap.Text == "MỞ LỚP HỌC")
            {
                OpenChildFormLogin(new QLDT.FrmTaoLopDangKyHoc(), sender);
            }
            else if(btnDangNhap.Text == "ĐĂNG KÝ HỌC")
            {
                OpenChildFormLogin(new QLDT.FrmSinhVienDangKyHoc(username), sender);
            }
            else if(btnDangNhap.Text == "ĐIỂM SV")
            {
                //OpenChildFormLogin(new QLDT.FrmGiangVienNhapDiemMonHoc(username), sender);
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmNhapDiemRL(), sender);
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmXemDiemRL(quyenhan, username), sender);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQLGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmQLTaiKhoan(), sender);
        }

        private void btnQLGiangVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmQLGiangVien(username, quyenhan), sender);
        }

        private void btnQLDiem_Click(object sender, EventArgs e)
        {
            if(quyenhan == "3" || quyenhan == "4")
            {
                OpenChildForm(new QLDT.FrmXemDiem(username), sender);
            }
            else if(quyenhan == "2")
            {
                OpenChildForm(new QLDT.FrmQLDiem(), sender);
            }
            else if(quyenhan == "1")
            {
                OpenChildForm(new QLDT.FrmQLDiem(), sender);
            }
        }

        private void btnTBTL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmTBTL(), sender);
        }

        private void linkdoimatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmREGISTER frm = new FrmREGISTER(username,quyenhan);
            frm.ShowDialog();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ:\n" +
                "Nguyễn Hữu Lực  https://www.facebook.com/Lwc.Kirk\n" +
                "Nguyễn Lê Tâm https://www.facebook.com/letam2002pk\n" +
                "Phạm Phương Nam https://www.facebook.com/nam.phamphuong.792\n" +
                "Võ Thanh Hào https://www.facebook.com/profile.php?id=100009445792852\n" +
                "Trần Cao Phong https://www.facebook.com/caophong.t\n" +
                "Ngô Tuấn Lam https://www.facebook.com/LamAds.0347693333");

        }

        private void btnDanhSachLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmLop(), sender);
        }

        private void btnDanhSachKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmKhoa(), sender);
        }

        private void btnQLMonHoc_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmMonHoc(), sender);
        }

        private void btnHoSoSinhVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmHoSoSinhVien(quyenhan, username), sender);
        }

        private void btnDiemRenLuyen_Click_1(object sender, EventArgs e)
        {
            if (btnNhapDiem.Visible == false)
            {
                btnXemDiem.Visible = true;
                btnNhapDiem.Visible = true;
            }
            else
            {
                btnNhapDiem.Visible = false;
                btnXemDiem.Visible = false;
            }
        }

        private void btnHocPhi_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXetHocBong_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmXetHocBong(), sender);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmThongKe(), sender);
        }

        private void btnHoSoGiaoVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmHoSoGiaoVien(quyenhan, username), sender);
        }
    }
}
