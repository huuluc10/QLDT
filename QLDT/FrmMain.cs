using System;
using System.Linq;

namespace QLDT
{
    public delegate void SendMessage(String value, String quyen);
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }
        static String quyenhan = string.Empty;
        static String username = string.Empty;
        private void SetValueFromLogin(String value, String quyen) //truyền giá trị nhận từ form frmlogin
        {
            this.trangthaidn = true;
            quyenhan = quyen;
            username = value;
            LoadLai(value, quyen);
        }

        private void SetValueFromHanhDong(bool MoThayDoiTTSV, bool MoDKHP, bool MoChamDRL) //truyền giá trị nhận từ form FrmHanhDong
        {
            MoThayDoiTTSV = MoThayDoiTTSV;
            MoDKHP = Modal;
            MoChamDRL = MoChamDRL;
            LoadLai(username, quyenhan);
        }

        private Button currentButton;
        private int tempIndex;
        private Form activeForm;
        private bool MoThayDoiTTSV;
        private bool MoDKHP;
        private bool MoChamDRL;



        public Boolean trangthaidn = false;
        public String tendn;

        public void EnableMenuAdmin()
        {
            btnHoSoSinhVien.Enabled = true;
            btnHoSoGiaoVien.Enabled = true;
            btnDiemRenLuyen.Enabled = true;
            btnDanhSachLop.Enabled = true;
            btnDanhSachKhoa.Enabled = true;
            btnQLMonHoc.Enabled = true;
            btnQLTaiKhoan.Enabled = true;
            btnHanhDong.Enabled = true;
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
            btnQLMonHoc.Enabled = false;
            btnQLTaiKhoan.Enabled = false;
            btnHanhDong.Enabled = false;
            btnQLDiem.Enabled = false;
            btnTBTL.Enabled = false;
            btnXetHocBong.Enabled = false;
        }
        public void EnableMenuSV()
        {
            btnHoSoSinhVien.Enabled = true;
            btnDiemRenLuyen.Enabled = true;
            btnNhapDiem.Enabled = false;
            btnQLMonHoc.Enabled = false;
            btnQLDiem.Enabled = true;
            btnHocPhi.Enabled = true;
            btnXemDiem.Enabled = true;
        }
        public void EnableMenuGV()
        {
            btnHoSoGiaoVien.Enabled = true;
            btnDiemRenLuyen.Enabled = true;
            btnNhapDiem.Enabled = true;
            btnXemDiem.Enabled = false;
            btnHocPhi.Enabled = false;;
        }

        private void MoCmDRL()
        {
            if (quyenhan != "1")
            {
                if (MoChamDRL && quyenhan != "4")
                    btnNhapDiem.Enabled = true;
                else
                    btnNhapDiem.Enabled = false;
            }
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
                btnDangNhap.Enabled = false;
                lblTrangThaiDN.Text = "Xin chào : " + tendn;
                thoatLogin.Text = "Thoát";
                EnableMenuAdmin();
            }

            LoadDKMo();
            MoCmDRL();
        }

        private void LoadDKMo()
        {
            var r = new Database().Select(String.Format("SELECT DIEUKHIEN FROM CHUCNANGHETHONG WHERE TENCHUCNANG = 'MOTHAYDOITTSV'"));
            MoThayDoiTTSV = Convert.ToBoolean(r["DIEUKHIEN"].ToString());
            r = new Database().Select(String.Format("SELECT DIEUKHIEN FROM CHUCNANGHETHONG WHERE TENCHUCNANG = 'MODKHP'"));
            MoDKHP = Convert.ToBoolean(r["DIEUKHIEN"].ToString());
            r = new Database().Select(String.Format("SELECT DIEUKHIEN FROM CHUCNANGHETHONG WHERE TENCHUCNANG = 'MOCHAMDRL'"));
            MoChamDRL = Convert.ToBoolean(r["DIEUKHIEN"].ToString());
        }

        public void LoadLai(String tendnhap, String quyen)
        {
            if (trangthaidn == false)
            {
                lblTrangThaiDN.Text = "Bạn Chưa Đăng Nhập";
                DisableMenuAdmin();
            }
            else
            {
                string tenquyen = string.Empty;
                switch (quyen)
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
                lblTrangThaiDN.Text = "Tài khoản: " + tendnhap + " (" + tenquyen + ")";
                lblTitle.Text = "HOME";
                thoatLogin.Text = "Thoát";
                if (quyen == "1")
                {
                    EnableMenuAdmin();
                    btnDangNhap.Text = "MỞ LỚP HỌC";
                    btnQLDiem.Text = " QUẢN LÝ ĐIỂM";
                    btnHanhDong.Text = "  HÀNH ĐỘNG";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                }
                else if (quyen == "2")
                {
                    EnableMenuGV();
                    btnQLDiem.Text = "QUẢN LÝ ĐIỂM";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                    btnDangNhap.Text = "ĐIỂM SINH VIÊN";
                }
                else
                {

                    EnableMenuSV();
                    btnDangNhap.Text = "ĐĂNG KÝ HỌC";
                    btnQLDiem.Text = "  ĐIỂM MÔN HỌC";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                }
                MoCmDRL();
            }
        }


        private void thoatLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableMenuAdmin();
            btnDangNhap.Text = "ĐĂNG NHẬP";
            lblTrangThaiDN.Text = "Bạn Chưa Đăng Nhập";
            thoatLogin.Text = string.Empty;
            lblTitle.Text = "HOME";
            btnCloseChildForm.Hide();
            panel4.Visible = false;
            linkdoimatkhau.Visible = false;

            if (activeForm != null)
            {
                activeForm.Close();
            }
            if (btnNhapDiem.Visible == true)
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
                OpenChildFormLogin(new QLDT.FrmLogin(SetValueFromLogin), sender);
            }
            else if (btnDangNhap.Text == "MỞ LỚP HỌC")
            {
                OpenChildFormLogin(new QLDT.FrmTaoLopDangKyHoc(), sender);
            }
            else if (btnDangNhap.Text == "ĐĂNG KÝ HỌC")
            {
                OpenChildFormLogin(new QLDT.FrmSinhVienDangKyHoc(username, MoDKHP), sender);
            }
            else if (btnDangNhap.Text == "ĐIỂM SINH VIÊN")
            {
                OpenChildFormLogin(new QLDT.FrmGiangVienNhapDiemMonHoc(username), sender);
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmNhapDiemRL(username, quyenhan), sender);
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


        private void btnQLDiem_Click(object sender, EventArgs e)
        {
            if (quyenhan == "3" || quyenhan == "4")
            {
                OpenChildForm(new QLDT.FrmXemDiem(username), sender);
            }
            else if (quyenhan == "2")
            {
                OpenChildForm(new QLDT.FrmQLDiem(), sender);
            }
            else if (quyenhan == "1")
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
            FrmREGISTER frm = new FrmREGISTER(username, quyenhan);
            frm.ShowDialog();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
            LoadDKMo();
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
            OpenChildForm(new QLDT.FrmHoSoSinhVien(quyenhan, username, MoThayDoiTTSV), sender);
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
            OpenChildForm(new QLDT.FrmHocPhi(quyenhan, username), sender);
        }

        private void btnXetHocBong_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmXetHocBong(), sender);
        }


        private void btnHoSoGiaoVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDT.FrmHoSoGiaoVien(quyenhan, username), sender);
        }

        private void btnHanhDong_Click(object sender, EventArgs e)
        {
            FrmHanhDong f = new FrmHanhDong(MoThayDoiTTSV, MoDKHP, MoChamDRL);
            
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnHanhDong);
            activeForm = f;
            f.TopLevel = false;
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(f);
            this.panelDesktopPane.Tag = f;
            f.Show();
            lblTitle.Text = f.Text;
            LoadDKMo();
        }
    }
}
