namespace Second_Sens___Devis
{
    partial class fenAjoutPersonnel
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
            this.labelTypePersonnel = new System.Windows.Forms.Label();
            this.comboBoxTypePersonnel = new System.Windows.Forms.ComboBox();
            this.panelPersoHot = new System.Windows.Forms.Panel();
            this.buttonSupprimerPerso = new System.Windows.Forms.Button();
            this.buttonAjouterPerso = new System.Windows.Forms.Button();
            this.dataGridViewListePerso = new System.Windows.Forms.DataGridView();
            this.labelAidePersonnalisation = new System.Windows.Forms.Label();
            this.labelNomPersonnel = new System.Windows.Forms.Label();
            this.textBoxNomPersonnel = new System.Windows.Forms.TextBox();
            this.labelQtePersonnel = new System.Windows.Forms.Label();
            this.textBoxQtePersonnel = new System.Windows.Forms.TextBox();
            this.textBoxTarifH = new System.Windows.Forms.TextBox();
            this.labelTarifH = new System.Windows.Forms.Label();
            this.labelNbHJour = new System.Windows.Forms.Label();
            this.textBoxNbHJour = new System.Windows.Forms.TextBox();
            this.buttonAjouterPersonnel = new System.Windows.Forms.Button();
            this.buttonAnnulerPersonnel = new System.Windows.Forms.Button();
            this.panelPersoHot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListePerso)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTypePersonnel
            // 
            this.labelTypePersonnel.AutoSize = true;
            this.labelTypePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypePersonnel.Location = new System.Drawing.Point(8, 6);
            this.labelTypePersonnel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypePersonnel.Name = "labelTypePersonnel";
            this.labelTypePersonnel.Size = new System.Drawing.Size(117, 20);
            this.labelTypePersonnel.TabIndex = 0;
            this.labelTypePersonnel.Text = "Type personnel";
            // 
            // comboBoxTypePersonnel
            // 
            this.comboBoxTypePersonnel.FormattingEnabled = true;
            this.comboBoxTypePersonnel.Items.AddRange(new object[] {
            "Hôtesse",
            "Manutentioniste",
            "Conducteur"});
            this.comboBoxTypePersonnel.Location = new System.Drawing.Point(133, 6);
            this.comboBoxTypePersonnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTypePersonnel.Name = "comboBoxTypePersonnel";
            this.comboBoxTypePersonnel.Size = new System.Drawing.Size(199, 21);
            this.comboBoxTypePersonnel.TabIndex = 1;
            this.comboBoxTypePersonnel.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypePersonnel_SelectedIndexChanged);
            // 
            // panelPersoHot
            // 
            this.panelPersoHot.Controls.Add(this.buttonSupprimerPerso);
            this.panelPersoHot.Controls.Add(this.buttonAjouterPerso);
            this.panelPersoHot.Controls.Add(this.dataGridViewListePerso);
            this.panelPersoHot.Controls.Add(this.labelAidePersonnalisation);
            this.panelPersoHot.Enabled = false;
            this.panelPersoHot.Location = new System.Drawing.Point(335, 8);
            this.panelPersoHot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPersoHot.Name = "panelPersoHot";
            this.panelPersoHot.Size = new System.Drawing.Size(263, 201);
            this.panelPersoHot.TabIndex = 2;
            // 
            // buttonSupprimerPerso
            // 
            this.buttonSupprimerPerso.Location = new System.Drawing.Point(5, 33);
            this.buttonSupprimerPerso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSupprimerPerso.Name = "buttonSupprimerPerso";
            this.buttonSupprimerPerso.Size = new System.Drawing.Size(125, 23);
            this.buttonSupprimerPerso.TabIndex = 14;
            this.buttonSupprimerPerso.Text = "Supprimer";
            this.buttonSupprimerPerso.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterPerso
            // 
            this.buttonAjouterPerso.Location = new System.Drawing.Point(134, 33);
            this.buttonAjouterPerso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAjouterPerso.Name = "buttonAjouterPerso";
            this.buttonAjouterPerso.Size = new System.Drawing.Size(119, 23);
            this.buttonAjouterPerso.TabIndex = 13;
            this.buttonAjouterPerso.Text = "Ajouter";
            this.buttonAjouterPerso.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListePerso
            // 
            this.dataGridViewListePerso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListePerso.Location = new System.Drawing.Point(5, 60);
            this.dataGridViewListePerso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewListePerso.Name = "dataGridViewListePerso";
            this.dataGridViewListePerso.RowTemplate.Height = 28;
            this.dataGridViewListePerso.Size = new System.Drawing.Size(248, 136);
            this.dataGridViewListePerso.TabIndex = 13;
            // 
            // labelAidePersonnalisation
            // 
            this.labelAidePersonnalisation.AutoSize = true;
            this.labelAidePersonnalisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAidePersonnalisation.Location = new System.Drawing.Point(2, 6);
            this.labelAidePersonnalisation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAidePersonnalisation.Name = "labelAidePersonnalisation";
            this.labelAidePersonnalisation.Size = new System.Drawing.Size(126, 20);
            this.labelAidePersonnalisation.TabIndex = 10;
            this.labelAidePersonnalisation.Text = "Personnalisation";
            // 
            // labelNomPersonnel
            // 
            this.labelNomPersonnel.AutoSize = true;
            this.labelNomPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPersonnel.Location = new System.Drawing.Point(8, 29);
            this.labelNomPersonnel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomPersonnel.Name = "labelNomPersonnel";
            this.labelNomPersonnel.Size = new System.Drawing.Size(116, 20);
            this.labelNomPersonnel.TabIndex = 3;
            this.labelNomPersonnel.Text = "Nom personnel";
            // 
            // textBoxNomPersonnel
            // 
            this.textBoxNomPersonnel.Location = new System.Drawing.Point(133, 29);
            this.textBoxNomPersonnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNomPersonnel.Name = "textBoxNomPersonnel";
            this.textBoxNomPersonnel.Size = new System.Drawing.Size(199, 20);
            this.textBoxNomPersonnel.TabIndex = 4;
            // 
            // labelQtePersonnel
            // 
            this.labelQtePersonnel.AutoSize = true;
            this.labelQtePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtePersonnel.Location = new System.Drawing.Point(169, 59);
            this.labelQtePersonnel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQtePersonnel.Name = "labelQtePersonnel";
            this.labelQtePersonnel.Size = new System.Drawing.Size(39, 20);
            this.labelQtePersonnel.TabIndex = 5;
            this.labelQtePersonnel.Text = "Qte ";
            // 
            // textBoxQtePersonnel
            // 
            this.textBoxQtePersonnel.Location = new System.Drawing.Point(211, 61);
            this.textBoxQtePersonnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQtePersonnel.Name = "textBoxQtePersonnel";
            this.textBoxQtePersonnel.Size = new System.Drawing.Size(121, 20);
            this.textBoxQtePersonnel.TabIndex = 6;
            // 
            // textBoxTarifH
            // 
            this.textBoxTarifH.Location = new System.Drawing.Point(110, 62);
            this.textBoxTarifH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTarifH.Name = "textBoxTarifH";
            this.textBoxTarifH.Size = new System.Drawing.Size(56, 20);
            this.textBoxTarifH.TabIndex = 7;
            // 
            // labelTarifH
            // 
            this.labelTarifH.AutoSize = true;
            this.labelTarifH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarifH.Location = new System.Drawing.Point(8, 62);
            this.labelTarifH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTarifH.Name = "labelTarifH";
            this.labelTarifH.Size = new System.Drawing.Size(96, 20);
            this.labelTarifH.TabIndex = 6;
            this.labelTarifH.Text = "Tarif / Heure";
            // 
            // labelNbHJour
            // 
            this.labelNbHJour.AutoSize = true;
            this.labelNbHJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbHJour.Location = new System.Drawing.Point(4, 86);
            this.labelNbHJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNbHJour.Name = "labelNbHJour";
            this.labelNbHJour.Size = new System.Drawing.Size(120, 20);
            this.labelNbHJour.TabIndex = 8;
            this.labelNbHJour.Text = "Nb heures / jour";
            // 
            // textBoxNbHJour
            // 
            this.textBoxNbHJour.Location = new System.Drawing.Point(135, 86);
            this.textBoxNbHJour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNbHJour.Name = "textBoxNbHJour";
            this.textBoxNbHJour.Size = new System.Drawing.Size(197, 20);
            this.textBoxNbHJour.TabIndex = 9;
            // 
            // buttonAjouterPersonnel
            // 
            this.buttonAjouterPersonnel.Location = new System.Drawing.Point(211, 185);
            this.buttonAjouterPersonnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAjouterPersonnel.Name = "buttonAjouterPersonnel";
            this.buttonAjouterPersonnel.Size = new System.Drawing.Size(119, 23);
            this.buttonAjouterPersonnel.TabIndex = 10;
            this.buttonAjouterPersonnel.Text = "Ajouter";
            this.buttonAjouterPersonnel.UseVisualStyleBackColor = true;
            // 
            // buttonAnnulerPersonnel
            // 
            this.buttonAnnulerPersonnel.Location = new System.Drawing.Point(88, 185);
            this.buttonAnnulerPersonnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnnulerPersonnel.Name = "buttonAnnulerPersonnel";
            this.buttonAnnulerPersonnel.Size = new System.Drawing.Size(119, 23);
            this.buttonAnnulerPersonnel.TabIndex = 11;
            this.buttonAnnulerPersonnel.Text = "Annuler";
            this.buttonAnnulerPersonnel.UseVisualStyleBackColor = true;
            // 
            // fenAjoutPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 216);
            this.Controls.Add(this.buttonAnnulerPersonnel);
            this.Controls.Add(this.buttonAjouterPersonnel);
            this.Controls.Add(this.textBoxNbHJour);
            this.Controls.Add(this.labelNbHJour);
            this.Controls.Add(this.labelTarifH);
            this.Controls.Add(this.textBoxTarifH);
            this.Controls.Add(this.textBoxQtePersonnel);
            this.Controls.Add(this.labelQtePersonnel);
            this.Controls.Add(this.textBoxNomPersonnel);
            this.Controls.Add(this.labelNomPersonnel);
            this.Controls.Add(this.panelPersoHot);
            this.Controls.Add(this.comboBoxTypePersonnel);
            this.Controls.Add(this.labelTypePersonnel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fenAjoutPersonnel";
            this.Text = "Ajouter Personnel";
            this.Load += new System.EventHandler(this.fenHotesse_Load);
            this.panelPersoHot.ResumeLayout(false);
            this.panelPersoHot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListePerso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypePersonnel;
        private System.Windows.Forms.ComboBox comboBoxTypePersonnel;
        private System.Windows.Forms.Panel panelPersoHot;
        private System.Windows.Forms.Label labelAidePersonnalisation;
        private System.Windows.Forms.Label labelNomPersonnel;
        private System.Windows.Forms.TextBox textBoxNomPersonnel;
        private System.Windows.Forms.Label labelQtePersonnel;
        private System.Windows.Forms.TextBox textBoxQtePersonnel;
        private System.Windows.Forms.TextBox textBoxTarifH;
        private System.Windows.Forms.Label labelTarifH;
        private System.Windows.Forms.Label labelNbHJour;
        private System.Windows.Forms.TextBox textBoxNbHJour;
        private System.Windows.Forms.Button buttonAjouterPersonnel;
        private System.Windows.Forms.Button buttonAnnulerPersonnel;
        private System.Windows.Forms.Button buttonSupprimerPerso;
        private System.Windows.Forms.Button buttonAjouterPerso;
        private System.Windows.Forms.DataGridView dataGridViewListePerso;
    }
}