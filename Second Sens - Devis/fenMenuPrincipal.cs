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
        public classMetier.classDevis leNouveauDevis;
        public fenMenuPrincipal(fenChargement unChargement)
        {
            leChargement = unChargement;
            InitializeComponent();
        }


        private void fenMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.dataGridViewAjoutDivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHonoraire.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.buttonAjouterEquipePredefinie.Enabled = false;
            /* champ ajouté exclusivement pour tester */
            this.comboBoxEquipesPrédefinies.Items.Add("test");
            radioButtonEnHeures.Checked = true;

            if(leChargement.progressBarChargement.Value == leChargement.progressBarChargement.Maximum)
            {
                leChargement.Hide();
            }
        }

        private void nouveauDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fenNouveauDevis leNouveauDevis = new fenNouveauDevis(this);
            leNouveauDevis.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
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
            laNouvelleEquipe.ShowDialog();
        }

        private void buttonAjoutEquipePersonnalisee_Click(object sender, EventArgs e)
        {
            fenNouvelleEquipe laNouvelleEquipe = new fenNouvelleEquipe(this);
            /* modif contrôles si predifini */
            laNouvelleEquipe.ShowDialog();
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

        private void btnNouvelleEquipePerso_Click(object sender, EventArgs e)
        {
            fenNouvelleEquipe uneNouvelleEquipePerso = new fenNouvelleEquipe(this);
            uneNouvelleEquipePerso.ShowDialog();
        }

        private void buttonAjouterHonoraire_Click(object sender, EventArgs e)
        {
            string typeDuree;
            if(textBoxNomHonoraire.Text != "" && textBoxDuree.Text != "")
            {
                try
                {
                    Convert.ToInt32(textBoxDuree.Text);
                    Convert.ToInt32(textBoxNombreHonoraires.Text);
                    if (radioButtonEnHeures.Checked == true) 
                    {
                        typeDuree = "heures";
                    }
                    else
	                {
                        typeDuree = "jours";
                    }
                    dataGridViewHonoraire.Rows.Add(textBoxNomHonoraire.Text, textBoxDuree.Text, textBoxNombreHonoraires.Text, typeDuree);
                }
                catch (Exception erreur)
                {

                    MessageBox.Show("Les champs durée et nombre ne peuvent être remplis qu'avec des nombres.");
                }
                
            }
            
        }

        private void panelNouveauDevis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonSupprimerHonoraire_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow unRow in dataGridViewHonoraire.SelectedRows)
            {
                dataGridViewHonoraire.Rows.Remove(unRow);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBoxNomDivers.Text != "" && textBoxTarifDivers.Text != "")
            {
                dataGridViewAjoutDivers.Rows.Add(textBoxNomDivers.Text, textBoxTarifDivers.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow unRow in dataGridViewAjoutDivers.SelectedRows)
            {
                dataGridViewAjoutDivers.Rows.Remove(unRow);
            }
        }

        private void elementPersonnalisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fenAjoutElementPerso leNouvelElementPerso = new fenAjoutElementPerso(this);
        }
    }
}
