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
    public partial class FrmNufusCuzdani : Form
    {
        public FrmNufusCuzdani()
        {
            InitializeComponent();
        }
        public string ad, soyad, tc, cinsiyet, dogtarihi, uzanti;

        private void FrmNufusCuzdani_Load(object sender, EventArgs e)
        {
            LblAD.Text= ad;
            LblSOYAD.Text= soyad;   
            LblTC.Text= tc;
            LblCinsiyet.Text= cinsiyet;
            LblDOGUMTAR.Text= dogtarihi;
            pictureEdit1.Image = Image.FromFile(uzanti);
            
        }
    }
}
