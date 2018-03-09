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
    public partial class fenNouvelElementPersonnalisable : Form
    {
        fenNouvelleEquipe laNouvelleEquipe;

        /// <summary>
        /// Fonction qui retourne la liste des éléménts personnalisables de la BdD
        /// </summary>
        /// <returns></returns>
        private List<String> getNomsElementsPersonnalisables()
        {
            String requete = "SELECT nomElementPerso FROM element_personnalisable";
            requetesMySQL laRequete = new requetesMySQL();
            return laRequete.queryString(requete);
        }

        public fenNouvelElementPersonnalisable(fenNouvelleEquipe uneNouvelleEquipe)
        {
            laNouvelleEquipe = uneNouvelleEquipe;
            InitializeComponent();
        }

        private void fenNouvelElementPersonnalisable_Load(object sender, EventArgs e)
        {
            foreach(String unElement in getNomsElementsPersonnalisables())
            {
                comboBoxTypeElementStreetMarketing.Items.Add(unElement);
            }
        }

        private void buttonAjouterPersonnalisation_Click(object sender, EventArgs e)
        {
            fenAjoutPersoElementStreetMarketingPredifini unElementPersoPredefini = new fenAjoutPersoElementStreetMarketingPredifini(this);
            unElementPersoPredefini.ShowDialog();
        }

        private void checkBoxAjoutPersonnalisation_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAjoutPersonnalisation.Checked)
            {
                panelPersonalisation.Visible = true;
            }
            else if (!checkBoxAjoutPersonnalisation.Checked)
            {
                panelPersonalisation.Visible = false;
                /* +virer tout ce qui était dedans */
            }
        }

        private void buttonAjouterPersonnel_Click(object sender, EventArgs e)
        {
            fenAjoutPersonnel unNouveauPersonnel = new fenAjoutPersonnel(this);
            unNouveauPersonnel.ShowDialog();
        }

        private void textBoxTarifElement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
