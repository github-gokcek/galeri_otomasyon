using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galeriv1
{
    class Arac
    {
        public String KM;
        public String Yil;
        public String MotorGucu;
        public String Plaka;
        public String Marka;
        public String Seri;
        public String Model;
        public String Yakit;
        public String Vites;
        public String Garanti;
        public String KasaTipi;
        public String Renk;
        public String Resim;
        public String Tarih;
        public String Cekis;
        public String Fiyat;
        public String SatışDurumu;
        public String SatışTarihi;
       
        

        public Arac(DataRow row)
        {
            //"update araçTablo set KM=@KM,Yıl=@Yıl,Motor_gücü=@Motor_gücü,Plaka=@Plaka,Fiyat=@Fiyat,Renk=@Renk,Resim=@Resim,
            //Tarih=@Tarih,Marka=@Marka,Seri=@Seri,Model=@Model,Yakıt=@Yakıt,Vites=@Vites,Çekiş=@Çekiş,Garanti=@Garanti,Kasa_Tipi=@Kasa_Tipi where Plaka=@Plaka";
            this.KM = row["KM"].ToString();
            this.Yil = row["Yıl"].ToString();
            this.MotorGucu = row["Motor_gücü"].ToString();
            this.Plaka = row["Plaka"].ToString();
            this.Fiyat = row["Fiyat"].ToString();
            this.Renk = row["Renk"].ToString();
            this.Resim = row["Resim"].ToString();
            this.Tarih = row["Tarih"].ToString();
            this.Marka = row["Marka"].ToString();
            this.Seri = row["Seri"].ToString();
            this.Model = row["Model"].ToString();
            this.Yakit = row["Yakıt"].ToString();
            this.Vites = row["Vites"].ToString();
            this.Cekis = row["Çekiş"].ToString();
            this.Garanti = row["Garanti"].ToString();
            this.KasaTipi = row["Kasa_Tipi"].ToString();
            this.Plaka = row["Plaka"].ToString();
            this.SatışDurumu = row["SatışDurumu"].ToString();
            //this.SatışTarihi = row["SatışTarihi"].ToString();
        }

        public Arac(
            string kM, string yil, string motorGucu, string plaka, 
            string fiyat, string renk, string resim, string tarih, 
            string marka, string model, string yakit, string vites, 
            string cekis, string garanti, string kasaTipi, string seri
            )
        {
            KM = kM;
            Yil = yil;
            MotorGucu = motorGucu;
            Plaka = plaka;
            //Fiyat ekle
            Marka = marka;
            Seri = seri;
            Model = model;
            Yakit = yakit;
            Vites = vites;
            Garanti = garanti;
            KasaTipi = kasaTipi;
            Renk = renk;
            Fiyat = fiyat;
            Resim = resim;
            Cekis = cekis;
            Tarih = tarih;
            SatışDurumu = "Satılmadı";
            SatışTarihi = null;
        }

        /*
         * Satış için cons belki lazım olur
         * 
        public Arac(
            string plaka,
            string marka,
            string model,
            string seri,
            string satışdurumu,
            string fiyat
            
            )
        {
            Plaka = plaka;           
            Marka = marka;
            Seri = seri;
            Model = model;
            Fiyat = fiyat;
            SatışDurumu = satışdurumu;
        }
        */
    }
}
