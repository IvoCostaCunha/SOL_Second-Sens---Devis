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

        private double calculIndemKm(int unNbCV, double desKmAn)
        {
            String requete = "SELECT coef,coef2 FROM indemnkm where nbCV=" + unNbCV.ToString() + " and nbKmAn="
                + desKmAn;ToString();
            requetesMySQL laRequete = new requetesMySQL();
            List<double> lesResusltats = laRequete.queryDouble(requete);
            double calcul = 0;

            if(desKmAn >= 5000 && desKmAn >= 20000)
            {
                calcul = (lesResusltats[0] * desKmAn) * lesResusltats[1];
            }

            else
            {
                calcul = lesResusltats[0] * desKmAn;
            }

            return calcul;
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
            double prixVehicule = 0;

            int leNbVehicules = Convert.ToInt32(textBoxQteVehicule.Text);
            int leNbJours = Convert.ToInt32(textBoxNbJoursLocation.Text);
            double laDistanceTrajet = Convert.ToDouble(textBoxKmTrajet.Text);
            double leTarifPeages = Convert.ToDouble(textBoxPeage.Text);

            if(comboBoxTypeVehicule.SelectedIndex == 0)
            {
                double leTarifCarburant = Convert.ToDouble(textBoxTarifCarburant.Text);
                double leTarifLocation = Convert.ToDouble(textBoxPrixLocationVehicule.Text);
                prixVehicule = leNbVehicules * leNbJours * (leTarifLocation + 2 * (leTarifPeages * 1.15 + leTarifCarburant * 1.2));
            }

            else if(comboBoxTypeVehicule.SelectedIndex == 1)
            {
                int leNbCV = Convert.ToInt32(textBoxNbCV.Text);
                double lesKmAn = Convert.ToDouble(textBoxKmParAn.Text);
                double indemKm = calculIndemKm(leNbCV,lesKmAn);

                prixVehicule = leNbVehicules * leNbJours * (laDistanceTrajet * 2 * indemKm * 1.3 + leTarifPeages * 1.15);
            }

            dataGridViewTarifsVehicule.Rows.Add(prixVehicule.ToString(), (prixVehicule * 0.5).ToString(), (prixVehicule * 0.5).ToString());
        }
    }
}
