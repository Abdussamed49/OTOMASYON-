using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmModulAna : Form
    {
        public FrmModulAna()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm1.IsDisposed)
            {


                frm2 = new FrmOgrenciler();
                frm2.MdiParent = this; ;
                frm2.Show();
            }
        }



        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        FrmOgretmenler frm1;
        FrmOgrenciler frm2;
        FrmVeliler frm3;
        FrmAyarlar frm4;

        private void BtnOGRETMEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm1 == null || frm1.IsDisposed)
            {


                frm1 = new FrmOgretmenler();
                frm1.MdiParent = this; ;
                frm1.Show();
            }
        }

        private void BtnVeliler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {


                frm3 = new FrmVeliler();
                frm3.MdiParent = this; ;
                frm3.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm1.IsDisposed)
            {


                frm4 = new FrmAyarlar();
                frm4.MdiParent = this; ;
                frm4.Show();

            }
        }
    }
}
