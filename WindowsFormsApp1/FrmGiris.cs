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
using DevExpress.XtraBars;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        private void btnyönetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMENLER on TBL_AYARLAR.AYARLARID=TBL_OGRETMENLER.OGRTID where OGRTTC=@p1 and OGRTSIFRE=@p2");
            komut.Parameters.AddWithValue("@p1",maskedTextBox1.Text); 
            komut.Parameters.AddWithValue("@p2",textEdit2.Text);


          
        }


        FrmModulAna frm1=new FrmModulAna();

        private void btnögretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMENLER on TBL_AYARLAR.AYARLARID=TBL_OGRETMENLER.OGRTID where OGRTTC=@p1 and OGRTSIFRE=@p2");
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textEdit2.Text);

        }

        private void btnögrenci_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMENLER on TBL_AYARLAR.AYARLARID=TBL_OGRETMENLER.OGRTID where OGRTTC=@p1 and OGRTSIFRE=@p2");
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textEdit2.Text);

        }
    }

#if true

#endif
}
