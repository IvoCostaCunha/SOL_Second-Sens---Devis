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
    public partial class fenAjoutPersonnel : Form
    {
        fenNouvelleEquipe laNouvelleEquipe;

        public fenAjoutPersonnel(fenNouvelleEquipe uneNouvelleEquipe)
        {
            laNouvelleEquipe = uneNouvelleEquipe;
            InitializeComponent();
        }

        private void fenHotesse_Load(object sender, EventArgs e)
        {

        }
    }
}
