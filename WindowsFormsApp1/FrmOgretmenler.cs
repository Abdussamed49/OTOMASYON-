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
using DevExpress.XtraRichEdit.Layout.Export;
using DevExpress.Utils.MVVM;
using System.IO;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace WindowsFormsApp1
{
    public partial class FrmOgretmenler : Form
    {
        public FrmOgretmenler()
        {
            InitializeComponent();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_OGRETMENLER ", bgl.baglanti());
            da.Fill(dt);    
            gridControl1.DataSource = dt;   

        }

        void ilekle()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr =komut.ExecuteReader();
            while (dr.Read())
            {
                CmbİL.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
       
        }

        void bransgetir()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_BRANSLARR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void temizle()
        {

            TxtID.Text = "";
            TxtAD.Text = "";
            TxtSOYAD.Text = "";
            MskTC.Text = "";
            MskTELEFON.Text = "";
            CmbİL.Text = "";
            CmbİLCE.Text = "";
            cmbBrans.Text = "";
            TxtMAIL.Text = "";
            RchADRES.Text = "";
            PcrRESİM.ImageLocation = "";
        }


        private void FrmOgretmenler_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            bransgetir();
            
        }

        private void CmbİL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbİLCE.Properties.Items.Clear();
            CmbİLCE.Text = "";
            SqlCommand komut = new SqlCommand("select * from TBL_ILCELER where il_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbİL.SelectedIndex);
            SqlDataReader dr =komut.ExecuteReader();    
            while (dr.Read())
            {
                CmbİLCE.Properties.Items.Add(dr[2]);
            }
            bgl.baglanti().Close(); 
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRETMENLER (OGRTAD,OGRTSOYAD,OGRTTC,OGRTTEL,OGRTMAIL,OGRTIL,OGRTILCE,OGRTADRES,OGRTBRANS,OGRTFOTO) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskTELEFON.Text);
            komut.Parameters.AddWithValue("@p5", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p6", CmbİL.Text);
            komut.Parameters.AddWithValue("@p7", CmbİLCE.Text);
            komut.Parameters.AddWithValue("@p8", RchADRES.Text);
            komut.Parameters.AddWithValue("@p9", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("PERSONEL EKLENDİ" , "BİLGİ OLARAK ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["OGTERID"].ToString();
                TxtAD.Text = dr["OGRTAD"].ToString();
                TxtSOYAD.Text = dr["OGRTSOYAD"].ToString() ;
                MskTC.Text = dr["OGRTTC"].ToString();
                MskTELEFON.Text = dr["OGRTTEL"].ToString();
                CmbİL.Text = dr["OGRTIL"].ToString();
                CmbİLCE.Text = dr["OGRTILCE"].ToString();
                cmbBrans.Text = dr["OGRTBRANS"].ToString();
                TxtMAIL.Text = dr["OGRTMAIL"].ToString();
                RchADRES.Text = dr["OGRTADRES"].ToString();
                yeniyol= "C:\\Users\\abdus\\OneDrive\\Masaüstü\\c# otomasyon\\C# OTOMASYON\\WindowsFormsApp1" + "\\resimler" + dr["OGRTFOTO"].ToString();
                PcrRESİM.ImageLocation = yeniyol;
                
            }
        }

        public string yeniyol;


        private void BtnRESİM_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*png;*nef; | TÜM DOSYALAR | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\abdus\\OneDrive\\Masaüstü\\c# otomasyon\\C# OTOMASYON\\WindowsFormsApp1" + "\\resimler" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu,yeniyol);
            PcrRESİM.ImageLocation = yeniyol;

        }

        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRETMENLER set OGRTAD=@p1,OGRTSOYAD=@p2,OGRTTC=@p3,OGRTTEL=@p4,OGRTMAIL=@p5,OGRTIL=@p6,OGRTILCE=@p7,OGRTADRES=@p8,OGRTBRANS=@p9,OGRTFOTO=@p10 where OGTERID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskTELEFON.Text);
            komut.Parameters.AddWithValue("@p5", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p6", CmbİL.Text);
            komut.Parameters.AddWithValue("@p7", CmbİLCE.Text);
            komut.Parameters.AddWithValue("@p8", RchADRES.Text);
            komut.Parameters.AddWithValue("@p9", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@P11", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("PERSONEL GÜNCELLENDİ", "BİLGİ  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnSİL_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_OGRETMENLER where OGTERID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("PERSONEL SİLİNDİ", "BİLGİ  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnTEMIZLE_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
