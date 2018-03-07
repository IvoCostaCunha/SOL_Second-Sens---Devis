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
            String requete = "SELECT nomElement from elements";
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
            foreach(String unElement in getNomsElem())
            {
                comboBoxTypeElem.Items.Add(unElement);
            }
        }
    }
}
