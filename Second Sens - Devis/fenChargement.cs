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
            lienBdD.startConnection();
            fenMenuPrincipal leMenuPrincipal = new fenMenuPrincipal(this);
            this.progressBarChargement.Maximum = 100;
            this.progressBarChargement.Value = 100;
            leMenuPrincipal.ShowDialog();
        }
    }
}
