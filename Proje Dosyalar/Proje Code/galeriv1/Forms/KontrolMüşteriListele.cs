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
    public partial class KontrolMüşteriListele : UserControl
    {
        private string tempTC = null;
       
        private void formMüşteriListeleme_Load(object sender, EventArgs e)
        {
            //YenileListele();
        }

        private void YenileListele()
        {
            //dataGridView1.DataSource = Galeri.getInstance().musteriKayit.getDataTable();
            
        }
        public KontrolMüşteriListele()
        {
            InitializeComponent();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            Galeri.getInstance().musteriKayit.delete(Galeri.getInstance().musteriKayit.getMusteriFromTC(satır.Cells["tc"].Value.ToString()));
            YenileListele();
        }

        private void txtTcArama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Galeri.getInstance().musteriKayit.getFilteredDataTable(musteri => musteri.TC.StartsWith(txtTcArama.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = Galeri.getInstance().musteriKayit.getMusteriFromTC(tempTC);
            Musteri musteriYeni = new Musteri(txtTc.Text, txtAdSoyad.Text, txtTelefon.Text, txtMail.Text, txtAdres.Text);
            Galeri.getInstance().musteriKayit.update(musteri, musteriYeni);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KontrolMüşteriListele_Load(object sender, EventArgs e)
        {
            //YenileListele();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            tempTC = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtMail.Text = satır.Cells[3].Value.ToString();
            txtAdres.Text = satır.Cells[4].Value.ToString();
        }
    }
}
