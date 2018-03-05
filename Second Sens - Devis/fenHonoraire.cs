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
    public partial class fenHonoraire : Form
    {
        fenNouvelleEquipe laNouvelleEquipe;
        int numNomHon = 1;

        public fenHonoraire(fenNouvelleEquipe uneNouvelleEquipe)
        {
            laNouvelleEquipe = uneNouvelleEquipe;
            InitializeComponent();
        }

        private void fenHonoraire_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBoxTypeTarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTypeTarif.SelectedIndex == 0)
            {
                dataGridViewListeHonoraires.Columns[1].HeaderText = "Tarif / heure";
                dataGridViewListeHonoraires.Columns[3].Visible = false;
                dataGridViewListeHonoraires.Columns[2].Visible = true;
            }
            else if(comboBoxTypeTarif.SelectedIndex == 1)
            {
                dataGridViewListeHonoraires.Columns[1].HeaderText = "Tarif / jour";
                dataGridViewListeHonoraires.Columns[2].Visible = false;
                dataGridViewListeHonoraires.Columns[3].Visible = true;
            }
            this.panelFenHonoraire.Visible = true;
        }

        private void checkBoxModeleExistant_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModeleExistant.Checked)
            {
                checkBoxModelePerso.Checked = false;
                panelModelePerso.Visible = false;
                panelModeleExistant.Visible = true;
            }
        }

        private void checkBoxModelePerso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModelePerso.Checked)
            {
                checkBoxModeleExistant.Checked = false;
                panelModeleExistant.Visible = false;
                panelModelePerso.Visible = true;
            }
        }

        private void buttonAjouterHonoraire_Click(object sender, EventArgs e)
        {
            String nomHon = "";
            double tarifHon = 0;
            double nbHeureJourHon = 0;

            if (checkBoxModeleExistant.Checked)
            { 
                // a vérifier si comboBoxTypeHonoraire.SelectedItem peut être null si le champ est vide
                if(comboBoxTypeHonoraire.SelectedItem != null && textBoxNbHeureModeleEx.Text != "" && textBoxTarifHeureModeleEx.Text != "")
                {
                    //Ajout d'un entier devant le nom de l'honoraire existant pour le direncier des autres
                    nomHon = comboBoxTypeHonoraire.SelectedItem.ToString() + numNomHon.ToString();
                    numNomHon += 1;

                    tarifHon = Convert.ToDouble(textBoxTarifHeureModeleEx.Text);
                    nbHeureJourHon = Convert.ToDouble(textBoxNbHeureModeleEx.Text);

                    //ajout dans la dataGridView
                    //si tarif en heures
                    if(comboBoxTypeTarif.SelectedIndex == 0)
                    {
                        dataGridViewListeHonoraires.Rows.Add(nomHon, tarifHon.ToString(), nbHeureJourHon.ToString(), null);
                    }
                    //si tarif en jours
                    else if(comboBoxTypeTarif.SelectedIndex == 1)
                    {
                        dataGridViewListeHonoraires.Rows.Add(nomHon, tarifHon.ToString(), null, nbHeureJourHon.ToString());
                    }
                    

                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
            }
            else if (checkBoxModelePerso.Checked)
            {
                if (textBoxNomHonoraireModPerso.Text != "" && textBoxNbHeuresHonoraireModPerso.Text != "" && textBoxTarifHeureModPerso.Text != "")
                {
                    nomHon = textBoxNomHonoraireModPerso.Text;

                    tarifHon = Convert.ToDouble(textBoxTarifHeureModPerso.Text);
                    nbHeureJourHon = Convert.ToDouble(textBoxNbHeuresHonoraireModPerso.Text);

                    //ajout dans la dataGridView
                    //si tarif en heures
                    if (comboBoxTypeTarif.SelectedIndex == 0)
                    {
                        dataGridViewListeHonoraires.Rows.Add(nomHon, tarifHon.ToString(), nbHeureJourHon.ToString(), null);
                    }
                    //si tarif en jours
                    else if (comboBoxTypeTarif.SelectedIndex == 1)
                    {
                        dataGridViewListeHonoraires.Rows.Add(nomHon, tarifHon.ToString(), null, nbHeureJourHon.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
                comboBoxTypeTarif.Enabled = false;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSupprimerHonoraire_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewListeHonoraires.SelectedRows)
            {
                dataGridViewListeHonoraires.Rows.RemoveAt(row.Index);
            }
        }
    }
}
