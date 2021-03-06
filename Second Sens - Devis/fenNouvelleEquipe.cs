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
    public partial class fenNouvelleEquipe : Form
    {
        fenMenuPrincipal leMenuPrincipal;

        public classEquipe laEquipe;

        public fenNouvelleEquipe(fenMenuPrincipal unMenuPrincipal)
        {
            laEquipe = new classEquipe();
            leMenuPrincipal = unMenuPrincipal;
            InitializeComponent();
        }

        private void fenNouvelleEquipe_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAnnulerEquipe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAjouterElementPredefini_Click(object sender, EventArgs e)
        {
            fenNouvelElement leNouvelElement = new fenNouvelElement(this);
            /* charger les infos présentes sur la base en fonction de ce qui la selection de la comboBox */
            leNouvelElement.ShowDialog();
        }

        private void buttonAjouterElementStreetMarketing_Click(object sender, EventArgs e)
        {
            fenNouvelElementPersonnalisable leNouvelElementStreetMarketing = new fenNouvelElementPersonnalisable(this);
            leNouvelElementStreetMarketing.ShowDialog();
        }

        private void buttonAjouterHonorairePredifini_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterPersonnel_Click(object sender, EventArgs e)
        {
            fenAjoutPersonnel leNouveauPersonnel = new fenAjoutPersonnel(this);
            leNouveauPersonnel.ShowDialog();
        }

        private void bntAjoutElementStandard_Click(object sender, EventArgs e)
        {
            fenNouvelElement unNouvelElement = new fenNouvelElement(this);
            unNouvelElement.ShowDialog();
        }

        private void btnAjoutElementPerso_Click(object sender, EventArgs e)
        {
            fenNouvelElementPersonnalisable unNouvelElementPerso = new fenNouvelElementPersonnalisable(this);
            unNouvelElementPerso.ShowDialog();
        }

        private void bntAjoutVehicule_Click(object sender, EventArgs e)
        {
            fenNouveauElementVehicule leNouveauVehicule = new fenNouveauElementVehicule(this);
            leNouveauVehicule.ShowDialog();
        }

        public void majListeEquipes()
        {
            listBoxAjoutsEffectues.Items.Clear();
            foreach(classElement unElement in laEquipe.getLesElements())
            {
                listBoxAjoutsEffectues.Items.Add(unElement);
            }
            foreach(classElementPersonnalisable unElementPerso in laEquipe.getLesElementsPersonnalisables())
            {
                listBoxAjoutsEffectues.Items.Add(unElementPerso);
            }
            foreach(classVehiculeSociete unVehiculeSociete in laEquipe.getLesVehiculesSociete())
            {
                listBoxAjoutsEffectues.Items.Add(unVehiculeSociete);
            }
        }

        private void buttonValiderEquipe_Click(object sender, EventArgs e)
        {
            laEquipe.setNomEquipe(this.textBoxNomEquipe.Text);
            leMenuPrincipal.lesEquipes.Add(this.laEquipe);
            leMenuPrincipal.majListeEquipes();
            this.Hide();
        }

    }
}
 
