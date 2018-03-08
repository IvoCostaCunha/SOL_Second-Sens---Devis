﻿using System;
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
    public partial class fenNouveauDevis : Form
    {
        fenMenuPrincipal leMenuPrincipal;

        public fenNouveauDevis(fenMenuPrincipal unMenuPrincipal)
        {
            leMenuPrincipal = unMenuPrincipal;
            InitializeComponent();
        }

        private void fenNouveauDevis_Load(object sender, EventArgs e)
        {
            this.textBoxDateOperation.Enabled = false;
            this.textBoxDateOperation.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void buttonAnnulerInfosDevis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonConfimerInfosDevis_Click(object sender, EventArgs e)
        {
            if (textBoxNomOperation.Text == "")
            {
                MessageBox.Show("Veuillez renseigner un nom.");
            }
            else
            {
                leMenuPrincipal.label1.Text = textBoxNomOperation.Text;
                leMenuPrincipal.label2.Text = textBoxDateOperation.Text;
                leMenuPrincipal.panelNouveauDevis.Show();
                this.Hide();
            }
        }
    }
}
