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
    public partial class fenNouveauFraisTechnique : Form
    {
        fenNouvelleEquipe laNouvelleEquipe;

        public fenNouveauFraisTechnique(fenNouvelleEquipe uneNouvelleEquipe)
        {
            laNouvelleEquipe = uneNouvelleEquipe;
            InitializeComponent();
        }

        private void fenNouveauFraisTechnique_Load(object sender, EventArgs e)
        {

        }
    }
}
