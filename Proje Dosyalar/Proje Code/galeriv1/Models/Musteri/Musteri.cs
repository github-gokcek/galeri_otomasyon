using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galeriv1
{
    class Musteri
    {
        public String TC;
        public String AdSoyad;
        public String Telefon;
        public String Email;
        public String Adres;

        public Musteri(DataRow row)
        {
            this.TC = row["tc"].ToString();
            this.AdSoyad = row["adsoyad"].ToString();
            this.Telefon = row["telefon"].ToString();
            this.Email = row["email"].ToString();
            this.Adres = row["adres"].ToString();
        }

        public Musteri(string tC, string adSoyad, string telefon, string email, string adres)
        {
            TC = tC;
            AdSoyad = adSoyad;
            Telefon = telefon;
            Email = email;
            Adres = adres;
        }

    }
}
