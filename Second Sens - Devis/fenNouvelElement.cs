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
    public partial class fenNouvelElement : Form
    {
        fenNouvelleEquipe laNouvelleEquipe;

        private List<String> getNomsElem()
        {
            String requete = "SELECT nomElement from elements where type_element <> 'honoraire'";
            requetesMySQL laRequete = new requetesMySQL();
            return laRequete.queryString(requete);
        }

        public fenNouvelElement(fenNouvelleEquipe uneNouvelleEquipe)
        {
            laNouvelleEquipe = uneNouvelleEquipe;
            InitializeComponent();
        }

        private void fenNouvelElement_Load(object sender, EventArgs e)
        {
            foreach (String unElement in getNomsElem())
            {
                comboBoxTypeElem.Items.Add(unElement);
            }
        }
        private void comboBoxTypeElem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String requete = "SELECT coutHoraire, coutRevientHoraire, margeHoraire from tarifs, elements where tarifs.idTarif = elements.idTarif and nomElement ='" + comboBoxTypeElem.SelectedItem.ToString() + "'";
                MessageBox.Show(requete);
                requetesMySQL laRequete = new requetesMySQL();
                List<Double> lesPrixElement = laRequete.queryDouble(requete);
                dataGridViewTarifHeure.Rows.Add(lesPrixElement[0].ToString(), lesPrixElement[1].ToString(), lesPrixElement[2].ToString());
            }
            catch (Exception)
            {
                dataGridViewTarifHeure.Rows.Add("Pas de tarif", "Pas de tarif", "Pas de tarif");
            }
            try
            {
                String requete2 = "SELECT coutJour, coutRevientJour, margeJour from tarifs, elements where tarifs.idTarif = elements.idTarif and nomElement =" + comboBoxTypeElem.SelectedItem.ToString() + "'";
                requetesMySQL laRequete2 = new requetesMySQL();
                List<Double> lesPrixElementJour = laRequete2.queryDouble(requete2);
                dataGridViewTarifJour.Rows.Add(lesPrixElementJour[0].ToString(), lesPrixElementJour[1].ToString(), lesPrixElementJour[2].ToString());
            }
            catch (Exception)
            {

                dataGridViewTarifJour.Rows.Add("Pas de tarif", "Pas de tarif", "Pas de tarif");
            }
            
        }
    }
}
