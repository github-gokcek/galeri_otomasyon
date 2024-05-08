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
    public partial class KontrolSözleşme : UserControl
    {
        public KontrolSözleşme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Başarılı bir şekilde satış tamamlandı.");
                this.Hide();
                KontrolSatınAlma kontrolSatınAlma = new KontrolSatınAlma();
                kontrolSatınAlma.Show();
            }
        }
    }
}
