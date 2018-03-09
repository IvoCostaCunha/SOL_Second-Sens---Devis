namespace Second_Sens___Devis
{
    partial class fenMajTarifs
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
            this.tabControlTarif = new System.Windows.Forms.TabControl();
            this.tabPageGeneraux = new System.Windows.Forms.TabPage();
            this.tabPageElePerso = new System.Windows.Forms.TabPage();
            this.tabPageEleClassique = new System.Windows.Forms.TabPage();
            this.tabPagePersonnel = new System.Windows.Forms.TabPage();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.buttonAnnulerModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTarifsGeneraux = new System.Windows.Forms.DataGridView();
            this.coutClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixRevient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTarifElementPerso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewElementClassique = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlTarif.SuspendLayout();
            this.tabPageGeneraux.SuspendLayout();
            this.tabPageElePerso.SuspendLayout();
            this.tabPageEleClassique.SuspendLayout();
            this.tabPagePersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifsGeneraux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifElementPerso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElementClassique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTarif
            // 
            this.tabControlTarif.Controls.Add(this.tabPageGeneraux);
            this.tabControlTarif.Controls.Add(this.tabPageElePerso);
            this.tabControlTarif.Controls.Add(this.tabPageEleClassique);
            this.tabControlTarif.Controls.Add(this.tabPagePersonnel);
            this.tabControlTarif.Location = new System.Drawing.Point(0, 32);
            this.tabControlTarif.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlTarif.Name = "tabControlTarif";
            this.tabControlTarif.SelectedIndex = 0;
            this.tabControlTarif.Size = new System.Drawing.Size(847, 350);
            this.tabControlTarif.TabIndex = 0;
            // 
            // tabPageGeneraux
            // 
            this.tabPageGeneraux.Controls.Add(this.dataGridViewTarifsGeneraux);
            this.tabPageGeneraux.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneraux.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageGeneraux.Name = "tabPageGeneraux";
            this.tabPageGeneraux.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageGeneraux.Size = new System.Drawing.Size(839, 324);
            this.tabPageGeneraux.TabIndex = 0;
            this.tabPageGeneraux.Text = "Général";
            this.tabPageGeneraux.UseVisualStyleBackColor = true;
            // 
            // tabPageElePerso
            // 
            this.tabPageElePerso.Controls.Add(this.dataGridViewTarifElementPerso);
            this.tabPageElePerso.Location = new System.Drawing.Point(4, 22);
            this.tabPageElePerso.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageElePerso.Name = "tabPageElePerso";
            this.tabPageElePerso.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageElePerso.Size = new System.Drawing.Size(839, 324);
            this.tabPageElePerso.TabIndex = 1;
            this.tabPageElePerso.Text = "Éléments personnalisables";
            this.tabPageElePerso.UseVisualStyleBackColor = true;
            // 
            // tabPageEleClassique
            // 
            this.tabPageEleClassique.Controls.Add(this.dataGridViewElementClassique);
            this.tabPageEleClassique.Location = new System.Drawing.Point(4, 22);
            this.tabPageEleClassique.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEleClassique.Name = "tabPageEleClassique";
            this.tabPageEleClassique.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageEleClassique.Size = new System.Drawing.Size(839, 324);
            this.tabPageEleClassique.TabIndex = 2;
            this.tabPageEleClassique.Text = "Éléments classiques";
            this.tabPageEleClassique.UseVisualStyleBackColor = true;
            // 
            // tabPagePersonnel
            // 
            this.tabPagePersonnel.Controls.Add(this.dataGridViewPersonnel);
            this.tabPagePersonnel.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePersonnel.Name = "tabPagePersonnel";
            this.tabPagePersonnel.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePersonnel.Size = new System.Drawing.Size(839, 324);
            this.tabPagePersonnel.TabIndex = 3;
            this.tabPagePersonnel.Text = "Personnel";
            this.tabPagePersonnel.UseVisualStyleBackColor = true;
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.Location = new System.Drawing.Point(638, 386);
            this.buttonValiderModif.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(209, 47);
            this.buttonValiderModif.TabIndex = 1;
            this.buttonValiderModif.Text = "Enregistrer modifications";
            this.buttonValiderModif.UseVisualStyleBackColor = true;
            this.buttonValiderModif.Click += new System.EventHandler(this.buttonValiderModif_Click);
            // 
            // buttonAnnulerModif
            // 
            this.buttonAnnulerModif.Location = new System.Drawing.Point(481, 386);
            this.buttonAnnulerModif.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnulerModif.Name = "buttonAnnulerModif";
            this.buttonAnnulerModif.Size = new System.Drawing.Size(153, 47);
            this.buttonAnnulerModif.TabIndex = 2;
            this.buttonAnnulerModif.Text = "Annuler modifications";
            this.buttonAnnulerModif.UseVisualStyleBackColor = true;
            this.buttonAnnulerModif.Click += new System.EventHandler(this.buttonAnnulerModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mise à jour des tarifs";
            // 
            // dataGridViewTarifsGeneraux
            // 
            this.dataGridViewTarifsGeneraux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarifsGeneraux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coutClient,
            this.prixRevient,
            this.marge});
            this.dataGridViewTarifsGeneraux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTarifsGeneraux.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewTarifsGeneraux.Name = "dataGridViewTarifsGeneraux";
            this.dataGridViewTarifsGeneraux.Size = new System.Drawing.Size(835, 320);
            this.dataGridViewTarifsGeneraux.TabIndex = 4;
            // 
            // coutClient
            // 
            this.coutClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coutClient.HeaderText = "Coût Client";
            this.coutClient.Name = "coutClient";
            this.coutClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prixRevient
            // 
            this.prixRevient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixRevient.HeaderText = "Coût de revient 2S";
            this.prixRevient.Name = "prixRevient";
            this.prixRevient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // marge
            // 
            this.marge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marge.HeaderText = "Marge Second Sens";
            this.marge.Name = "marge";
            this.marge.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTarifElementPerso
            // 
            this.dataGridViewTarifElementPerso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarifElementPerso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewTarifElementPerso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTarifElementPerso.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewTarifElementPerso.Name = "dataGridViewTarifElementPerso";
            this.dataGridViewTarifElementPerso.Size = new System.Drawing.Size(835, 320);
            this.dataGridViewTarifElementPerso.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Coût Client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Coût de revient 2S";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Marge Second Sens";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewElementClassique
            // 
            this.dataGridViewElementClassique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElementClassique.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewElementClassique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewElementClassique.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewElementClassique.Name = "dataGridViewElementClassique";
            this.dataGridViewElementClassique.Size = new System.Drawing.Size(835, 320);
            this.dataGridViewElementClassique.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Coût Client";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Coût de revient 2S";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Marge Second Sens";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridViewPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(835, 320);
            this.dataGridViewPersonnel.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Coût Client";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Coût de revient 2S";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "Marge Second Sens";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fenMajTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnnulerModif);
            this.Controls.Add(this.buttonValiderModif);
            this.Controls.Add(this.tabControlTarif);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fenMajTarifs";
            this.Text = "Mise à jour des tarifs";
            this.Load += new System.EventHandler(this.fenMajTarifs_Load);
            this.tabControlTarif.ResumeLayout(false);
            this.tabPageGeneraux.ResumeLayout(false);
            this.tabPageElePerso.ResumeLayout(false);
            this.tabPageEleClassique.ResumeLayout(false);
            this.tabPagePersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifsGeneraux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifElementPerso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElementClassique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTarif;
        private System.Windows.Forms.TabPage tabPageGeneraux;
        private System.Windows.Forms.TabPage tabPageElePerso;
        private System.Windows.Forms.TabPage tabPageEleClassique;
        private System.Windows.Forms.TabPage tabPagePersonnel;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.Button buttonAnnulerModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTarifsGeneraux;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixRevient;
        private System.Windows.Forms.DataGridViewTextBoxColumn marge;
        private System.Windows.Forms.DataGridView dataGridViewTarifElementPerso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridViewElementClassique;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}