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
            if (textBoxNomOperation.Text != "")
            {
                if (textBoxDureeOpe.Text != "")
                {
                    try
                    {
                        Convert.ToInt32(textBoxDureeOpe.Text);
                        classDevis leNouveauDevis = new classDevis(textBoxNomOperation.Text, Convert.ToDateTime(textBoxDateOperation.Text), Convert.ToInt32(textBoxDureeOpe.Text));
                        leMenuPrincipal.leNouveauDevis = leNouveauDevis;
                        leMenuPrincipal.label1.Text = textBoxNomOperation.Text;
                        leMenuPrincipal.label2.Text = textBoxDateOperation.Text;
                        leMenuPrincipal.panelNouveauDevis.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Veuillez ne rentrer que des nombres entiers.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner une durée d'opération");
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un nom d'opération");
            }
        }
        private void fenNouveauDevis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                MessageBox.Show("Testing KeyPress");
            }
        }
    }
}
