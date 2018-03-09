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
        classElement leElement;
        classTarif leTarifs;
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
            dataGridViewTarifHeure.Rows.Clear();
            dataGridViewTarifJour.Rows.Clear();
            String requete = "SELECT coutHoraire, coutRevientHoraire, margeHoraire from tarifs, elements where tarifs.idTarif = elements.idTarif and nomElement ='" + comboBoxTypeElem.SelectedItem.ToString() + "'";
            requetesMySQL laRequete = new requetesMySQL();
            List<Double> lesPrixElement = laRequete.queryDouble(requete);

            String requete2 = "SELECT coutJour, coutRevientJour, margeJour from tarifs, elements where tarifs.idTarif = elements.idTarif and nomElement = '" + comboBoxTypeElem.SelectedItem.ToString() + "'";
            requetesMySQL laRequete2 = new requetesMySQL();
            List<Double> lesPrixElementJour = laRequete2.queryDouble(requete2);
            try
            {
                dataGridViewTarifHeure.Rows.Add(lesPrixElement[0].ToString(), lesPrixElement[1].ToString(), lesPrixElement[2].ToString());
            }
            catch (Exception)
            {
                dataGridViewTarifHeure.Rows.Add("Pas de tarif", "Pas de tarif", "Pas de tarif");
            }
            try
            { 
                dataGridViewTarifJour.Rows.Add(lesPrixElementJour[0].ToString(), lesPrixElementJour[1].ToString(), lesPrixElementJour[2].ToString());
            }
            catch (Exception)
            {

                dataGridViewTarifJour.Rows.Add("Pas de tarif", "Pas de tarif", "Pas de tarif");
            }
            try
            {
                if (lesPrixElement.Count == 0 && lesPrixElementJour.Count != 0)
                {
                    leTarifs = new classTarif(0, 0, 0, lesPrixElementJour[0], lesPrixElementJour[1], lesPrixElementJour[2]);
                }
                else if (lesPrixElementJour.Count == 0 && lesPrixElement.Count != 0)
                {
                    leTarifs = new classTarif(lesPrixElement[0], lesPrixElement[1], lesPrixElement[2], 0, 0, 0);
                }
                else if (lesPrixElement.Count > 0 && lesPrixElementJour.Count > 0)
                {
                    leTarifs = new classTarif(lesPrixElement[0], lesPrixElement[1], lesPrixElement[2], lesPrixElementJour[0], lesPrixElementJour[1], lesPrixElementJour[2]);
                }
                //classTarif leTarifs = new classTarif(lesPrixElement[0], lesPrixElement[1], lesPrixElement[2], lesPrixElementJour[0], lesPrixElementJour[1], lesPrixElementJour[2]); 
            }
            catch (Exception erreur)
            {

                MessageBox.Show("erreur de classe" + erreur);
            }
             
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                classElement leNouvelElement = new classElement(textBoxNomElement.Text.ToString(), leTarifs, Convert.ToInt32(textBoxQteElement.Text), Convert.ToInt32(textBoxnbHparJour.Text), Convert.ToInt32(textBoxnbJours.Text));
                laNouvelleEquipe.laEquipe.getLesElements().Add(leNouvelElement);
                laNouvelleEquipe.majListeEquipes();
            }

            catch (Exception erreur)
            {
                MessageBox.Show(erreur.ToString());
            }
        }
    }
}
