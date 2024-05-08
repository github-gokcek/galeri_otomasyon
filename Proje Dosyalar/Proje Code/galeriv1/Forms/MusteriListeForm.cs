using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace galeriv1
{
    public partial class MusteriListeForm : Form
    {

        public MusteriListeForm()
        {
            InitializeComponent();
        }

        private void formMüşteriListeleme_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            dataGridView1.DataSource = Galeri.getInstance().musteriKayit.getDataTable();
        }

        private void txtTcArama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Galeri.getInstance().musteriKayit.getFilteredDataTable(musteri => musteri.TC.StartsWith(txtTcArama.Text));
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string tempTC = null;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            tempTC = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtMail.Text = satır.Cells[3].Value.ToString();
            txtAdres.Text = satır.Cells[4].Value.ToString();
        }

        private void button_guncelle(object sender, EventArgs e)
        {
            Musteri musteri = Galeri.getInstance().musteriKayit.getMusteriFromTC(tempTC);
            Musteri musteriYeni = new Musteri(txtTc.Text, txtAdSoyad.Text, txtTelefon.Text, txtMail.Text, txtAdres.Text);
            Galeri.getInstance().musteriKayit.update(musteri, musteriYeni);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            Galeri.getInstance().musteriKayit.delete(Galeri.getInstance().musteriKayit.getMusteriFromTC(satır.Cells["tc"].Value.ToString()));
            YenileListele();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTcArama_Click(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void labelAdres_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefon_Click(object sender, EventArgs e)
        {

        }

        private void labelAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void labelTc_Click(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
