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
    public partial class fenAjoutPersonnel : Form
    {
        fenNouvelleEquipe laNouvelleEquipe;
        fenNouvelElementPersonnalisable leNouvelElementSM;

        //constructeur en cas de "parent" fenLaNouvelleEquipe
        public fenAjoutPersonnel(fenNouvelleEquipe uneNouvelleEquipe)
        {
            laNouvelleEquipe = uneNouvelleEquipe;
            InitializeComponent();
        }


        //constructeur en cas de "parent" fenNouveauPersonnel
        public fenAjoutPersonnel(fenNouvelElementPersonnalisable unNouvelElementST)
        {
            leNouvelElementSM = unNouvelElementST;
            InitializeComponent();
        }

        private void fenHotesse_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTypePersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTypePersonnel.SelectedIndex == 0)
            {
                panelPersoHot.Enabled = true;
            }
            else if(comboBoxTypePersonnel.SelectedIndex != 0)
            {
                panelPersoHot.Enabled = false;
            }
        }
    }
}
