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
    public partial class fenNouvelleEquipe : Form
    {
        fenMenuPrincipal leMenuPrincipal;

        public fenNouvelleEquipe(fenMenuPrincipal unMenuPrincipal)
        {
            leMenuPrincipal = unMenuPrincipal;
            InitializeComponent();
        }

        private void fenNouvelleEquipe_Load(object sender, EventArgs e)
        {

        }

        private void buttonAnnulerEquipe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAjouterElementPredefini_Click(object sender, EventArgs e)
        {
            fenNouvelElement leNouvelElement = new fenNouvelElement(this);
            /* charger les infos présentes sur la base en fonction de ce qui la selection de la comboBox */
            leNouvelElement.Show();
        }

        private void buttonAjouterElementStreetMarketing_Click(object sender, EventArgs e)
        {
            fenNouvelElementStreetMarketing leNouvelElementStreetMarketing = new fenNouvelElementStreetMarketing(this);
            leNouvelElementStreetMarketing.Show();
        }

        private void buttonAjouterHonorairePredifini_Click(object sender, EventArgs e)
        {
            fenHonoraire leNouveauHonoraire = new fenHonoraire(this);
            leNouveauHonoraire.Show();
        }

        private void buttonAjouterPersonnel_Click(object sender, EventArgs e)
        {
            fenAjoutPersonnel leNouveauPersonnel = new fenAjoutPersonnel(this);
            leNouveauPersonnel.Show();
        }

        private void buttonAjouterVehicule_Click(object sender, EventArgs e)
        {
            fenNouveauElementVehicule leNouveauVehicule = new fenNouveauElementVehicule(this);
            leNouveauVehicule.Show();
        }
    }
}
 