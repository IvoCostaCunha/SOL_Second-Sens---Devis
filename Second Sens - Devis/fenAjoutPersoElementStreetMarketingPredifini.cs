using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Sens___Devis
{
    public partial class fenAjoutElementPerso : Form
    {
        fenNouvelElementPersonnalisable leNouveauElementStreetMarketing;

        public fenAjoutElementPerso(fenNouvelElementPersonnalisable unNouveauElementStreetMarketing)
        {
            leNouveauElementStreetMarketing = unNouveauElementStreetMarketing;
            InitializeComponent();
        }

        private void fenAjoutPersoElementStreetMarketing_Load(object sender, EventArgs e)
        {
                    
        }
    }
}
