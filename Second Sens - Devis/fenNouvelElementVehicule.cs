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

        private void buttonValiderAjoutVehicule_Click(object sender, EventArgs e)
        {
            String nomElement = textBoxNomVehicule.Text;
            int laQteVehicule = Convert.ToInt32(textBoxQteVehicule.Text);

            classMetier.classTarif leTarif = new classMetier.classTarif(0,0,0,Convert.ToDouble(dataGridViewTarifsVehicule.Rows[0].Cells[0]), Convert.ToDouble(dataGridViewTarifsVehicule.Rows[0].Cells[1]), Convert.ToDouble(dataGridViewTarifsVehicule.Rows[0].Cells[2]));
            if(comboBoxTypeVehicule.SelectedItem.ToString() == "Vehicule loué")
            {
                classMetier.classElement leVehicule = new classMetier.classElement(nomElement, leTarif, laQteVehicule);
            }
            if(comboBoxTypeVehicule.SelectedItem.ToString() == "Vehicule société")
            {

            }
        }

        private void buttonCalculerPrixVehicule_Click(object sender, EventArgs e)
        {

        }
    }
}
