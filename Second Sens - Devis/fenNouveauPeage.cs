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
    public partial class fenNouveauPeage : Form
    {
        fenNouveauElementVehicule leNouveauElementVehicule;

        public fenNouveauPeage(fenNouveauElementVehicule unNouveauElementVehicule)
        {
            leNouveauElementVehicule = unNouveauElementVehicule;
            InitializeComponent();
        }

        private void fenNouveauPeage_Load(object sender, EventArgs e)
        {
            this.textBoxVilleArriveePeage.Enabled = false;
            this.textBoxVilleDepartPeage.Enabled = false;
        }

        private void buttonAjouterPeage_Click(object sender, EventArgs e)
        {
            if (this.checkBoxAllerRetour.Checked)
            {
                leNouveauElementVehicule.dataGridViewPeages.Rows.Add(this.textBoxNomPeage.Text, (Convert.ToInt32(this.textBoxTarifPeage.Text) * 2).ToString(), "Oui");
            }
            else
            {
                leNouveauElementVehicule.dataGridViewPeages.Rows.Add(this.textBoxNomPeage.Text, this.textBoxTarifPeage.Text, "Non");
            }
            this.Hide();
        }
    }
}
