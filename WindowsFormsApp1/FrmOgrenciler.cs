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
using DevExpress.Utils.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        string yol = Application.StartupPath + "/images/";
        // resimleri bu klasorde tut projeni nereyede götürsen çalışır


        void Listele()
        {

        // 5.SINIF 
            DataTable dt1=new DataTable();
            SqlDataAdapter da1= new SqlDataAdapter("Execute OgrenciVeli5", bgl.baglanti());
            da1.Fill(dt1);
            GrdCtrl5.DataSource =dt1;

            // 6.SINIF
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute OgrenciVeli6", bgl.baglanti());
            da1.Fill(dt1);
            GrdCtrl6.DataSource = dt1;

            //7.SINIF
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute OgrenciVeli7", bgl.baglanti());
            da1.Fill(dt1);
            GrdCtrl7.DataSource = dt1;

            //8.SINIF
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Execute OgrenciVeli8", bgl.baglanti());
            da1.Fill(dt1);
            GrdCtrl8.DataSource = dt1;




        }

        void velilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select VELIID,(VELIANNE+'| '+VELIBABA) AS 'VELIANNEBABA' from TBL_VELILER", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "VELIID";
            lookUpEdit1.Properties.DisplayMember = "VELIANNEBABA";
            lookUpEdit1.Properties.DataSource = dt;

        }


        void sehirekle()
        {
            SqlCommand komut =new SqlCommand("select * from TBL_ILLER",bgl.baglanti());
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                CmbİL.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();

        }

        void temizle()
        {
            TxtID.Text = "";
            TxtAD.Text = "";
            TxtSOYAD.Text = "";
            MskOgrenciNo.Text = "";
            MskTC.Text = "";
            RdBtnErkek.Checked = false;
            RdBtnBayan.Checked = false;
            CmbSınıf.Text = "";
            CmbİL.Text = "";
            CmbİLCE.Text = "";
            dateEdit1.Text = "";
            RchADRES.Text = "";
            pictureEdit1.Text = "";

        }


        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            Listele();
            sehirekle();
            temizle();
            velilistesi();

        }

        private void CmbİL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbİLCE.Properties.Items.Clear();
            CmbİLCE.Text = "";



            SqlCommand komut = new SqlCommand("select * from TBL_ILCELER where il_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbİL.SelectedIndex + 1);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                CmbİLCE.Properties.Items.Add(dr[2]);    
            }
            bgl.baglanti().Close();
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);

            if (dr!=null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAD.Text = dr["OGRAD"].ToString();
                TxtSOYAD.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSınıf.Text = dr["OGRSINIF"].ToString();

                if (dr["OGRCINSIYET"].ToString()=="E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                { 

                RdBtnBayan.Checked = true;
                }
                CmbİL.Text = dr["OGRIL"].ToString();
                CmbİLCE.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchADRES.Text = dr["OGRADRES"].ToString();
                // yeniyol = "C:\\Users\\abdus\\OneDrive\\Masaüstü\\c# otomasyon\\C# OTOMASYON\\WindowsFormsApp1" + "\\resimler" + dr["OGRFOTO"].ToString();
                // pictureEdit1.Image = Image.FromFile(yeniyol);
                pictureBox1.ImageLocation = yol + dr["OGRFOTO"];
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAD.Text = dr["OGRAD"].ToString();
                TxtSOYAD.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSınıf.Text = dr["OGRSINIF"].ToString();

                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {

                    RdBtnBayan.Checked = true;
                }
                CmbİL.Text = dr["OGRIL"].ToString();
                CmbİLCE.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchADRES.Text = dr["OGRADRES"].ToString();
               // yeniyol = "C:\\Users\\abdus\\OneDrive\\Masaüstü\\c# otomasyon\\C# OTOMASYON\\WindowsFormsApp1" + "\\resimler" + dr["OGRFOTO"].ToString();
                //pictureEdit1.Image = Image.FromFile(yeniyol);
                pictureBox1.ImageLocation = yol + dr["OGRFOTO"];
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAD.Text = dr["OGRAD"].ToString();
                TxtSOYAD.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSınıf.Text = dr["OGRSINIF"].ToString();

                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {

                    RdBtnBayan.Checked = true;
                }
                CmbİL.Text = dr["OGRIL"].ToString();
                CmbİLCE.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchADRES.Text = dr["OGRADRES"].ToString();
                // yeniyol = "C:\\Users\\abdus\\OneDrive\\Masaüstü\\c# otomasyon\\C# OTOMASYON\\WindowsFormsApp1" + "\\resimler" + dr["OGRFOTO"].ToString();
                //pictureEdit1.Image = Image.FromFile(yeniyol);
                pictureBox1.ImageLocation = yol + dr["OGRFOTO"];
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();

            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAD.Text = dr["OGRAD"].ToString();
                TxtSOYAD.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSınıf.Text = dr["OGRSINIF"].ToString();

                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {

                    RdBtnBayan.Checked = true;
                }
                CmbİL.Text = dr["OGRIL"].ToString();
                CmbİLCE.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchADRES.Text = dr["OGRADRES"].ToString();
                // yol tanımlama yanlış 2dk
                //yeniyol = "C:\\Users\\abdus\\OneDrive\\Masaüstü\\c# otomasyon\\C# OTOMASYON\\WindowsFormsApp1" + "\\resimler" + dr["OGRFOTO"].ToString();
               // yeniyol = "C:\\Users\\abdus\\OneDrive\\Masaüstü\\c# otomasyon\\C# OTOMASYON\\WindowsFormsApp1" + "\\resimler" + dr["OGRFOTO"].ToString();
               // pictureEdit1.Image = Image.FromFile(yol);
                pictureBox1.ImageLocation = yol + dr["OGRFOTO"];
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();

            }
        }

        private void BtnSİL_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_OGRENCILER where=OGRID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÖĞRENCİ SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        public string cinsiyet;


        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRENCILER (OGRAD,OGRSOYAD,OGRNO,OGRSINIF,OGRDOGTAR,OGRCINSIYET,OGRTC,OGRIL,OGRILCE,OGRADRES,OGRFOTO,OGRVELIID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", CmbSınıf.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);

            if (RdBtnErkek.Checked==true)
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet="E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet="B");
            }

            komut.Parameters.AddWithValue("@p7", MskTC.Text);
            komut.Parameters.AddWithValue("@p8", CmbİL.Text);
            komut.Parameters.AddWithValue("@p9", CmbİLCE.Text);
            komut.Parameters.AddWithValue("@p10", RchADRES.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÖĞRENCİ EKLENDİ","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        public string yeniyol;


        private void BtnRESİM_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya=new OpenFileDialog();
            dosya.Filter = "Resim Dosyası| *.jpg;*.png;*.nef | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            String dosyayolu=dosya.FileName;
            yeniyol = "C:\\Users\\abdus\\OneDrive\\Masaüstü\\c# otomasyon\\C# OTOMASYON\\WindowsFormsApp1" + "\\resimler" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureEdit1.Image = Image.FromFile(yeniyol);



        }

        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRENCILER set OGRAD=@p1,OGRSOYAD=@p2,OGRNO=@p3,OGRSINIF=@p4,OGRDOGTAR=@p5,OGRCINSIYET=@p6,OGRTC=@p7,OGRIL=@p8,OGRILCE=@p9,OGRADRES=@p10,OGRFOTO=@p11,OGRVELIID=@p13 where OGRID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", CmbSınıf.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);

            if (RdBtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "B");
            }

            komut.Parameters.AddWithValue("@p7", MskTC.Text);
            komut.Parameters.AddWithValue("@p8", CmbİL.Text);
            komut.Parameters.AddWithValue("@p9", CmbİLCE.Text);
            komut.Parameters.AddWithValue("@p10", RchADRES.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", TxtID.Text);
            komut.Parameters.AddWithValue("@p13", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÖĞRENCİ GÜNCLLENDİ ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnTEMIZLE_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void GrdCtrl5_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            pictureBox1.ImageLocation = yol + dr["OGRFOTO"];
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            FrmNufusCuzdani frm =new FrmNufusCuzdani();

            if (dr!=null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString() ;
                frm.uzanti= pictureBox1.ImageLocation = yol + dr["OGRFOTO"];

            }
            frm.Show();
        }
    }
    }
    
    

