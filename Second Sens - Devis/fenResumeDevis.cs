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
    public partial class fenResumeDevis : Form
    {
        fenMenuPrincipal leMenuPrincipal;

        public fenResumeDevis(fenMenuPrincipal unMenuPrincipal)
        {
            leMenuPrincipal = unMenuPrincipal;
            InitializeComponent();
        }

        private void fenResumeDevis_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNouveauDevis_Click(object sender, EventArgs e)
        {
            leMenuPrincipal.panelNouveauDevis.Hide();
            fenNouveauDevis unNouveauDevis = new fenNouveauDevis(leMenuPrincipal);
            unNouveauDevis.Show();
            this.Hide();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
