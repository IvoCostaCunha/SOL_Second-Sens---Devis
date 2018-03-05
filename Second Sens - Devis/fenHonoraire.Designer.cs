namespace Second_Sens___Devis
{
    partial class fenHonoraire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTypeTarifHonoraire = new System.Windows.Forms.Label();
            this.comboBoxTypeTarif = new System.Windows.Forms.ComboBox();
            this.panelFenHonoraire = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonSupprimerHonoraire = new System.Windows.Forms.Button();
            this.buttonAjouterHonoraire = new System.Windows.Forms.Button();
            this.checkBoxModelePerso = new System.Windows.Forms.CheckBox();
            this.checkBoxModeleExistant = new System.Windows.Forms.CheckBox();
            this.panelModeleExistant = new System.Windows.Forms.Panel();
            this.labelTypeHonoraire = new System.Windows.Forms.Label();
            this.textBoxTarifHeureModeleEx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNbHeureModeleEx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeHonoraire = new System.Windows.Forms.ComboBox();
            this.panelModelePerso = new System.Windows.Forms.Panel();
            this.textBoxNomHonoraireModPerso = new System.Windows.Forms.TextBox();
            this.labelNomHonoraire = new System.Windows.Forms.Label();
            this.textBoxTarifHeureModPerso = new System.Windows.Forms.TextBox();
            this.labelNbHeuresHonoraire = new System.Windows.Forms.Label();
            this.textBoxNbHeuresHonoraireModPerso = new System.Windows.Forms.TextBox();
            this.labelTarifHeure = new System.Windows.Forms.Label();
            this.labelListHonoraires = new System.Windows.Forms.Label();
            this.dataGridViewListeHonoraires = new System.Windows.Forms.DataGridView();
            this.colNomHon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifHonoraireHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNbHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNbJours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFenHonoraire.SuspendLayout();
            this.panelModeleExistant.SuspendLayout();
            this.panelModelePerso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeHonoraires)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTypeTarifHonoraire
            // 
            this.labelTypeTarifHonoraire.AutoSize = true;
            this.labelTypeTarifHonoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeTarifHonoraire.Location = new System.Drawing.Point(12, 9);
            this.labelTypeTarifHonoraire.Name = "labelTypeTarifHonoraire";
            this.labelTypeTarifHonoraire.Size = new System.Drawing.Size(113, 29);
            this.labelTypeTarifHonoraire.TabIndex = 0;
            this.labelTypeTarifHonoraire.Text = "Type tarif";
            // 
            // comboBoxTypeTarif
            // 
            this.comboBoxTypeTarif.FormattingEnabled = true;
            this.comboBoxTypeTarif.Items.AddRange(new object[] {
            "En heures",
            "En jours"});
            this.comboBoxTypeTarif.Location = new System.Drawing.Point(131, 10);
            this.comboBoxTypeTarif.Name = "comboBoxTypeTarif";
            this.comboBoxTypeTarif.Size = new System.Drawing.Size(268, 28);
            this.comboBoxTypeTarif.TabIndex = 1;
            this.comboBoxTypeTarif.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeTarif_SelectedIndexChanged);
            // 
            // panelFenHonoraire
            // 
            this.panelFenHonoraire.Controls.Add(this.buttonAnnuler);
            this.panelFenHonoraire.Controls.Add(this.buttonSupprimerHonoraire);
            this.panelFenHonoraire.Controls.Add(this.buttonAjouterHonoraire);
            this.panelFenHonoraire.Controls.Add(this.checkBoxModelePerso);
            this.panelFenHonoraire.Controls.Add(this.checkBoxModeleExistant);
            this.panelFenHonoraire.Controls.Add(this.panelModeleExistant);
            this.panelFenHonoraire.Controls.Add(this.panelModelePerso);
            this.panelFenHonoraire.Controls.Add(this.labelListHonoraires);
            this.panelFenHonoraire.Controls.Add(this.dataGridViewListeHonoraires);
            this.panelFenHonoraire.Location = new System.Drawing.Point(17, 44);
            this.panelFenHonoraire.Name = "panelFenHonoraire";
            this.panelFenHonoraire.Size = new System.Drawing.Size(1011, 535);
            this.panelFenHonoraire.TabIndex = 2;
            this.panelFenHonoraire.Visible = false;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(246, 476);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(278, 31);
            this.buttonAnnuler.TabIndex = 16;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonSupprimerHonoraire
            // 
            this.buttonSupprimerHonoraire.Location = new System.Drawing.Point(3, 439);
            this.buttonSupprimerHonoraire.Name = "buttonSupprimerHonoraire";
            this.buttonSupprimerHonoraire.Size = new System.Drawing.Size(237, 31);
            this.buttonSupprimerHonoraire.TabIndex = 15;
            this.buttonSupprimerHonoraire.Text = "Supprimer honoraire";
            this.buttonSupprimerHonoraire.UseVisualStyleBackColor = true;
            this.buttonSupprimerHonoraire.Click += new System.EventHandler(this.buttonSupprimerHonoraire_Click);
            // 
            // buttonAjouterHonoraire
            // 
            this.buttonAjouterHonoraire.Location = new System.Drawing.Point(246, 439);
            this.buttonAjouterHonoraire.Name = "buttonAjouterHonoraire";
            this.buttonAjouterHonoraire.Size = new System.Drawing.Size(278, 31);
            this.buttonAjouterHonoraire.TabIndex = 14;
            this.buttonAjouterHonoraire.Text = "Ajouter honoraire";
            this.buttonAjouterHonoraire.UseVisualStyleBackColor = true;
            this.buttonAjouterHonoraire.Click += new System.EventHandler(this.buttonAjouterHonoraire_Click);
            // 
            // checkBoxModelePerso
            // 
            this.checkBoxModelePerso.AutoSize = true;
            this.checkBoxModelePerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxModelePerso.Location = new System.Drawing.Point(11, 53);
            this.checkBoxModelePerso.Name = "checkBoxModelePerso";
            this.checkBoxModelePerso.Size = new System.Drawing.Size(407, 33);
            this.checkBoxModelePerso.TabIndex = 13;
            this.checkBoxModelePerso.Text = "Modèle d\'honoraire perosonnalisé";
            this.checkBoxModelePerso.UseVisualStyleBackColor = true;
            this.checkBoxModelePerso.CheckedChanged += new System.EventHandler(this.checkBoxModelePerso_CheckedChanged);
            // 
            // checkBoxModeleExistant
            // 
            this.checkBoxModeleExistant.AutoSize = true;
            this.checkBoxModeleExistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxModeleExistant.Location = new System.Drawing.Point(11, 14);
            this.checkBoxModeleExistant.Name = "checkBoxModeleExistant";
            this.checkBoxModeleExistant.Size = new System.Drawing.Size(335, 33);
            this.checkBoxModeleExistant.TabIndex = 12;
            this.checkBoxModeleExistant.Text = "Modèle d\'honoraire existant";
            this.checkBoxModeleExistant.UseVisualStyleBackColor = true;
            this.checkBoxModeleExistant.CheckedChanged += new System.EventHandler(this.checkBoxModeleExistant_CheckedChanged);
            // 
            // panelModeleExistant
            // 
            this.panelModeleExistant.Controls.Add(this.labelTypeHonoraire);
            this.panelModeleExistant.Controls.Add(this.textBoxTarifHeureModeleEx);
            this.panelModeleExistant.Controls.Add(this.label1);
            this.panelModeleExistant.Controls.Add(this.textBoxNbHeureModeleEx);
            this.panelModeleExistant.Controls.Add(this.label2);
            this.panelModeleExistant.Controls.Add(this.comboBoxTypeHonoraire);
            this.panelModeleExistant.Location = new System.Drawing.Point(3, 110);
            this.panelModeleExistant.Name = "panelModeleExistant";
            this.panelModeleExistant.Size = new System.Drawing.Size(521, 323);
            this.panelModeleExistant.TabIndex = 11;
            this.panelModeleExistant.Visible = false;
            // 
            // labelTypeHonoraire
            // 
            this.labelTypeHonoraire.AutoSize = true;
            this.labelTypeHonoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeHonoraire.Location = new System.Drawing.Point(3, 12);
            this.labelTypeHonoraire.Name = "labelTypeHonoraire";
            this.labelTypeHonoraire.Size = new System.Drawing.Size(177, 29);
            this.labelTypeHonoraire.TabIndex = 5;
            this.labelTypeHonoraire.Text = "Type honoraire";
            // 
            // textBoxTarifHeureModeleEx
            // 
            this.textBoxTarifHeureModeleEx.Location = new System.Drawing.Point(243, 79);
            this.textBoxTarifHeureModeleEx.Name = "textBoxTarifHeureModeleEx";
            this.textBoxTarifHeureModeleEx.Size = new System.Drawing.Size(254, 26);
            this.textBoxTarifHeureModeleEx.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nb heures honoraire";
            // 
            // textBoxNbHeureModeleEx
            // 
            this.textBoxNbHeureModeleEx.Location = new System.Drawing.Point(243, 47);
            this.textBoxNbHeureModeleEx.Name = "textBoxNbHeureModeleEx";
            this.textBoxNbHeureModeleEx.Size = new System.Drawing.Size(254, 26);
            this.textBoxNbHeureModeleEx.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tarif a l\'heure";
            // 
            // comboBoxTypeHonoraire
            // 
            this.comboBoxTypeHonoraire.FormattingEnabled = true;
            this.comboBoxTypeHonoraire.Location = new System.Drawing.Point(243, 13);
            this.comboBoxTypeHonoraire.Name = "comboBoxTypeHonoraire";
            this.comboBoxTypeHonoraire.Size = new System.Drawing.Size(254, 28);
            this.comboBoxTypeHonoraire.TabIndex = 6;
            // 
            // panelModelePerso
            // 
            this.panelModelePerso.Controls.Add(this.textBoxNomHonoraireModPerso);
            this.panelModelePerso.Controls.Add(this.labelNomHonoraire);
            this.panelModelePerso.Controls.Add(this.textBoxTarifHeureModPerso);
            this.panelModelePerso.Controls.Add(this.labelNbHeuresHonoraire);
            this.panelModelePerso.Controls.Add(this.textBoxNbHeuresHonoraireModPerso);
            this.panelModelePerso.Controls.Add(this.labelTarifHeure);
            this.panelModelePerso.Location = new System.Drawing.Point(3, 110);
            this.panelModelePerso.Name = "panelModelePerso";
            this.panelModelePerso.Size = new System.Drawing.Size(521, 323);
            this.panelModelePerso.TabIndex = 14;
            this.panelModelePerso.Visible = false;
            // 
            // textBoxNomHonoraireModPerso
            // 
            this.textBoxNomHonoraireModPerso.Location = new System.Drawing.Point(243, 15);
            this.textBoxNomHonoraireModPerso.Name = "textBoxNomHonoraireModPerso";
            this.textBoxNomHonoraireModPerso.Size = new System.Drawing.Size(254, 26);
            this.textBoxNomHonoraireModPerso.TabIndex = 11;
            // 
            // labelNomHonoraire
            // 
            this.labelNomHonoraire.AutoSize = true;
            this.labelNomHonoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomHonoraire.Location = new System.Drawing.Point(3, 12);
            this.labelNomHonoraire.Name = "labelNomHonoraire";
            this.labelNomHonoraire.Size = new System.Drawing.Size(174, 29);
            this.labelNomHonoraire.TabIndex = 5;
            this.labelNomHonoraire.Text = "Nom honoraire";
            // 
            // textBoxTarifHeureModPerso
            // 
            this.textBoxTarifHeureModPerso.Location = new System.Drawing.Point(243, 79);
            this.textBoxTarifHeureModPerso.Name = "textBoxTarifHeureModPerso";
            this.textBoxTarifHeureModPerso.Size = new System.Drawing.Size(254, 26);
            this.textBoxTarifHeureModPerso.TabIndex = 10;
            // 
            // labelNbHeuresHonoraire
            // 
            this.labelNbHeuresHonoraire.AutoSize = true;
            this.labelNbHeuresHonoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbHeuresHonoraire.Location = new System.Drawing.Point(3, 44);
            this.labelNbHeuresHonoraire.Name = "labelNbHeuresHonoraire";
            this.labelNbHeuresHonoraire.Size = new System.Drawing.Size(234, 29);
            this.labelNbHeuresHonoraire.TabIndex = 7;
            this.labelNbHeuresHonoraire.Text = "Nb heures honoraire";
            // 
            // textBoxNbHeuresHonoraireModPerso
            // 
            this.textBoxNbHeuresHonoraireModPerso.Location = new System.Drawing.Point(243, 47);
            this.textBoxNbHeuresHonoraireModPerso.Name = "textBoxNbHeuresHonoraireModPerso";
            this.textBoxNbHeuresHonoraireModPerso.Size = new System.Drawing.Size(254, 26);
            this.textBoxNbHeuresHonoraireModPerso.TabIndex = 9;
            // 
            // labelTarifHeure
            // 
            this.labelTarifHeure.AutoSize = true;
            this.labelTarifHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarifHeure.Location = new System.Drawing.Point(3, 76);
            this.labelTarifHeure.Name = "labelTarifHeure";
            this.labelTarifHeure.Size = new System.Drawing.Size(159, 29);
            this.labelTarifHeure.TabIndex = 8;
            this.labelTarifHeure.Text = "Tarif a l\'heure";
            // 
            // labelListHonoraires
            // 
            this.labelListHonoraires.AutoSize = true;
            this.labelListHonoraires.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListHonoraires.Location = new System.Drawing.Point(525, 14);
            this.labelListHonoraires.Name = "labelListHonoraires";
            this.labelListHonoraires.Size = new System.Drawing.Size(216, 29);
            this.labelListHonoraires.TabIndex = 4;
            this.labelListHonoraires.Text = "Honoraires ajoutés";
            // 
            // dataGridViewListeHonoraires
            // 
            this.dataGridViewListeHonoraires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeHonoraires.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomHon,
            this.colTarifHonoraireHeure,
            this.colNbHeure,
            this.colNbJours});
            this.dataGridViewListeHonoraires.Location = new System.Drawing.Point(530, 46);
            this.dataGridViewListeHonoraires.Name = "dataGridViewListeHonoraires";
            this.dataGridViewListeHonoraires.RowTemplate.Height = 28;
            this.dataGridViewListeHonoraires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListeHonoraires.Size = new System.Drawing.Size(478, 486);
            this.dataGridViewListeHonoraires.TabIndex = 3;
            // 
            // colNomHon
            // 
            this.colNomHon.HeaderText = "Nom Honoraire";
            this.colNomHon.Name = "colNomHon";
            // 
            // colTarifHonoraireHeure
            // 
            this.colTarifHonoraireHeure.HeaderText = "Tarif Honoraire / heure";
            this.colTarifHonoraireHeure.Name = "colTarifHonoraireHeure";
            // 
            // colNbHeure
            // 
            this.colNbHeure.HeaderText = "Nb Heures ";
            this.colNbHeure.Name = "colNbHeure";
            this.colNbHeure.Visible = false;
            // 
            // colNbJours
            // 
            this.colNbJours.HeaderText = "Nb Jours";
            this.colNbJours.Name = "colNbJours";
            this.colNbJours.Visible = false;
            // 
            // fenHonoraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 591);
            this.Controls.Add(this.panelFenHonoraire);
            this.Controls.Add(this.comboBoxTypeTarif);
            this.Controls.Add(this.labelTypeTarifHonoraire);
            this.Name = "fenHonoraire";
            this.Text = "Ajouter honoraire";
            this.Load += new System.EventHandler(this.fenHonoraire_Load);
            this.panelFenHonoraire.ResumeLayout(false);
            this.panelFenHonoraire.PerformLayout();
            this.panelModeleExistant.ResumeLayout(false);
            this.panelModeleExistant.PerformLayout();
            this.panelModelePerso.ResumeLayout(false);
            this.panelModelePerso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeHonoraires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeTarifHonoraire;
        private System.Windows.Forms.ComboBox comboBoxTypeTarif;
        private System.Windows.Forms.Panel panelFenHonoraire;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonSupprimerHonoraire;
        private System.Windows.Forms.Button buttonAjouterHonoraire;
        private System.Windows.Forms.CheckBox checkBoxModelePerso;
        private System.Windows.Forms.CheckBox checkBoxModeleExistant;
        private System.Windows.Forms.Panel panelModeleExistant;
        private System.Windows.Forms.Label labelTypeHonoraire;
        private System.Windows.Forms.TextBox textBoxTarifHeureModeleEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNbHeureModeleEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypeHonoraire;
        private System.Windows.Forms.Panel panelModelePerso;
        private System.Windows.Forms.TextBox textBoxNomHonoraireModPerso;
        private System.Windows.Forms.Label labelNomHonoraire;
        private System.Windows.Forms.TextBox textBoxTarifHeureModPerso;
        private System.Windows.Forms.Label labelNbHeuresHonoraire;
        private System.Windows.Forms.TextBox textBoxNbHeuresHonoraireModPerso;
        private System.Windows.Forms.Label labelTarifHeure;
        private System.Windows.Forms.Label labelListHonoraires;
        private System.Windows.Forms.DataGridView dataGridViewListeHonoraires;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomHon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifHonoraireHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNbHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNbJours;
    }
}