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

        }
    }
}
