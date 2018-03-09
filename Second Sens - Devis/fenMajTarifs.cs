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
    public partial class fenMajTarifs : Form
    {
        fenMenuPrincipal leMenuPrincipal;

        public fenMajTarifs(fenMenuPrincipal unMenuPrinciapal)
        {
            leMenuPrincipal = unMenuPrinciapal;
            InitializeComponent();
        }

        private void fenMajTarifs_Load(object sender, EventArgs e)
        {
            /*String requete = "SELECT coutHoraire, coutRevientHoraire, margeHoraire from tarifs, elements where tarifs.idTarif = elements.idTarif and nomElement";
            MessageBox.Show(requete);
            requetesMySQL laRequete = new requetesMySQL();
            List<Double> lesPrixElement = laRequete.queryDouble(requete);
            dataGridViewTarifsGeneraux.Rows.Add(lesPrixElement[0].ToString(), lesPrixElement[1].ToString(), lesPrixElement[2].ToString()); */
        }

        private void buttonAnnulerModif_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            /* MàJ de la base de données */
        }
    }
}
