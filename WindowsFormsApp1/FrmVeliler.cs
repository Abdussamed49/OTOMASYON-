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
    public partial class FrmVeliler : Form
    {
        public FrmVeliler()
        {
            InitializeComponent();
        }
        DbOkulEntities db=new DbOkulEntities();
        
        void listele()
        {
            var query = from item in db.TBL_VELILER
                        select new { item.VELIID,item.VELIANNE, item.VELIBABA, item.VELITEL1, item.VELITEL2, item.VELIMAIL };
            gridControl1.DataSource = query.ToList();   
        }


        private void FrmVeliler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();


        }



        void temizle()
        {
            TxtID.Text = "";
            TxtAnne.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            TxtMAIL.Text = "";

        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            TBL_VELILER veli =new TBL_VELILER();
            veli.VELIANNE = TxtAnne.Text;
            veli.VELIBABA = TxtBabaAd.Text;
            veli.VELITEL1 = MskTelefon1.Text;
            veli.VELITEL2= MskTelefon2.Text;
            veli.VELIMAIL = TxtMAIL.Text;
            db.TBL_VELILER.Add(veli);
            db.SaveChanges();
            listele();
            temizle();



        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"VELIID").ToString();
            TxtAnne.Text=gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"VELIANNE").ToString() ;
            TxtBabaAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIBABA").ToString();
            MskTelefon1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL1").ToString();
            MskTelefon2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL2").ToString();
            TxtMAIL.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIMAIL").ToString();


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
          //  var item = db.TBL_VELILER.Find(id);
          //  item.VELIANNE = TxtAnne.Text;
          //  item.VELIBABA = TxtBabaAd.Text;
          //  item.VELITEL1 = MskTelefon1.Text;
          //  item.VELITEL2 = MskTelefon2.Text;
          //  item.VELIMAIL = TxtMAIL.Text;
         //   db.SaveChanges();
          //  listele();*/
           // temizle();//
           using(DbOkulEntities db=new DbOkulEntities())
            {
                var item=db.TBL_VELILER.FirstOrDefault(x=>x.VELIID==id);
                item.VELIANNE = TxtAnne.Text;
                  item.VELIBABA = TxtBabaAd.Text;
                  item.VELITEL1 = MskTelefon1.Text;
                  item.VELITEL2 = MskTelefon2.Text;
                 item.VELIMAIL = TxtMAIL.Text;
                  db.SaveChanges();
                 listele();
                 temizle();
            }

        }

        private void BtnSİL_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
           // var item = db.TBL_VELILER.Find(id);
            //db.TBL_VELILER.Remove(item);
           // db.SaveChanges();
           // listele();
           // temizle();
           using(DbOkulEntities db=new DbOkulEntities())
            {
                var item = db.TBL_VELILER.First(x=>x.VELIID==id);
                db.TBL_VELILER.Remove(item);
                db.SaveChanges() ;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
