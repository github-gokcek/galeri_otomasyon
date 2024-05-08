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
    public partial class KontrolAraçListele : UserControl
    {
        public KontrolAraçListele()
        {
            InitializeComponent();
        }
        private void YenileListele()
        {
            //advancedDataGridView1.DataSource = Galeri.getInstance().aracKayit.getDataTable();
        }

        private void KontrolAraçListele_Load(object sender, EventArgs e)
        {
            //YenileListele();
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
