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
    
    public partial class AracListeForm : Form
    {
        public AracListeForm()
        {
            InitializeComponent();
        }

        private void AraçListeleme_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
        private void YenileListele()
        {            
            advancedDataGridView1.DataSource = Galeri.getInstance().aracKayit.getDataTable();
        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {
            


            
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtYıl_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtJoker_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            YenileListele();
        }
    }
}
