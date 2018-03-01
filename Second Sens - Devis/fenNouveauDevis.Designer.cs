namespace Second_Sens___Devis
{
    partial class fenNouveauDevis
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
            this.labelAideCreationNouveauDevis = new System.Windows.Forms.Label();
            this.labelNomOperation = new System.Windows.Forms.Label();
            this.labelDateDevis = new System.Windows.Forms.Label();
            this.textBoxDateOperation = new System.Windows.Forms.TextBox();
            this.textBoxNomOperation = new System.Windows.Forms.TextBox();
            this.buttonConfimerInfosDevis = new System.Windows.Forms.Button();
            this.buttonAnnulerInfosDevis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAideCreationNouveauDevis
            // 
            this.labelAideCreationNouveauDevis.AutoSize = true;
            this.labelAideCreationNouveauDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAideCreationNouveauDevis.Location = new System.Drawing.Point(12, 9);
            this.labelAideCreationNouveauDevis.Name = "labelAideCreationNouveauDevis";
            this.labelAideCreationNouveauDevis.Size = new System.Drawing.Size(596, 37);
            this.labelAideCreationNouveauDevis.TabIndex = 0;
            this.labelAideCreationNouveauDevis.Text = "Entrer les informations du nouveau devis";
            // 
            // labelNomOperation
            // 
            this.labelNomOperation.AutoSize = true;
            this.labelNomOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomOperation.Location = new System.Drawing.Point(12, 72);
            this.labelNomOperation.Name = "labelNomOperation";
            this.labelNomOperation.Size = new System.Drawing.Size(223, 29);
            this.labelNomOperation.TabIndex = 1;
            this.labelNomOperation.Text = "Nom de l\'opération:";
            // 
            // labelDateDevis
            // 
            this.labelDateDevis.AutoSize = true;
            this.labelDateDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDevis.Location = new System.Drawing.Point(14, 104);
            this.labelDateDevis.Name = "labelDateDevis";
            this.labelDateDevis.Size = new System.Drawing.Size(69, 29);
            this.labelDateDevis.TabIndex = 2;
            this.labelDateDevis.Text = "Date:";
            // 
            // textBoxDateOperation
            // 
            this.textBoxDateOperation.Location = new System.Drawing.Point(241, 107);
            this.textBoxDateOperation.Name = "textBoxDateOperation";
            this.textBoxDateOperation.Size = new System.Drawing.Size(367, 26);
            this.textBoxDateOperation.TabIndex = 3;
            // 
            // textBoxNomOperation
            // 
            this.textBoxNomOperation.Location = new System.Drawing.Point(241, 75);
            this.textBoxNomOperation.Name = "textBoxNomOperation";
            this.textBoxNomOperation.Size = new System.Drawing.Size(367, 26);
            this.textBoxNomOperation.TabIndex = 4;
            // 
            // buttonConfimerInfosDevis
            // 
            this.buttonConfimerInfosDevis.Location = new System.Drawing.Point(316, 155);
            this.buttonConfimerInfosDevis.Name = "buttonConfimerInfosDevis";
            this.buttonConfimerInfosDevis.Size = new System.Drawing.Size(292, 29);
            this.buttonConfimerInfosDevis.TabIndex = 5;
            this.buttonConfimerInfosDevis.Text = "Confirmer";
            this.buttonConfimerInfosDevis.UseVisualStyleBackColor = true;
            this.buttonConfimerInfosDevis.Click += new System.EventHandler(this.buttonConfimerInfosDevis_Click);
            // 
            // buttonAnnulerInfosDevis
            // 
            this.buttonAnnulerInfosDevis.Location = new System.Drawing.Point(316, 190);
            this.buttonAnnulerInfosDevis.Name = "buttonAnnulerInfosDevis";
            this.buttonAnnulerInfosDevis.Size = new System.Drawing.Size(292, 29);
            this.buttonAnnulerInfosDevis.TabIndex = 6;
            this.buttonAnnulerInfosDevis.Text = "Annuler";
            this.buttonAnnulerInfosDevis.UseVisualStyleBackColor = true;
            this.buttonAnnulerInfosDevis.Click += new System.EventHandler(this.buttonAnnulerInfosDevis_Click);
            // 
            // fenNouveauDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 235);
            this.Controls.Add(this.buttonAnnulerInfosDevis);
            this.Controls.Add(this.buttonConfimerInfosDevis);
            this.Controls.Add(this.textBoxNomOperation);
            this.Controls.Add(this.textBoxDateOperation);
            this.Controls.Add(this.labelDateDevis);
            this.Controls.Add(this.labelNomOperation);
            this.Controls.Add(this.labelAideCreationNouveauDevis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fenNouveauDevis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau devis";
            this.Load += new System.EventHandler(this.fenNouveauDevis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAideCreationNouveauDevis;
        private System.Windows.Forms.Label labelNomOperation;
        private System.Windows.Forms.Label labelDateDevis;
        private System.Windows.Forms.TextBox textBoxDateOperation;
        private System.Windows.Forms.TextBox textBoxNomOperation;
        private System.Windows.Forms.Button buttonConfimerInfosDevis;
        private System.Windows.Forms.Button buttonAnnulerInfosDevis;
    }
}