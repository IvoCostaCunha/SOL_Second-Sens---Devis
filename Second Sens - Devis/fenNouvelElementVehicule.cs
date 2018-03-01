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
    public partial class fenNouveauElementVehicule: Form
    {
        fenNouvelleEquipe laEquipe;

        public fenNouveauElementVehicule(fenNouvelleEquipe uneNouvelleEquipe)
        {
            laEquipe = uneNouvelleEquipe;
            InitializeComponent();
        }

        private void fenNouveauElementStreetMarketing_Load(object sender, EventArgs e)
        {
            this.comboBoxTypeVehicule.Items.Add("Vehicule loué");
            this.comboBoxTypeVehicule.Items.Add("Vehicule société");
        }

        private void buttonSupprimerPeage_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPeages.SelectedRows)
            {
                dataGridViewPeages.Rows.RemoveAt(row.Index);
            }
        }

        private void comboBoxTypeVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTypeVehicule.SelectedIndex == 0)
            {
                panelTypeVehiculeEntreprise.Visible = false;
                panelTypeVehiculeLocation.Visible = true;
            }
            else{
                panelTypeVehiculeLocation.Visible = false;
                panelTypeVehiculeEntreprise.Visible = true;
            }
        }

        private void buttonCalculIndemnKm_Click(object sender, EventArgs e)
        { 
            if(textBoxKmParAn.Text != "" && textBoxKmTrajet.Text != "" && textBoxNbCV.Text != "")
            {
                double nbKmAn = Convert.ToDouble(textBoxKmParAn.Text);
                double nbKmTrajet = Convert.ToDouble(textBoxKmTrajet.Text);
                double nbCV = Convert.ToInt32(textBoxNbCV.Text);
            }

            else
            {
                MessageBox.Show("Veuillez renseigner tous les champs");
            }
        }

        private void buttonAjoutPeage_Click(object sender, EventArgs e)
        {
            fenNouveauPeage leNouveauPeage = new fenNouveauPeage(this);
            leNouveauPeage.textBoxVilleDepartPeage.Text = this.textBoxVilleDepart.Text;
            leNouveauPeage.textBoxVilleArriveePeage.Text = this.textBoxVilleArrivee.Text;
            leNouveauPeage.Show();

        }

        private void buttonValiderAjoutVehicule_Click(object sender, EventArgs e)
        {
            double tarifSupplementaire = 0;

            // en cas de vehicule loué
            if (comboBoxTypeVehicule.SelectedIndex == 0)
            {
                double tarifLocation = 0;
                foreach(DataGridViewRow unRow in dataGridViewPeages.Rows)
                {
                    tarifSupplementaire += Convert.ToDouble(unRow.Cells[1]);
                }
                tarifLocation = Convert.ToDouble(textBoxPrixLocationVehicule.Text);
            }
            

        }
    }
}
