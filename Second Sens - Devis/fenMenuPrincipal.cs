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
    public partial class fenMenuPrincipal : Form
    {
        fenChargement leChargement;
        public fenMenuPrincipal(fenChargement unChargement)
        {
            leChargement = unChargement;
            InitializeComponent();
        }

        private void fenMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.buttonAjouterEquipePredefinie.Enabled = false;
            /* champ ajouté exclusivement pour tester */
            this.comboBoxEquipesPrédefinies.Items.Add("test");

            if(leChargement.progressBarChargement.Value == leChargement.progressBarChargement.Maximum)
            {
                leChargement.Hide();
            }
        }

        private void nouveauDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fenNouveauDevis leNouveauDevis = new fenNouveauDevis(this);
            leNouveauDevis.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* button 1 ??? */
            this.panelNouveauDevis.Hide();
        }

        private void comboBoxEquipesPrédefinies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonAjouterEquipePredefinie.Enabled = true;
        }

        private void buttonAjouterEquipePredefinie_Click(object sender, EventArgs e)
        {
            fenNouvelleEquipe laNouvelleEquipe = new fenNouvelleEquipe(this);
            /* modif contrôles si predifini */
            laNouvelleEquipe.Show();
        }

        private void buttonAjoutEquipePersonnalisee_Click(object sender, EventArgs e)
        {
            fenNouvelleEquipe laNouvelleEquipe = new fenNouvelleEquipe(this);
            /* modif contrôles si predifini */
            laNouvelleEquipe.Show();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fenAide laAide = new fenAide(this);
            laAide.Show();
        }

        private void màJLesTarifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fenMajTarifs laMajTarifs = new fenMajTarifs(this);
            laMajTarifs.Show();
        }

        private void buttonResumeDevis_Click(object sender, EventArgs e)
        {
            fenResumeDevis leResumeDevis = new fenResumeDevis(this);
            /* remplir le résumé du devis avec les infos du devis ... */
            leResumeDevis.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
