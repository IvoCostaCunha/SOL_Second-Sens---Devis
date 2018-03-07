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
    public partial class fenChargement : Form
    {
        public fenChargement()
        {
            InitializeComponent();
        }

        private void fenChargement_Load(object sender, EventArgs e)
        {
            this.progressBarChargement.Maximum = 10000;
            for (int i = 0; i < 9000; i ++)
            {
                this.progressBarChargement.Value = i;
            }
            //Essai de connexion à la base de données
            try
            {
                lienBdD.startConnection();
                fenMenuPrincipal leMenuPrincipal = new fenMenuPrincipal(this);
                
                this.progressBarChargement.Value = 10000;
                leMenuPrincipal.ShowDialog();
            }
            // En d'erreur lors de l'établissment de l'accès a la BdD
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur de connexion a la base de données\nErreur : " + erreur.ToString());
                Application.Exit();
            }
            
        }

        private void progressBarChargement_Click(object sender, EventArgs e)
        {

        }
    }
}
