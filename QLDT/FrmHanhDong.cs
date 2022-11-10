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

        private void FrmHanhDong_Load(object sender, EventArgs e)
        {

        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            MoDKHP = !MoDKHP;
            this.Hide();
        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            MoThayDoiTTSV = !MoThayDoiTTSV;
            this.Hide();
        }

        private void btnDRL_Click(object sender, EventArgs e)
        {
            MoChamDRL = !MoChamDRL;
            this.Hide();
        }
    }
}
