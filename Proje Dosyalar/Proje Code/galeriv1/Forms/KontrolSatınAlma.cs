using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galeriv1.Forms
{
    public partial class KontrolSatınAlma : UserControl
    {
        KontrolSözleşme kontrol = new KontrolSözleşme();
        public KontrolSatınAlma()
        {
            InitializeComponent();
        }
        private void YenileListele()
        {
            //dataGridView1.DataSource = Galeri.getInstance().aracKayit.getDataTableSatıs();
            //dataGridView2.DataSource = Galeri.getInstance().aracKayit.getDataTableTarih();
        }

        private void KontrolSatınAlma_Load(object sender, EventArgs e)
        {
            //YenileListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            SAtxtPlaka.Text = satır.Cells[0].Value.ToString();
            SAtxtMarka.Text = satır.Cells[1].Value.ToString();
            SAtxtModel.Text = satır.Cells[2].Value.ToString(); ;
            SAtxtSeri.Text = satır.Cells[3].Value.ToString();
            SAcomboSatış.Text = satır.Cells[4].Value.ToString();
            SAtxtFiyat.Text = satır.Cells[5].Value.ToString();
        }

        private void SAsat_Click(object sender, EventArgs e)
        {
            bool basari = true;
            if (SAtxtPlaka.Text == "") { basari = false; }

            Arac arac = Galeri.getInstance().aracKayit.getAracFromPlaka(SAtxtPlaka.Text);
            if (basari && arac == null) { basari = false; }

            String satisDurumu = arac.SatışDurumu;
            if (basari && (satisDurumu.Equals("Satılmadı") || satisDurumu.Equals("")))
            {
                arac.SatışTarihi = DateTime.Now.ToString();
                arac.SatışDurumu = "Satıldı";
                Galeri.getInstance().aracKayit.update(arac, arac);
                dataGridView1.DataSource = Galeri.getInstance().aracKayit.getDataTableSatıs();
                dataGridView2.DataSource = Galeri.getInstance().aracKayit.getDataTableTarih();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";

                kontrol.Show();
                //this.Hide();
                return;
            }

            labelHatalı.Text = "Hatalı Satış";
            return;
        }

        private void SAtoplamGelirLabel_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            DataTable tablex = new DataTable();
            tablex.Columns.Add("Fiyat", typeof(string));
            tablex.Columns.Add("SatışDurumu", typeof(string));

            foreach (Arac arac in Galeri.getInstance().aracKayit.araclar)
            {
                tablex.Rows.Add(arac.Fiyat);
                if (arac.SatışDurumu == "Satıldı")
                {
                    toplam += Convert.ToInt32((arac.Fiyat));
                }
                
                
            }
            SAtoplamGelirText.Text = toplam.ToString();
        }
    }
}
