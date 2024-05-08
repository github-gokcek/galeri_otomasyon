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
    public partial class Kontrol1 : UserControl
    {
        public Kontrol1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Galeri.getInstance().musteriKayit.create(new Musteri(txtTc.Text, txtAdSoyad.Text, txtTelefon.Text, txtMail.Text, txtAdres.Text));
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
