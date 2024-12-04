using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace WindowsFormsApp1
{
     class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection  baglan = new SqlConnection(@" Data Source=Abdussamed\SQLEXPRESS;Initial Catalog=dbo.OKulOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
