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
    public partial class fenHonoraire : Form
    {
        fenNouvelleEquipe laNouvelleEquipe;
        public fenHonoraire(fenNouvelleEquipe uneNouvelleEquipe)
        {
            laNouvelleEquipe = uneNouvelleEquipe;
            InitializeComponent();
        }

        private void fenHonoraire_Load(object sender, EventArgs e)
        {

        }
    }
}
