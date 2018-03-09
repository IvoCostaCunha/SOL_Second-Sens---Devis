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
    public partial class fenAjoutElementPerso : Form
    {
        fenNouvelElementPersonnalisable leNouveauElementStreetMarketing;

        public fenAjoutElementPerso(fenNouvelElementPersonnalisable unNouveauElementStreetMarketing)
        {
            leNouveauElementStreetMarketing = unNouveauElementStreetMarketing;
            InitializeComponent();
        }

        public fenAjoutElementPerso()
        {
            InitializeComponent();
        }

        private void fenAjoutPersoElementStreetMarketing_Load(object sender, EventArgs e)
        {
                    
        }

        private void textBoxTarifPersonnalisationPredefinie_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTarifPersonnalisationPredefinie.Text != "") 
            {
                try
                {
                    textBoxMarge.Text = Convert.ToString(Convert.ToDouble(textBoxTarifPersonnalisationPredefinie.Text) - Convert.ToDouble(textBoxCoutRevient.Text));
                }
                catch (Exception)
                {

                    //MessageBox.Show("Veuillez n'entrer que des nombres");
                }
            }
            
        }

        private void textBoxCoutRevient_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCoutRevient.Text != "")
            {
                try
                {
                    textBoxMarge.Text = Convert.ToString(Convert.ToDouble(textBoxTarifPersonnalisationPredefinie.Text) - Convert.ToDouble(textBoxCoutRevient.Text));
                }
                catch (Exception)
                {

                    //MessageBox.Show("Veuillez n'entrer que des nombres");
                }
            }
        }

        private void buttonAjouterPersonnalisationPredefinie_Click(object sender, EventArgs e)
        {
            try
            {
                String requeteNbTarif = "SELECT count(*) from tarifs";
                requetesMySQL laRequeteNbTarif = new requetesMySQL();
                List<int> leNombreTarifs = laRequeteNbTarif.queryInt(requeteNbTarif);
                int leNombreIdTarif = leNombreTarifs[0];
                string leIdElementTarif = "TA";
                string leVraiIdTarif = leIdElementTarif.Insert(2, leNombreIdTarif.ToString());
                //String requeteInsertTarif = "INSERT INTO tarifs VALUES ('" + leVraiIdTarif + "'," +  + "', '" + comboBoxType.SelectedItem + "', '"

                String requeteNombre = "SELECT count(*) from element_personnalisable";
                requetesMySQL laRequeteNombre = new requetesMySQL();
                List<int> leNombre = laRequeteNombre.queryInt(requeteNombre);
                int leNombreId = leNombre[0];
                string leIdElement = "ELP";
                string leVraiId = leIdElement.Insert(3, leNombreId.ToString());
                //String requeteInsert = "INSERT INTO element_personnalisable VALUES ('" + leVraiId + "'," + textBoxNom.Text + "', '" + comboBoxType.SelectedItem + "', '"
            }
            catch (Exception erreur)
            {

                MessageBox.Show(erreur.ToString());
            }
            
        }
    }
}
