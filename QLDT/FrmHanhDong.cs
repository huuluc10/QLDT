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
    
    public partial class FrmHanhDong : Form
    {
        private bool moThayDoiTTSV;
        private bool moDKHP;
        private bool moChamDRL;

        public bool MoThayDoiTTSV { get => moThayDoiTTSV; set => moThayDoiTTSV = value; }
        public bool MoDKHP { get => moDKHP; set => moDKHP = value; }
        public bool MoChamDRL { get => moChamDRL; set => moChamDRL = value; }

        public FrmHanhDong(bool MoThayDoiTTSV, bool MoDKHP, bool MoChamDRL)
        {
            InitializeComponent();
            this.MoChamDRL = MoChamDRL;
            this.MoThayDoiTTSV = MoThayDoiTTSV;  
            this.MoDKHP = MoDKHP;
        }
        private void Refresh()
        {
            if (MoThayDoiTTSV)
            {
                btnTTSV.Text = "Đóng Thay Đổi Thông Tin Sinh Viên";
            }
            else
            {
                btnTTSV.Text = "Mở Thay Đổi Thông Tin Sinh Viên";
            }
            if (MoDKHP)
            {
                btnDKHP.Text = "Đóng Đăng Ký Học Phần";
            }
            else
            {
                btnDKHP.Text = "Mở Đăng Ký Học Phần";
            }
            if (MoChamDRL)
            {
                btnDRL.Text = "Đóng Chấm Điểm Rèn Luyện";
            }
            else
            {
                btnDRL.Text = "Mở Chấm Điểm Rèn Luyện";
            }
        }
        private void FrmHanhDong_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            MoDKHP = !MoDKHP;
            var r = new Database().UpdateData(String.Format("UPDATE CHUCNANGHETHONG SET DIEUKHIEN = '" + MoDKHP + "' FROM CHUCNANGHETHONG WHERE TENCHUCNANG = 'MODKHP'"));
            if (MoDKHP)
            {
                MessageBox.Show("Đã mở đăng ký học phần cho sinh viên");
            }
            else
            {
                MessageBox.Show("Đã đóng đăng ký học phần cho sinh viên");
            }
            Refresh();
        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            MoThayDoiTTSV = !MoThayDoiTTSV;
            var r = new Database().UpdateData(String.Format("UPDATE CHUCNANGHETHONG SET DIEUKHIEN = '" + MoThayDoiTTSV + "' FROM CHUCNANGHETHONG WHERE TENCHUCNANG = 'MOTHAYDOITTSV'"));
            if (MoThayDoiTTSV)
            {
                MessageBox.Show("Đã mở thay đổi thông tin cho sinh viên");
            }
            else
            {
                MessageBox.Show("Đã đóng thay đổi thông tin cho sinh viên");
            }
            Refresh();
        }

        private void btnDRL_Click(object sender, EventArgs e)
        {
            MoChamDRL = !MoChamDRL;
            var r = new Database().UpdateData(String.Format("UPDATE CHUCNANGHETHONG SET DIEUKHIEN = '" + MoChamDRL + "' FROM CHUCNANGHETHONG WHERE TENCHUCNANG = 'MOCHAMDRL'"));
            if (MoChamDRL)
            {
                MessageBox.Show("Đã mở thời gian chấm điểm rèn luyện");
            }
            else
            {
                MessageBox.Show("Đã đóng thời gian chấm điểm rèn luyện");
            }
            Refresh();
        }
    }
}
