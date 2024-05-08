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
    public partial class MusteriKayitForm : Form
    {
        public MusteriKayitForm()
        {
            InitializeComponent();
        }

        private void formMüşteriKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Galeri.getInstance().musteriKayit.create(new Musteri(txtTc.Text, txtAdSoyad.Text, txtTelefon.Text, txtMail.Text, txtAdres.Text));
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAdres_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTelefon_Click(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTc_Click(object sender, EventArgs e)
        {

        }
    }
}
