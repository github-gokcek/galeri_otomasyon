using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galeriv1
{
    class MusteriKayit : IKayit<Musteri>
    {
        List<Musteri> musteriler;

        public MusteriKayit()
        {
            musteriler = new List<Musteri>();
            loadFromDB();
        }


        public void loadFromDB()
        {
            string query = "select *from Müşteri_Kayıt";
            SqlConnection connection = SQLUtils.baglanti;

            DataTable dataTable = new DataTable();

            connection.Open();

            new SqlDataAdapter(query, connection).Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                musteriler.Add(new Musteri(row));
            }

            connection.Close();
        }

        public void create(Musteri musteri)
        {
            string query = "insert into Müşteri_Kayıt(tc,adsoyad,telefon,email,adres) values(@tc,@adsoyad,@telefon,@email,@adres)";

            SqlConnection connection = SQLUtils.baglanti;
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@tc", musteri.TC);
            command.Parameters.AddWithValue("@adsoyad", musteri.AdSoyad);
            command.Parameters.AddWithValue("@telefon", musteri.Telefon);
            command.Parameters.AddWithValue("@email", musteri.Email);
            command.Parameters.AddWithValue("@adres", musteri.Adres);

            if (command.ExecuteNonQuery() == 1) musteriler.Add(musteri);
            connection.Close();


        }

        public void delete(Musteri musteri)
        {
            string query = "delete from Müşteri_Kayıt where tc='" + musteri.TC + "'";
            SqlConnection connection = SQLUtils.baglanti;
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            if (command.ExecuteNonQuery() == 1) musteriler.Remove(musteri);
            connection.Close();

        }

        public void update(Musteri musteri, Musteri musteriYeni)
        {

            string query = "update Müşteri_Kayıt set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@fromtc";
            SqlConnection connection = SQLUtils.baglanti;
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fromtc", musteri.TC);
            command.Parameters.AddWithValue("@tc", musteriYeni.TC);
            command.Parameters.AddWithValue("@adsoyad", musteriYeni.AdSoyad);
            command.Parameters.AddWithValue("@telefon", musteriYeni.Telefon);
            command.Parameters.AddWithValue("@email", musteriYeni.Email);
            command.Parameters.AddWithValue("@adres", musteriYeni.Adres);

            if (command.ExecuteNonQuery() == 1)
            {
                musteri.TC = musteriYeni.TC;
                musteri.AdSoyad = musteriYeni.AdSoyad;
                musteri.Adres = musteriYeni.Adres;
                musteri.Email = musteriYeni.Email;
                musteri.Telefon = musteriYeni.Telefon;
            }

                connection.Close();
        }
        public Musteri getMusteriFromTC(String tc)
        {
            foreach (Musteri musteri in musteriler)
            {
                if (tc.Equals(musteri.TC)) return musteri;
            }
            return null;
        }

        private DataTable getDataTable(List<Musteri> musteriler)
        {
            DataTable table = new DataTable();
            table.Columns.Add("TC", typeof(string));
            table.Columns.Add("Ad Soyad", typeof(string));
            table.Columns.Add("Telefon", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Adres", typeof(string));
            foreach (Musteri musteri in musteriler)
            {
                table.Rows.Add(musteri.TC, musteri.AdSoyad, musteri.Telefon, musteri.Email, musteri.Adres);
            }
            return table;
        }


        public DataTable getDataTable()
        {
            return getDataTable(this.musteriler);
        }

        public DataTable getFilteredDataTable(Func<Musteri, bool> predicate)
        {
            return getDataTable(musteriler.Where(predicate).ToList());
        }

    }
}
