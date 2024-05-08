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
   

    public partial class AracKayitForm : Form
    {

        public AracKayitForm()
        {
            InitializeComponent();
        }
        private void YenileListele()
        {
            dataGridView1.DataSource = Galeri.getInstance().aracKayit.getDataTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Arac getAracFromFields()
        {
            return new Arac(
                txtKM.Text, txtYıl.Text, txtMotorGücü.Text, txtPlaka.Text,
                txtFiyat.Text, txtRenk.Text, pictureBox2.ImageLocation,
                DateTime.Now.ToString(), comboMarka.Text, comboModel.Text, comboYakıt.Text, comboVites.Text, comboÇekiş.Text, comboGaranti.Text, comboKasaTipi.Text, comboSeri.Text);
        }

        private void button_ekle(object sender, EventArgs e)
        {
            Arac arac = getAracFromFields();
            Galeri.getInstance().aracKayit.create(arac);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            YenileListele();



        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSeri.Items.Clear();
            if(comboMarka.SelectedItem.ToString() == "Audi")
            {
                comboSeri.Items.Add("A1");
                comboSeri.Items.Add("A3");
                comboSeri.Items.Add("A4");
            }
            else if (comboMarka.SelectedItem.ToString() == "BMW")
            {
                comboSeri.Items.Add("İ");
                comboSeri.Items.Add("X");
                comboSeri.Items.Add("M");
            }
            else if (comboMarka.SelectedItem.ToString() == "Bugatti")
            {
                comboSeri.Items.Add("Veyron");
                comboSeri.Items.Add("Chiron");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Citroen")
            {
                comboSeri.Items.Add("C3");
                comboSeri.Items.Add("C-");
                comboSeri.Items.Add("C4");
            }
            else if (comboMarka.SelectedItem.ToString() == "Chevrolet")
            {
                comboSeri.Items.Add("Cruze");
                comboSeri.Items.Add("Aveo");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Dacia")
            {
                comboSeri.Items.Add("Sandero");
                comboSeri.Items.Add("Logan");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Ferrari")
            {
                comboSeri.Items.Add("512");
                comboSeri.Items.Add("430");
                comboSeri.Items.Add("360");
            }
            else if (comboMarka.SelectedItem.ToString() == "Fiat")
            {
                comboSeri.Items.Add("Punto");
                comboSeri.Items.Add("Linea");
                comboSeri.Items.Add("Egea");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Honda")
            {
                comboSeri.Items.Add("Civic");
                comboSeri.Items.Add("Jazz");
               
            }
            else if (comboMarka.SelectedItem.ToString() == "Hyundai")
            {
                comboSeri.Items.Add("i20");
                comboSeri.Items.Add("i30");
                comboSeri.Items.Add("Getz");
            }
            else if (comboMarka.SelectedItem.ToString() == "Kia")
            {
                comboSeri.Items.Add("Rio");
                comboSeri.Items.Add("Cerato");
                comboSeri.Items.Add("Ceed");
            }
            else if (comboMarka.SelectedItem.ToString() == "Lamborghini")
            {
                comboSeri.Items.Add("Gallardo");
                comboSeri.Items.Add("Huracan");
                comboSeri.Items.Add("Aventador");
            }
            else if (comboMarka.SelectedItem.ToString() == "Maserati")
            {
                comboSeri.Items.Add("GrandTurismo");
                comboSeri.Items.Add("Ghibli");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Mazda")
            {
                comboSeri.Items.Add("3");
                comboSeri.Items.Add("6");
                comboSeri.Items.Add("323");
            }
            else if (comboMarka.SelectedItem.ToString() == "Mercedes-Benz")
            {
                comboSeri.Items.Add("C");
                comboSeri.Items.Add("A");
                comboSeri.Items.Add("S");
                comboSeri.Items.Add("E");
            }
            else if (comboMarka.SelectedItem.ToString() == "Mitsubishi")
            {
                comboSeri.Items.Add("Colt");
                comboSeri.Items.Add("Lancer");
                comboSeri.Items.Add("Carisma");
            }
            else if (comboMarka.SelectedItem.ToString() == "Nissan")
            {
                comboSeri.Items.Add("Micra");
                comboSeri.Items.Add("Pulsar");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Peuqeot")
            {
                comboSeri.Items.Add("207");
                comboSeri.Items.Add("307");
                comboSeri.Items.Add("308");
               
            }
            else if (comboMarka.SelectedItem.ToString() == "Porsche")
            {
                comboSeri.Items.Add("Taycan");
                comboSeri.Items.Add("Panamera");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Renault")
            {
                comboSeri.Items.Add("Megane");
                comboSeri.Items.Add("Symbol");
                comboSeri.Items.Add("Clio");
               
            }
            else if (comboMarka.SelectedItem.ToString() == "Tofaş")
            {
                comboSeri.Items.Add("Şahin");
                comboSeri.Items.Add("Kartal");
                comboSeri.Items.Add("Doğan");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Toyota")
            {
                comboSeri.Items.Add("Corollo");
                comboSeri.Items.Add("Auris");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Volkswagen")
            {
                comboSeri.Items.Add("Jetta");
                comboSeri.Items.Add("Passat");
                comboSeri.Items.Add("Polo");
                comboSeri.Items.Add("Golf");
            }
            else if (comboMarka.SelectedItem.ToString() == "Volvo")
            {
                comboSeri.Items.Add("S60");
                comboSeri.Items.Add("S80");
                comboSeri.Items.Add("V40");
               
            }


        }

        private void comboSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSeri.SelectedItem.ToString() == "A1")
            {
                comboModel.Items.Add("Sportback");
            }
            else if (comboSeri.SelectedItem.ToString() == "A3")
            {
                comboModel.Items.Add("Sportback");
                comboModel.Items.Add("Sedan");
                comboModel.Items.Add("Cabrio");
            }
            else if (comboSeri.SelectedItem.ToString() == "A4")
            {
                comboModel.Items.Add("Sedan");
                comboModel.Items.Add("Avant");
                comboModel.Items.Add("Allroad");
            }
            else if (comboSeri.SelectedItem.ToString() == "İ")
            {
                comboModel.Items.Add("iX");
                comboModel.Items.Add("i7");
                comboModel.Items.Add("i4");
            }
            else if (comboSeri.SelectedItem.ToString() == "X")
            {
                comboModel.Items.Add("XM");
                comboModel.Items.Add("X7 M60i");
                comboModel.Items.Add("X1");
            }
            else if (comboSeri.SelectedItem.ToString() == "M")
            {
                comboModel.Items.Add("M8 Gran Coupe");
                comboModel.Items.Add("M2 Coupe");

            }
            else if (comboSeri.SelectedItem.ToString() == "Veyron")
            {
                comboModel.Items.Add("16.4 Grand sport Vitesse");

            }
            else if (comboSeri.SelectedItem.ToString() == "Chiron")
            {
                comboModel.Items.Add("Sport");
                comboModel.Items.Add("Sport 110");

            }
            else if (comboSeri.SelectedItem.ToString() == "C3")
            {
                comboModel.Items.Add("1.4 VTİ Confort");
                comboModel.Items.Add("1.6 BlueHDİShine");

            }
            else if (comboSeri.SelectedItem.ToString() == "C-")
            {
                comboModel.Items.Add("1.6 HDi Exclusive");
                comboModel.Items.Add("1.6 Exclusive");

            }
            else if (comboSeri.SelectedItem.ToString() == "C4")
            {
                comboModel.Items.Add("1.6 e-HDİ Intensive");

            }
            else if (comboSeri.SelectedItem.ToString() == "Cruze")
            {
                comboModel.Items.Add("1.6 plus");
                comboModel.Items.Add("2.0 D LTZ");
                comboModel.Items.Add("1.6 LS plus");
            }
            else if (comboSeri.SelectedItem.ToString() == "Aveo")
            {
                comboModel.Items.Add("1.4 SE");
                comboModel.Items.Add("1.2S");
                comboModel.Items.Add("1.6 LT Plus");
            }
            else if (comboSeri.SelectedItem.ToString() == "Sandero")
            {
                comboModel.Items.Add("1.5 dCi Stepway");
                comboModel.Items.Add("1.5 dCi Ambiance");

            }
            else if (comboSeri.SelectedItem.ToString() == "Logan")
            {
                comboModel.Items.Add("1.4 Ambiance");
                comboModel.Items.Add("1.5 dCi MCV Ambiance");

            }
            else if (comboSeri.SelectedItem.ToString() == "512")
            {
                comboModel.Items.Add("Testarossa");

            }
            else if (comboSeri.SelectedItem.ToString() == "430")
            {
                comboModel.Items.Add("F430");
                comboModel.Items.Add("F430 Spider");

            }
            else if (comboSeri.SelectedItem.ToString() == "360")
            {
                comboModel.Items.Add("Modena F1");

            }
            else if (comboSeri.SelectedItem.ToString() == "Punto")
            {
                comboModel.Items.Add("1.4 Lounge S&S");
                comboModel.Items.Add(".4 Easy S&S");

            }
            else if (comboSeri.SelectedItem.ToString() == "Linea")
            {
                comboModel.Items.Add("1.3 Multijet Pop");
                comboModel.Items.Add("1.3 Multijet Actige Plus");

            }
            else if (comboSeri.SelectedItem.ToString() == "Egea")
            {
                comboModel.Items.Add("1.6 Multijet Pop");
                comboModel.Items.Add("1.6 Multijet Urban");

            }
            else if (comboSeri.SelectedItem.ToString() == "Fiesta")
            {
                comboModel.Items.Add("1.4 TDCİ Titanium");
                comboModel.Items.Add("1.25 Trend");
                comboModel.Items.Add("1.5 TDCİ Trend X");
            }
            else if (comboSeri.SelectedItem.ToString() == "Focus")
            {
                comboModel.Items.Add("1.6 TDCİ Trend");
                comboModel.Items.Add("1.5 TDCİ Titanium");

            }
            else if (comboSeri.SelectedItem.ToString() == "Mondeo")
            {
                comboModel.Items.Add("1.5 Ecoboost Titanium");

            }
            else if (comboSeri.SelectedItem.ToString() == "Civic")
            {
                comboModel.Items.Add("1.6 VTEC ES");
                comboModel.Items.Add("1.6i VTEC Elegance");
                comboModel.Items.Add("1.6 VTEC Eco Elegance");
                comboModel.Items.Add("1.4 i S");
            }
            else if (comboSeri.SelectedItem.ToString() == "Jazz")
            {
                comboModel.Items.Add("1.4 ES");

            }
            else if (comboSeri.SelectedItem.ToString() == "i20")
            {
                comboModel.Items.Add("1.4 MPI Elite Smart");
                comboModel.Items.Add("1.4 CVVT Jump");

            }
            else if (comboSeri.SelectedItem.ToString() == "i30")
            {
                comboModel.Items.Add("1.6 CRDi Elite");

            }
            else if (comboSeri.SelectedItem.ToString() == "Getz")
            {
                comboModel.Items.Add("1.3 GLS");
                comboModel.Items.Add("1.5 CRDİ VGT");

            }
            else if (comboSeri.SelectedItem.ToString() == "Rio")
            {
                comboModel.Items.Add("1.4L MPI Prestige");
                comboModel.Items.Add("1.25 CVVT Comfort");

            }
            else if (comboSeri.SelectedItem.ToString() == "Cerato")
            {
                comboModel.Items.Add("1.6 EX Advance");
                comboModel.Items.Add("1.6 CRDi Concept Plus");

            }
            else if (comboSeri.SelectedItem.ToString() == "Ceed") 
            {
                comboModel.Items.Add("1.6 CRDi Concept Plus");
                comboModel.Items.Add("1.6 CRDİ  Motion");
                
            }
            else if (comboSeri.SelectedItem.ToString() == "Gallardo")
            {
                comboModel.Items.Add("LP560-4");
                comboModel.Items.Add("LP 570-4 Superleggera");
                
            }
            else if (comboSeri.SelectedItem.ToString() == "Huracan")
            {
                comboModel.Items.Add("LP-610-4");
                
            }
            else if (comboSeri.SelectedItem.ToString() == "Aventador")
            {
                comboModel.Items.Add("LP 700-4");
                
            }
            else if (comboSeri.SelectedItem.ToString() == "GranTurismo")
            {
                comboModel.Items.Add("MC-Stradale");
                comboModel.Items.Add("4.2, 4.7 S");
                
            }
            else if (comboSeri.SelectedItem.ToString() == "Ghibli")
            {
                comboModel.Items.Add("3.0 D");
                comboModel.Items.Add("3.0");
                comboModel.Items.Add("2.0 MHEV");
            }
            else if (comboSeri.SelectedItem.ToString() == "3")
            {
                comboModel.Items.Add("1.6 Touring");
                comboModel.Items.Add("1.5 SkyActive-G Power");
               
            }
            else if (comboSeri.SelectedItem.ToString() == "6")
            {
                comboModel.Items.Add("2.0 Sky-G Power");
                comboModel.Items.Add("1.6 D Touring");
                comboModel.Items.Add("2.0 TE");
            }
            else if (comboSeri.SelectedItem.ToString() == "323")
            {
                comboModel.Items.Add("1.6 GLX");
                comboModel.Items.Add("1.6 1.6i");
                
            }
            else if (comboSeri.SelectedItem.ToString() == "C")
            {
                comboModel.Items.Add("C 200 d BlueTEC AMG");
                comboModel.Items.Add("C 200 D AMG");
                comboModel.Items.Add("C 180 AMG");
            }
            else if (comboSeri.SelectedItem.ToString() == "A")
            {
                comboModel.Items.Add("A 180 Urban");
                comboModel.Items.Add("Sedan");
                
            }
            else if (comboSeri.SelectedItem.ToString() == "S")
            {
                comboModel.Items.Add("S 350");
                comboModel.Items.Add("S 350 L");
                
            }
            else if (comboSeri.SelectedItem.ToString() == "E")
            {
                comboModel.Items.Add("E 180 Edition E");
                comboModel.Items.Add("E 180 Exclusive");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Colt")
            {
                comboSeri.Items.Add("1.3  Elegance");
                comboSeri.Items.Add("1.5 Instyle");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Lancer")
            {
                comboSeri.Items.Add("1.6 Invite");
                comboSeri.Items.Add("1.5 Invite");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Carisma")
            {
                comboSeri.Items.Add("1.6 GLX");
                comboSeri.Items.Add("1.6 Avance");
                comboSeri.Items.Add("1.6 Comfort");
            }
            else if (comboMarka.SelectedItem.ToString() == "Micra")
            {
                comboSeri.Items.Add("1.2 Tekna");
                comboSeri.Items.Add("1.2 Puzzle");
                comboSeri.Items.Add("1.2 Punch");
            }
            else if (comboMarka.SelectedItem.ToString() == "Pulsar")
            {
                comboSeri.Items.Add("1.2 N-Tec");
               
            }
            else if (comboMarka.SelectedItem.ToString() == "Vectra")
            {
                comboSeri.Items.Add("2.0 CD");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Insignia ")
            {
                comboSeri.Items.Add("2.0 CDTI Edition");
                comboSeri.Items.Add("1.6 CDTI Cosmo");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "Astra")
            {
                comboSeri.Items.Add("1.6 Enjoy");
                comboSeri.Items.Add("1.3 CDTI Enjoy");
                comboSeri.Items.Add("1.4 Dynamic");
            }
            else if (comboMarka.SelectedItem.ToString() == "Corsa")
            {
                comboSeri.Items.Add("1.0 ECO Club");
                comboSeri.Items.Add("1.4 Twinport Enjoy");
                
            }
            else if (comboMarka.SelectedItem.ToString() == "207")
            {
                comboSeri.Items.Add("1.4 Trendy");
                comboSeri.Items.Add("1.4 HDi Trendy");
                comboSeri.Items.Add("M");
            }
            else if (comboMarka.SelectedItem.ToString() == "307")
            {
                comboSeri.Items.Add("1.6 Premium");
                comboSeri.Items.Add("1.6 HDi Premium");

            }
            else if (comboMarka.SelectedItem.ToString() == "308")
            {
                comboSeri.Items.Add("1.6 HDi Premium");
                comboSeri.Items.Add("1.6 BlueHDi Allure");

            }
            else if (comboMarka.SelectedItem.ToString() == "Taycan")
            {
                comboSeri.Items.Add("4S Performance Plus");
                comboSeri.Items.Add("Turbo S");
                comboSeri.Items.Add("Turbo");

            }
            else if (comboMarka.SelectedItem.ToString() == "Panamera")
            {
                comboSeri.Items.Add("Panamera 4 E-Hybrid");
                comboSeri.Items.Add("Panamera Diesel");
                comboSeri.Items.Add("Panamera 4S");

            }
            else if (comboMarka.SelectedItem.ToString() == "Megane")
            {
                comboSeri.Items.Add("1.5 dCi Touch");
                comboSeri.Items.Add("1.5 dCi Expression Plus");

            }
            else if (comboMarka.SelectedItem.ToString() == "Symbol")
            {
                comboSeri.Items.Add("1.5 DCI Joy");
                

            }
            else if (comboMarka.SelectedItem.ToString() == "Clio")
            {
                comboSeri.Items.Add("1.4");
                comboSeri.Items.Add("1.5 dCi Joy");
                comboSeri.Items.Add("1.2 Authentique");
                comboSeri.Items.Add("1.5 dCi Icon");

            }
            else if (comboMarka.SelectedItem.ToString() == "Corollo")
            {
                comboSeri.Items.Add("1.4 D-4D Touch");
                comboSeri.Items.Add("1.4 D-4D Elegant");
                comboSeri.Items.Add("1.8 Hybrid Dream");

            }
            else if (comboMarka.SelectedItem.ToString() == "Auris")
            {
                comboSeri.Items.Add("1.33 Comfort");
                comboSeri.Items.Add("1.6 Advance Skypack");
                comboSeri.Items.Add("1.33 Life");
                

            }
            else if (comboMarka.SelectedItem.ToString() == "Şahin")
            {
                comboSeri.Items.Add("1.6 ie");
                comboSeri.Items.Add("1.6");

            }
            else if (comboMarka.SelectedItem.ToString() == "Kartal")
            {
                comboSeri.Items.Add("Kartal 5 Vites");
                comboSeri.Items.Add("SLX");
                comboSeri.Items.Add("SLX ie");

            }
            else if (comboMarka.SelectedItem.ToString() == "Doğan")
            {
                comboSeri.Items.Add("SLX");
                comboSeri.Items.Add("SL");

            }
            else if (comboMarka.SelectedItem.ToString() == "Jetta")
            {
                comboSeri.Items.Add("1.6 TDI Comfortline");
                comboSeri.Items.Add("1.6 TDI Trendline");

            }
            else if (comboMarka.SelectedItem.ToString() == "Passat ")
            {
                comboSeri.Items.Add("1.6 TDI BlueMotion Comfortline");
                comboSeri.Items.Add("1.8 Highline");
                comboSeri.Items.Add("1.6 TDI Bluemotion Trendline");

            }
            else if (comboMarka.SelectedItem.ToString() == "Polo")
            {
                comboSeri.Items.Add("1.4 Fan Edition");
                comboSeri.Items.Add("1.4 TDI Comfortline");

            }
            else if (comboMarka.SelectedItem.ToString() == "Golf")
            {
                comboSeri.Items.Add("1.6 TDI BlueMotion Highline");
                comboSeri.Items.Add("1.4 TSI Comfortline");

            }
            else if (comboMarka.SelectedItem.ToString() == "S60")
            {
                comboSeri.Items.Add("1.5 T3 Premium");
                comboSeri.Items.Add("1.5 T3 Advance");

            }
            else if (comboMarka.SelectedItem.ToString() == "S80")
            {
                comboSeri.Items.Add("2.5 D5 VIP");
                comboSeri.Items.Add("2.4 D5");

            }
            else if (comboMarka.SelectedItem.ToString() == "V40")
            {
                comboSeri.Items.Add("1.4 D Advance");
                comboSeri.Items.Add("1.4 D Premium");

            }





        }

        private void buttonResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void araçKayıt_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void button_guncelle(object sender, EventArgs e)
        {
            if (tempPlaka == null) return;
            Arac arac = Galeri.getInstance().aracKayit.getAracFromPlaka(tempPlaka);
            Arac aracYeni = getAracFromFields();
            Galeri.getInstance().aracKayit.update(arac, aracYeni);
            foreach (Control item in Controls) if (item is TextBox || item is ComboBox) item.Text = "";
            tempPlaka = null;
            YenileListele();
        }

        private void button_sil(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            Galeri.getInstance().aracKayit.delete(Galeri.getInstance().aracKayit.getAracFromPlaka(satır.Cells["Plaka"].Value.ToString()));
            YenileListele();
        }

        private string tempPlaka = null;
        private void button_tablo(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            tempPlaka = satır.Cells[3].Value.ToString();
            txtKM.Text = satır.Cells[0].Value.ToString();
            txtYıl.Text = satır.Cells[1].Value.ToString();
            txtMotorGücü.Text = satır.Cells[2].Value.ToString();
            txtPlaka.Text = satır.Cells[3].Value.ToString();
            txtFiyat.Text = satır.Cells[4].Value.ToString();
            comboMarka.Text = satır.Cells[5].Value.ToString();
            comboSeri.Text = satır.Cells[6].Value.ToString();
            comboModel.Text = satır.Cells[7].Value.ToString();
            comboYakıt.Text = satır.Cells[8].Value.ToString();
            txtRenk.Text = satır.Cells[9].Value.ToString();
            comboVites.Text = satır.Cells[10].Value.ToString();
            comboÇekiş.Text = satır.Cells[11].Value.ToString();
            comboGaranti.Text = satır.Cells[12].Value.ToString();
            comboKasaTipi.Text = satır.Cells[13].Value.ToString();

            pictureBox2.ImageLocation = satır.Cells[15].Value.ToString();

        }
    }
}
