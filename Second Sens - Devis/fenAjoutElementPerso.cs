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

                    MessageBox.Show("Veuillez n'entrer que des nombres");
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

                    MessageBox.Show("Veuillez n'entrer que des nombres");
                }
            }
        }
    }
}
