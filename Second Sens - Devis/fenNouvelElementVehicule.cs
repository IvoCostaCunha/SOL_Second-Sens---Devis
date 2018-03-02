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
            double tarifPeages = 0;
            double calculTotal = 0;

            foreach (DataGridViewRow unRow in dataGridViewPeages.Rows)
            {
                tarifPeages += Convert.ToDouble(unRow.Cells[1].Value);
            }

            // En cas de vehicule loué
            if (comboBoxTypeVehicule.SelectedIndex == 0)
            {
                // Calcul tarif vehicule 
                double tarifLocation = Convert.ToDouble(textBoxPrixLocationVehicule.Text);
                int nbJoursLocation = Convert.ToInt32(textBoxNbJoursLocation.Text);
                int nbVehicules = Convert.ToInt32(textBoxQteVehicule.Text);
                double tarifCarburant = Convert.ToDouble(textBoxTarifCarburant.Text);

                calculTotal = nbVehicules * nbJoursLocation * (tarifLocation + 2 * (tarifPeages * 1.15 + tarifCarburant * 1.2));
            }

            // En cas de vehicule société
            else if (comboBoxTypeVehicule.SelectedIndex == 1)
            {
                // Calcul tarif vehicule société


                double nbKmAn = Convert.ToDouble(textBoxKmParAn.Text);
                int nbCVVehicule = Convert.ToInt32(textBoxNbCV.Text);
                
                //Si le nb de CV > 7 il est est ramené a 7 pour correspondre a la BdD
                if(nbCVVehicule > 7)
                {
                    nbCVVehicule = 7;
                }

                int nbVehicule = Convert.ToInt32(textBoxQteVehicule.Text);
                int nbJoursLocation = Convert.ToInt32(textBoxNbJoursLocation.Text);
                double kmTrajet = Convert.ToInt32(textBoxKmTrajet.Text);
                

                /* 
                 * Requête MySQL pour récuperer les coeficients d'indemnité kilometrique en
                 * fonction du nb de km par an et du nb de CV du vehicule
                 */

                String requeteMySql = "";

                if (nbKmAn < 5000)
                {
                    requeteMySql = "SELECT coef,coef2 FROM INDEMKM " +
                        "WHERE nbCV=" + nbCVVehicule + " and nbKmAn='5000'";
                }
                else if(nbKmAn >= 5000 && nbKmAn <= 20000)
                {
                    requeteMySql = "SELECT coef,coef2 FROM INDEMKM " +
                        "WHERE nbCV=" + nbCVVehicule + " and nbKmAn='20000'";
                }
                else if(nbKmAn > 20000)
                {
                    requeteMySql = "SELECT coef,coef2 FROM INDEMKM " +
                        "WHERE nbCV=" + nbCVVehicule + " and nbKmAn='max'";
                }
          
                requetesMySQL uneRequete = new requetesMySQL();
                List<double> listCoeficients = uneRequete.queryDouble(requeteMySql);
                double coefIndemKm = 0;

                // Si il y a 2 coeficients
                if(listCoeficients.Count > 1)
                {
                    coefIndemKm = (listCoeficients[0] * nbKmAn) + listCoeficients[1];
                }

                //Si il y a 1 coeficient
                else if(listCoeficients.Count == 1)
                {
                    coefIndemKm = listCoeficients[0] * nbKmAn;
                }

                calculTotal = nbVehicule * nbJoursLocation * (kmTrajet * 2 * coefIndemKm * 1.3 * tarifPeages * 1.15);
            }

            // Ajout a la fenetre 
            laEquipe.dataGridViewVehiculesAjoutes.Rows.Add(textBoxNomVehicule.Text, calculTotal.ToString());
            this.Hide();
        }
    }
}
