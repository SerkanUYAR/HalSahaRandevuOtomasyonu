using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HalıSahaOtomasyonu
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection Baglan = new SqlConnection(@"Data Source=DESKTOP-O48QP1T;Initial Catalog=HalıSahaOtomasyonProjesi;Integrated Security=True");
            Baglan.Open();
            return Baglan;
        }
    }
}
