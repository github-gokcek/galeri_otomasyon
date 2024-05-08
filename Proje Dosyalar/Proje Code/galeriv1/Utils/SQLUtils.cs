using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galeriv1
{
    class SQLUtils
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EII6NB0E\\MSSQLSERVER02;Initial Catalog=Galeri_Otomasyon;Integrated Security=True");
    }
}
