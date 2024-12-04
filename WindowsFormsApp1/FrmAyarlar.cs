using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraBars;
using DevExpress.XtraLayout.Resizing;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace WindowsFormsApp1
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();  

        //ADO.NET ÖĞRETMEN ŞİFRE BİLGİLERİ

        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1=new SqlDataAdapter("Execute AyarlarOgretmenler",bgl.baglanti());    
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;  

        }



        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        //ADO.NET LOOKUPEDİT ARACI VERİ GETİRME

        public string yeniyol;


        void ogretmenlistesi()
        {
            DataTable dt2=new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("select OGRTID,(OGRAD+''+OGRTSOYAD) as 'OGRT ADSOYAD',OGRTBRANS from TBL_OGRETMENLER", bgl.baglanti());
            dr.Fill(dt2);
           lookUpEdit1.Properties.ValueMember = "OGRTID";
            lookUpEdit1.Properties.DisplayMember = "OGRTADSOYAD";
            lookUpEdit1.Properties.NullText =" ÖĞRETMEN SEÇİNİZ";
            lookUpEdit1.Properties.DataSource = dt2;


        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenlistesi();

        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                TxtOgrtId.Text = dr["AYARLARID"].ToString();
                lookUpEdit1.Text = dr["OGRTADSOYAD"].ToString();
                MskOgrtTc.Text = dr["OGRTTC"].ToString();
                yeniyol= yeniyol + dr["OGRFOTO"];
                PİCTUREEDİT1.Image = Image.FromFile(yeniyol);

            }
        }
    }
}
