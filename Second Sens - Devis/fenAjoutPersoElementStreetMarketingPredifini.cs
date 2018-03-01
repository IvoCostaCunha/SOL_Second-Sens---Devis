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
    public partial class fenAjoutPersoElementStreetMarketingPredifini : Form
    {
        fenNouvelElementStreetMarketing leNouveauElementStreetMarketing;

        public fenAjoutPersoElementStreetMarketingPredifini(fenNouvelElementStreetMarketing unNouveauElementStreetMarketing)
        {
            leNouveauElementStreetMarketing = unNouveauElementStreetMarketing;
            InitializeComponent();
        }

        private void fenAjoutPersoElementStreetMarketing_Load(object sender, EventArgs e)
        {
                    
        }
    }
}
