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
    public partial class fenAjoutModelPersoPersonnalisation : Form
    {
        fenNouvelElementStreetMarketing leNouvelElementStreetMarketing;
        public fenAjoutModelPersoPersonnalisation(fenNouvelElementStreetMarketing unNouvelElementStreetMarketing)
        {
            leNouvelElementStreetMarketing = unNouvelElementStreetMarketing;
            InitializeComponent();
        }

        private void fenAjoutModelPersoPersonnalisation_Load(object sender, EventArgs e)
        {

        }
    }
}
