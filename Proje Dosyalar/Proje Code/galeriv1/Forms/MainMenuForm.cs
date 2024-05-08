using System;
using System.Windows.Forms;

namespace galeriv1
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelKırmızı.Height = button1.Height;
            panelKırmızı.Top = button1.Top;
            foreach (Control item in Controls) if (item is UserControl) { item.Hide(); }
            kontrol11.Show();
            //musteriKayitForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelKırmızı.Height = button2.Height;
            panelKırmızı.Top = button2.Top;
            foreach (Control item in Controls) if(item is UserControl) { item.Hide(); }
            kontrolMüşteriListele1.Show();
            //musteriListeForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelKırmızı.Height = button3.Height;
            panelKırmızı.Top = button3.Top;
            foreach (Control item in Controls) if (item is UserControl) { item.Hide(); }
            araçKayıtKontrol1.Show();
            //aracKayitForm.ShowDialog();
        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelKırmızı.Height = button4.Height;
            panelKırmızı.Top = button4.Top;
            foreach (Control item in Controls) if (item is UserControl) { item.Hide(); }
            kontrolAraçListele1.Show();
            //aracListeForm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kontrol11_Load(object sender, EventArgs e)
        {

        }

        private void kontrolMüşteriListele1_Load(object sender, EventArgs e)
        {

        }

        private void araçKayıtKontrol1_Load(object sender, EventArgs e)
        {
            
        }

        private void kontrolAraçListele1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelKırmızı.Height = button5.Height;
            panelKırmızı.Top = button5.Top;
            foreach (Control item in Controls) if (item is UserControl) { item.Hide(); }
            kontrolSatınAlma1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelKırmızı.Height = button6.Height;
            panelKırmızı.Top = button6.Top;
            foreach (Control item in Controls) if (item is UserControl) { item.Hide(); }
            kontrolSözleşme1.Show();
        }
    }
}
