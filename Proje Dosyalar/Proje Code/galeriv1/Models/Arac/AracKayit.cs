using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galeriv1
{
    class AracKayit : IKayit<Arac>
    {
        public List<Arac> araclar;

        public AracKayit()
        {
            araclar = new List<Arac>();
            loadFromDB();
        }


        public void loadFromDB()
        {
            string query = "select * from araçTablo";
            SqlConnection connection = SQLUtils.baglanti;

            DataTable dataTable = new DataTable();

            connection.Open();

            new SqlDataAdapter(query, connection).Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                araclar.Add(new Arac(row));
            }

            connection.Close();

        }

        public void create(Arac arac)
        {
            string query = "insert into araçTablo(KM,Yıl,Motor_gücü,Plaka,Fiyat,Renk,Tarih,Resim,Marka,Seri,Model,Yakıt,Vites,Garanti,Kasa_Tipi,Çekiş) values(@KM,@Yıl,@Motor_gücü,@Plaka,@Fiyat,@Renk,@Tarih,@Resim,@Marka,@Seri,@Model,@Yakıt,@Vites,@Garanti,@Kasa_Tipi,@Çekiş)";

            SqlConnection connection = SQLUtils.baglanti;
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@KM", arac.KM);
            command.Parameters.AddWithValue("@Yıl", arac.Yil);
            command.Parameters.AddWithValue("@Motor_gücü", arac.MotorGucu);
            command.Parameters.AddWithValue("@Plaka", arac.Plaka);
            command.Parameters.AddWithValue("@Fiyat", arac.Fiyat);
            command.Parameters.AddWithValue("@Renk", arac.Renk);
            command.Parameters.AddWithValue("@Resim", arac.Resim);
            command.Parameters.AddWithValue("@Tarih", arac.Tarih);
            command.Parameters.AddWithValue("@Marka", arac.Marka);
            command.Parameters.AddWithValue("@Seri", arac.Seri);
            command.Parameters.AddWithValue("@Model", arac.Model);
            command.Parameters.AddWithValue("@Yakıt", arac.Yakit);
            command.Parameters.AddWithValue("@Vites", arac.Vites);
            command.Parameters.AddWithValue("@Çekiş", arac.Cekis);
            command.Parameters.AddWithValue("@Garanti", arac.Garanti);
            command.Parameters.AddWithValue("@Kasa_Tipi", arac.KasaTipi);


            if (command.ExecuteNonQuery() == 1) araclar.Add(arac);

            connection.Close();

        }

        public void delete(Arac arac)
        {

            string query = "delete from araçTablo where Plaka='" + arac.Plaka + "'";
            SqlConnection connection = SQLUtils.baglanti;
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            if (command.ExecuteNonQuery() == 1) araclar.Remove(arac);
            connection.Close();
        }

        public void update(Arac arac, Arac aracYeni)
        {
            if (arac == null || arac.Plaka == null || aracYeni == null) return;
            string query =
                "update araçTablo set " +
                "KM=@KM," +
                "Yıl=@Yıl," +
                "Motor_gücü=@Motor_gücü," +
                "Plaka=@Plaka," +
                "Fiyat=@Fiyat," +
                "Marka=@Marka," +
                "Seri=@Seri," +
                "Model=@Model," +
                "Yakıt=@Yakıt," +
                "Renk=@Renk," +
                "Vites=@Vites," +
                "Çekiş=@Çekiş," +
                "Garanti=@Garanti," +
                "Kasa_Tipi=@Kasa_Tipi," +
                "Tarih=@Tarih," +
                "Resim=@Resim," +
                "SatışTarihi=@SatışTarihi," +
                "SatışDurumu=@SatışDurumu " +
                "where Plaka=@FromPlaka";
            SqlConnection connection = SQLUtils.baglanti;
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@KM", aracYeni.KM);
            command.Parameters.AddWithValue("@Yıl", aracYeni.Yil);
            command.Parameters.AddWithValue("@Motor_gücü", aracYeni.MotorGucu);
            command.Parameters.AddWithValue("@Plaka", aracYeni.Plaka);
            command.Parameters.AddWithValue("@FromPlaka", arac.Plaka);
            command.Parameters.AddWithValue("@Fiyat", aracYeni.Fiyat);
            command.Parameters.AddWithValue("@Renk", aracYeni.Renk);
            command.Parameters.AddWithValue("@Resim", aracYeni.Resim);
            command.Parameters.AddWithValue("@Tarih", aracYeni.Tarih);
            command.Parameters.AddWithValue("@Marka", aracYeni.Marka);
            command.Parameters.AddWithValue("@Seri", aracYeni.Seri);
            command.Parameters.AddWithValue("@Model", aracYeni.Model);
            command.Parameters.AddWithValue("@Yakıt", aracYeni.Yakit);
            command.Parameters.AddWithValue("@Vites", aracYeni.Vites);
            command.Parameters.AddWithValue("@Çekiş", aracYeni.Cekis);
            command.Parameters.AddWithValue("@Garanti", aracYeni.Garanti);
            command.Parameters.AddWithValue("@SatışDurumu", aracYeni.SatışDurumu);
            command.Parameters.AddWithValue("@Kasa_Tipi", aracYeni.KasaTipi);
            if (aracYeni.SatışTarihi == null) { command.Parameters.AddWithValue("@SatışTarihi", ""); } else
            {
                command.Parameters.AddWithValue("@SatışTarihi", aracYeni.SatışTarihi);
            }
            

            if (command.ExecuteNonQuery() == 1)
            {
                arac.KM = aracYeni.KM;
                arac.Yil = aracYeni.Yil;
                arac.MotorGucu = aracYeni.MotorGucu;
                arac.Plaka = aracYeni.Plaka;
                arac.Fiyat = aracYeni.Fiyat;
                arac.Renk = aracYeni.Renk;
                arac.Resim = aracYeni.Resim;
                arac.Tarih = aracYeni.Tarih;
                arac.Marka = aracYeni.Marka;
                arac.Seri = aracYeni.Seri;
                arac.Model = aracYeni.Model;
                arac.Yakit = aracYeni.Yakit;
                arac.Vites = aracYeni.Vites;
                arac.Cekis = aracYeni.Cekis;
                arac.Garanti = aracYeni.Garanti;
                arac.KasaTipi = aracYeni.KasaTipi;
            }
            connection.Close();
        }
       


        public Arac getAracFromPlaka(String plaka)
        {
            foreach (Arac arac in araclar)
            {
                if (plaka.Equals(arac.Plaka)) return arac;
            }
            return null;
        }

        public DataTable getDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("KM", typeof(string));
            table.Columns.Add("Yıl", typeof(string));
            table.Columns.Add("Motor Gücü", typeof(string));
            table.Columns.Add("Plaka", typeof(string));
            table.Columns.Add("Fiyat", typeof(string));
            table.Columns.Add("Marka", typeof(string));
            table.Columns.Add("Seri", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Yakıt", typeof(string));
            table.Columns.Add("Renk", typeof(string));
            table.Columns.Add("Vites", typeof(string));
            table.Columns.Add("Çekiş", typeof(string));
            table.Columns.Add("Kasa Tipi", typeof(string));
            table.Columns.Add("Garanti", typeof(string));
            table.Columns.Add("Tarih", typeof(string));
            table.Columns.Add("Resim", typeof(string));
            foreach (Arac arac in araclar)
            {
                table.Rows.Add(
                    arac.KM, arac.Yil, arac.MotorGucu, arac.Plaka, arac.Fiyat, arac.Marka, 
                    arac.Seri, arac.Model, arac.Yakit, arac.Renk, arac.Vites, arac.Cekis, 
                    arac.KasaTipi, arac.Garanti, arac.Tarih, arac.Resim
                );
            }
            return table;

        }
        public DataTable getDataTableSatıs()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Plaka", typeof(string));
            table.Columns.Add("Marka", typeof(string));
            table.Columns.Add("Seri", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("SatışDurumu", typeof(string));
            table.Columns.Add("Fiyat", typeof(string));

            foreach (Arac arac in araclar)
            {
                table.Rows.Add(
                    arac.Plaka, arac.Marka, arac.Seri, arac.Model,
                    arac.SatışDurumu, arac.Fiyat
                );
            }
            return table;
        }
        public DataTable getDataTableTarih()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Plaka", typeof(string));
            table.Columns.Add("SatılmaTarihi", typeof(string));
            table.Columns.Add("SatışTutarı", typeof(string));

            foreach (Arac arac in araclar)
            {
                if(arac.SatışDurumu == "Satıldı")
                {
                    table.Rows.Add( arac.Plaka, arac.SatışTarihi, arac.Fiyat);
                }
               
            }
            return table;
        }


    }
}
