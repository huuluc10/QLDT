using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    public partial class FrmThemGV : Form
    {
        static String imgLoc = "";
        public FrmThemGV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtHoten.Text != "" && cbboxLop.Text != "" && txtNamNhapHoc1.Text!="" && cbboxQuanHuyen.Text != "" && cbboxPhuongxa.Text!= "")
            //{
            //    //Sinhvien a = new Sinhvien();
            //    //Lop b = new Lop();
            //    //Diachi c = new Diachi();
            //    //if (a.checkCMDN(txtCMND.Text) == true)
            //    //{
            //    //    if (imgLoc == "")
            //    //    {
            //    //        a.addnew(txtHoten.Text, dateTimePicker1.Value.ToString(), cbboxGioitinh.Text, cbboxDanToc.Text, txtSDT.Text, txtCMND.Text, txtEmail.Text, cbboxHeDT.Text, txtHotenBo.Text, txtNghebo.Text, txtHotenme.Text, txtNgheme.Text, c.Maxa(cbboxPhuongxa.Text), b.Malop(cbboxLop.Text), cbboxTinhtrang.Text, int.Parse(txtNamNhapHoc1.Text));
            //    //        MessageBox.Show("Thêm Thành Công");
            //    //        this.Close();
            //    //    }
            //    //    else
            //    //    {
            //    //        try
            //    //        {
            //    //            byte[] img = null;
            //    //            FileStream fs = new System.IO.FileStream(imgLoc, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            
            //    //            BinaryReader br = new BinaryReader(fs); //Doc nhi phan
            //    //            img = br.ReadBytes((int)fs.Length);
            //    //            a.addnewIMG(txtHoten.Text, dateTimePicker1.Value.ToString(), cbboxGioitinh.Text, cbboxDanToc.Text, txtSDT.Text, txtCMND.Text, txtEmail.Text, cbboxHeDT.Text, txtHotenBo.Text, txtNghebo.Text, txtHotenme.Text, txtNgheme.Text, c.Maxa(cbboxPhuongxa.Text), b.Malop(cbboxLop.Text), cbboxTinhtrang.Text, int.Parse(txtNamNhapHoc1.Text),img);
            //    //            MessageBox.Show("Thêm Thành Công");
            //    //            this.Close();
            //    //            imgLoc = "";
            //    //        }
            //    //        catch (Exception ex)
            //    //        {
            //    //            MessageBox.Show(ex.Message);
            //    //        }
            //    //    }
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("Có vẻ như đã có SV có CMND này");
            //    //}
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng điền đầy đủ thông tin Cần thiết ...");
            //}
        }

        private void FrmThemSV_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            //Diachi dc = new Diachi();
            //DataSet ds = new DataSet();
            //ds = dc.Load();
            //cbboxTinhThanhPho.DataSource = ds.Tables[0];
            //KhoaDT khoa = new KhoaDT();
            //DataSet ds1 = new DataSet();
            //ds1 = khoa.Loadkhoa();
            //cbboxKhoa.DataSource = ds1.Tables[0];
        }

        private void cbboxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            String t;
            t = cbboxKhoa.SelectedValue.ToString();
            if (t == "System.Data.DataRowView")
            {

            }
            else
            {
                //Lop dc = new Lop();
                //DataSet ds = new DataSet();
                //ds = dc.LoadLopselect(t);
                //cbboxLop.DataSource = ds.Tables[0];
                //cbboxLop.DisplayMember = "Tenlop";
                //cbboxLop.ValueMember = "Malop";
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamNhapHoc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
