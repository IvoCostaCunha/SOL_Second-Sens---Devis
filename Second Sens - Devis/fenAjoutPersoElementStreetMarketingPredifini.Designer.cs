namespace Second_Sens___Devis
{
    partial class fenAjoutPersoElementStreetMarketingPredifini
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
            this.labelAideModelPredefini = new System.Windows.Forms.Label();
            this.labelTarifPersonnalisationPredefinie = new System.Windows.Forms.Label();
            this.textBoxTarifPersonnalisationPredefinie = new System.Windows.Forms.TextBox();
            this.buttonAjouterPersonnalisationPredefinie = new System.Windows.Forms.Button();
            this.buttonAnnulerAjoutPersonnalisation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAideModelPredefini
            // 
            this.labelAideModelPredefini.AutoSize = true;
            this.labelAideModelPredefini.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAideModelPredefini.Location = new System.Drawing.Point(15, 6);
            this.labelAideModelPredefini.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAideModelPredefini.Name = "labelAideModelPredefini";
            this.labelAideModelPredefini.Size = new System.Drawing.Size(172, 26);
            this.labelAideModelPredefini.TabIndex = 5;
            this.labelAideModelPredefini.Text = "Modèle prédéfini";
            // 
            // labelTarifPersonnalisationPredefinie
            // 
            this.labelTarifPersonnalisationPredefinie.AutoSize = true;
            this.labelTarifPersonnalisationPredefinie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarifPersonnalisationPredefinie.Location = new System.Drawing.Point(16, 40);
            this.labelTarifPersonnalisationPredefinie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTarifPersonnalisationPredefinie.Name = "labelTarifPersonnalisationPredefinie";
            this.labelTarifPersonnalisationPredefinie.Size = new System.Drawing.Size(40, 20);
            this.labelTarifPersonnalisationPredefinie.TabIndex = 8;
            this.labelTarifPersonnalisationPredefinie.Text = "Tarif";
            // 
            // textBoxTarifPersonnalisationPredefinie
            // 
            this.textBoxTarifPersonnalisationPredefinie.Location = new System.Drawing.Point(149, 42);
            this.textBoxTarifPersonnalisationPredefinie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTarifPersonnalisationPredefinie.Name = "textBoxTarifPersonnalisationPredefinie";
            this.textBoxTarifPersonnalisationPredefinie.Size = new System.Drawing.Size(197, 20);
            this.textBoxTarifPersonnalisationPredefinie.TabIndex = 9;
            // 
            // buttonAjouterPersonnalisationPredefinie
            // 
            this.buttonAjouterPersonnalisationPredefinie.Location = new System.Drawing.Point(148, 66);
            this.buttonAjouterPersonnalisationPredefinie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAjouterPersonnalisationPredefinie.Name = "buttonAjouterPersonnalisationPredefinie";
            this.buttonAjouterPersonnalisationPredefinie.Size = new System.Drawing.Size(197, 27);
            this.buttonAjouterPersonnalisationPredefinie.TabIndex = 6;
            this.buttonAjouterPersonnalisationPredefinie.Text = "Ajouter";
            this.buttonAjouterPersonnalisationPredefinie.UseVisualStyleBackColor = true;
            // 
            // buttonAnnulerAjoutPersonnalisation
            // 
            this.buttonAnnulerAjoutPersonnalisation.Location = new System.Drawing.Point(19, 66);
            this.buttonAnnulerAjoutPersonnalisation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnnulerAjoutPersonnalisation.Name = "buttonAnnulerAjoutPersonnalisation";
            this.buttonAnnulerAjoutPersonnalisation.Size = new System.Drawing.Size(125, 27);
            this.buttonAnnulerAjoutPersonnalisation.TabIndex = 11;
            this.buttonAnnulerAjoutPersonnalisation.Text = "Annuler";
            this.buttonAnnulerAjoutPersonnalisation.UseVisualStyleBackColor = true;
            // 
            // fenAjoutPersoElementStreetMarketingPredifini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 114);
            this.Controls.Add(this.buttonAjouterPersonnalisationPredefinie);
            this.Controls.Add(this.buttonAnnulerAjoutPersonnalisation);
            this.Controls.Add(this.textBoxTarifPersonnalisationPredefinie);
            this.Controls.Add(this.labelTarifPersonnalisationPredefinie);
            this.Controls.Add(this.labelAideModelPredefini);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fenAjoutPersoElementStreetMarketingPredifini";
            this.Text = "Ajout Personnalisation";
            this.Load += new System.EventHandler(this.fenAjoutPersoElementStreetMarketing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTarifPersonnalisationPredefinie;
        private System.Windows.Forms.Label labelTarifPersonnalisationPredefinie;
        private System.Windows.Forms.Label labelAideModelPredefini;
        private System.Windows.Forms.Button buttonAjouterPersonnalisationPredefinie;
        private System.Windows.Forms.Button buttonAnnulerAjoutPersonnalisation;
    }
}