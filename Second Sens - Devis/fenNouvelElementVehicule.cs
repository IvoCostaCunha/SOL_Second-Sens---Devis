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
        classVehiculeSociete leVehiculeSociete;
        classElement leVehicule;
        classIndemKm laIndemKm;

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
            String requete = "SELECT coef,coef2 FROM indemnkm where nbCV=" + unNbCV.ToString() + " and nbKmAn='";
            if(desKmAn >= 5000 && desKmAn <= 20000)
            {
                requete += "20000'";
            }
            else if (desKmAn < 5000)
            {
                requete += "5000'";
            }
            else
            {
                requete += "max'";
            }
            MessageBox.Show(requete);
            requetesMySQL laRequete = new requetesMySQL();
            List<double> lesResultats = laRequete.queryDouble(requete);
            double calcul = 0;

            if (desKmAn >= 5000 && desKmAn <= 20000)
            {
                calcul = (lesResultats[0] * desKmAn) * lesResultats[1];
                laIndemKm = new classIndemKm(unNbCV, lesResultats[0], lesResultats[1], Convert.ToInt32(DateTime.Now.ToString("yyyy")), desKmAn);
            }

            else
            {
                calcul = lesResultats[0] * desKmAn;
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

            classTarif leTarif = new classTarif(0,0,0,Convert.ToDouble(dataGridViewTarifsVehicule.Rows[0].Cells[0].ToString()), Convert.ToDouble(dataGridViewTarifsVehicule.Rows[0].Cells[1].ToString()), Convert.ToDouble(dataGridViewTarifsVehicule.Rows[0].Cells[2].ToString()));
            if(comboBoxTypeVehicule.SelectedItem.ToString() == "Vehicule loué")
            {
                leVehicule = new classElement(nomElement, leTarif, laQteVehicule);
                laEquipe.laEquipe.ajouterElement(leVehicule);
            }
            if(comboBoxTypeVehicule.SelectedItem.ToString() == "Vehicule société")
            {
                leVehiculeSociete = new classVehiculeSociete(nomElement, leTarif, laQteVehicule, laIndemKm);
                laEquipe.laEquipe.ajouterUnVehiculeSociete(leVehiculeSociete);
            }
            laEquipe.majListeEquipes();
        }

        private void buttonCalculerPrixVehicule_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifsVehicule.Rows.Count > 0)
            {
                dataGridViewTarifsVehicule.Rows.Remove(dataGridViewTarifsVehicule.Rows[0]);
            }
            double prixVehicule = 0;

            int leNbVehicules = Convert.ToInt32(textBoxQteVehicule.Text);
            int leNbJours = Convert.ToInt32(textBoxNbJoursLocation.Text);
            double leTarifPeages = Convert.ToDouble(textBoxPeage.Text);

            if(comboBoxTypeVehicule.SelectedIndex == 0)
            {
                double leTarifCarburant = Convert.ToDouble(textBoxTarifCarburant.Text);
                double leTarifLocation = Convert.ToDouble(textBoxPrixLocationVehicule.Text);
                prixVehicule = leNbVehicules * leNbJours * (leTarifLocation + 2 * (leTarifPeages * 1.15 + leTarifCarburant * 1.2));
            }

            else if(comboBoxTypeVehicule.SelectedIndex == 1)
            {
                double laDistanceTrajet = Convert.ToDouble(textBoxKmTrajet.Text);
                int leNbCV = Convert.ToInt32(textBoxNbCV.Text);

                if(leNbCV <= 3)
                {
                    leNbCV = 3;
                }
                else if(leNbCV > 3 && leNbCV <= 5)
                {
                    leNbCV = 5;
                }
                else if(leNbCV >= 7)
                {
                    leNbCV = 7;
                }

                double lesKmAn = Convert.ToDouble(textBoxKmParAn.Text);
                double indemKm = calculIndemKm(leNbCV,lesKmAn);

                prixVehicule = leNbVehicules * leNbJours * ((laDistanceTrajet * 2) + (indemKm * 1.3) + (leTarifPeages * 1.15));
            }

            dataGridViewTarifsVehicule.Rows.Add(prixVehicule.ToString(), (prixVehicule * 0.5).ToString(), (prixVehicule * 0.5).ToString());
            this.buttonValiderAjoutVehicule.Enabled = true;
        }
    }
}
