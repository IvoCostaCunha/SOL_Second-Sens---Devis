namespace Second_Sens___Devis
{
    partial class fenNouvelElement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlTarifsElement = new System.Windows.Forms.TabControl();
            this.tabTarifHeure = new System.Windows.Forms.TabPage();
            this.dataGridViewTarifHeure = new System.Windows.Forms.DataGridView();
            this.colTarifTotalHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifRevientHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifMargeHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTarifJour = new System.Windows.Forms.TabPage();
            this.dataGridViewTarifJour = new System.Windows.Forms.DataGridView();
            this.colTarifTotalJour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifRevientJour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifMargeJour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQteElement = new System.Windows.Forms.Label();
            this.labelNomElement = new System.Windows.Forms.Label();
            this.textBoxNomElement = new System.Windows.Forms.TextBox();
            this.textBoxQteElement = new System.Windows.Forms.TextBox();
            this.comboBoxTypeElem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxnbHparJour = new System.Windows.Forms.TextBox();
            this.textBoxnbJours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.tabControlTarifsElement.SuspendLayout();
            this.tabTarifHeure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifHeure)).BeginInit();
            this.tabTarifJour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifJour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations élément";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarifs";
            // 
            // tabControlTarifsElement
            // 
            this.tabControlTarifsElement.Controls.Add(this.tabTarifHeure);
            this.tabControlTarifsElement.Controls.Add(this.tabTarifJour);
            this.tabControlTarifsElement.Location = new System.Drawing.Point(366, 47);
            this.tabControlTarifsElement.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlTarifsElement.Name = "tabControlTarifsElement";
            this.tabControlTarifsElement.SelectedIndex = 0;
            this.tabControlTarifsElement.Size = new System.Drawing.Size(477, 171);
            this.tabControlTarifsElement.TabIndex = 2;
            // 
            // tabTarifHeure
            // 
            this.tabTarifHeure.Controls.Add(this.dataGridViewTarifHeure);
            this.tabTarifHeure.Location = new System.Drawing.Point(4, 22);
            this.tabTarifHeure.Margin = new System.Windows.Forms.Padding(2);
            this.tabTarifHeure.Name = "tabTarifHeure";
            this.tabTarifHeure.Padding = new System.Windows.Forms.Padding(2);
            this.tabTarifHeure.Size = new System.Drawing.Size(469, 145);
            this.tabTarifHeure.TabIndex = 0;
            this.tabTarifHeure.Text = "Tarif / Heure";
            this.tabTarifHeure.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTarifHeure
            // 
            this.dataGridViewTarifHeure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarifHeure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTarifTotalHeure,
            this.colTarifRevientHeure,
            this.colTarifMargeHeure});
            this.dataGridViewTarifHeure.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewTarifHeure.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTarifHeure.Name = "dataGridViewTarifHeure";
            this.dataGridViewTarifHeure.RowTemplate.Height = 28;
            this.dataGridViewTarifHeure.Size = new System.Drawing.Size(461, 122);
            this.dataGridViewTarifHeure.TabIndex = 7;
            // 
            // colTarifTotalHeure
            // 
            this.colTarifTotalHeure.HeaderText = "Total";
            this.colTarifTotalHeure.Name = "colTarifTotalHeure";
            // 
            // colTarifRevientHeure
            // 
            this.colTarifRevientHeure.HeaderText = "Revient";
            this.colTarifRevientHeure.Name = "colTarifRevientHeure";
            // 
            // colTarifMargeHeure
            // 
            this.colTarifMargeHeure.HeaderText = "Marge";
            this.colTarifMargeHeure.Name = "colTarifMargeHeure";
            // 
            // tabTarifJour
            // 
            this.tabTarifJour.Controls.Add(this.dataGridViewTarifJour);
            this.tabTarifJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTarifJour.Location = new System.Drawing.Point(4, 22);
            this.tabTarifJour.Margin = new System.Windows.Forms.Padding(2);
            this.tabTarifJour.Name = "tabTarifJour";
            this.tabTarifJour.Padding = new System.Windows.Forms.Padding(2);
            this.tabTarifJour.Size = new System.Drawing.Size(469, 145);
            this.tabTarifJour.TabIndex = 1;
            this.tabTarifJour.Text = "Tarif / Jour";
            this.tabTarifJour.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTarifJour
            // 
            this.dataGridViewTarifJour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarifJour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTarifTotalJour,
            this.colTarifRevientJour,
            this.colTarifMargeJour});
            this.dataGridViewTarifJour.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTarifJour.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTarifJour.Name = "dataGridViewTarifJour";
            this.dataGridViewTarifJour.RowTemplate.Height = 28;
            this.dataGridViewTarifJour.Size = new System.Drawing.Size(473, 141);
            this.dataGridViewTarifJour.TabIndex = 8;
            // 
            // colTarifTotalJour
            // 
            this.colTarifTotalJour.HeaderText = "Total";
            this.colTarifTotalJour.Name = "colTarifTotalJour";
            // 
            // colTarifRevientJour
            // 
            this.colTarifRevientJour.HeaderText = "Revient";
            this.colTarifRevientJour.Name = "colTarifRevientJour";
            // 
            // colTarifMargeJour
            // 
            this.colTarifMargeJour.HeaderText = "Marge";
            this.colTarifMargeJour.Name = "colTarifMargeJour";
            // 
            // labelQteElement
            // 
            this.labelQteElement.AutoSize = true;
            this.labelQteElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQteElement.Location = new System.Drawing.Point(9, 107);
            this.labelQteElement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQteElement.Name = "labelQteElement";
            this.labelQteElement.Size = new System.Drawing.Size(96, 20);
            this.labelQteElement.TabIndex = 3;
            this.labelQteElement.Text = "Qte élement";
            // 
            // labelNomElement
            // 
            this.labelNomElement.AutoSize = true;
            this.labelNomElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomElement.Location = new System.Drawing.Point(9, 78);
            this.labelNomElement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomElement.Name = "labelNomElement";
            this.labelNomElement.Size = new System.Drawing.Size(42, 20);
            this.labelNomElement.TabIndex = 4;
            this.labelNomElement.Text = "Nom";
            // 
            // textBoxNomElement
            // 
            this.textBoxNomElement.Location = new System.Drawing.Point(130, 78);
            this.textBoxNomElement.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomElement.Name = "textBoxNomElement";
            this.textBoxNomElement.Size = new System.Drawing.Size(205, 20);
            this.textBoxNomElement.TabIndex = 5;
            // 
            // textBoxQteElement
            // 
            this.textBoxQteElement.Location = new System.Drawing.Point(130, 109);
            this.textBoxQteElement.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQteElement.Name = "textBoxQteElement";
            this.textBoxQteElement.Size = new System.Drawing.Size(205, 20);
            this.textBoxQteElement.TabIndex = 6;
            // 
            // comboBoxTypeElem
            // 
            this.comboBoxTypeElem.FormattingEnabled = true;
            this.comboBoxTypeElem.Location = new System.Drawing.Point(130, 48);
            this.comboBoxTypeElem.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTypeElem.Name = "comboBoxTypeElem";
            this.comboBoxTypeElem.Size = new System.Drawing.Size(205, 21);
            this.comboBoxTypeElem.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type élément";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre d\'heures / jour";
            // 
            // textBoxnbHparJour
            // 
            this.textBoxnbHparJour.Location = new System.Drawing.Point(208, 136);
            this.textBoxnbHparJour.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbHparJour.Name = "textBoxnbHparJour";
            this.textBoxnbHparJour.Size = new System.Drawing.Size(127, 20);
            this.textBoxnbHparJour.TabIndex = 11;
            // 
            // textBoxnbJours
            // 
            this.textBoxnbJours.Location = new System.Drawing.Point(208, 166);
            this.textBoxnbJours.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbJours.Name = "textBoxnbJours";
            this.textBoxnbJours.Size = new System.Drawing.Size(127, 20);
            this.textBoxnbJours.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre de jours";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(15, 208);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(320, 36);
            this.buttonAjouter.TabIndex = 14;
            this.buttonAjouter.Text = "Ajouter l\'élément";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // fenNouvelElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 256);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxnbJours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxnbHparJour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTypeElem);
            this.Controls.Add(this.textBoxQteElement);
            this.Controls.Add(this.textBoxNomElement);
            this.Controls.Add(this.labelNomElement);
            this.Controls.Add(this.labelQteElement);
            this.Controls.Add(this.tabControlTarifsElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fenNouvelElement";
            this.Text = "Nouvel Elément";
            this.Load += new System.EventHandler(this.fenNouvelElement_Load);
            this.tabControlTarifsElement.ResumeLayout(false);
            this.tabTarifHeure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifHeure)).EndInit();
            this.tabTarifJour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifJour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlTarifsElement;
        private System.Windows.Forms.TabPage tabTarifHeure;
        private System.Windows.Forms.DataGridView dataGridViewTarifHeure;
        private System.Windows.Forms.TabPage tabTarifJour;
        private System.Windows.Forms.DataGridView dataGridViewTarifJour;
        private System.Windows.Forms.Label labelQteElement;
        private System.Windows.Forms.Label labelNomElement;
        private System.Windows.Forms.TextBox textBoxNomElement;
        private System.Windows.Forms.TextBox textBoxQteElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifTotalHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifRevientHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifMargeHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifTotalJour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifRevientJour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifMargeJour;
        private System.Windows.Forms.ComboBox comboBoxTypeElem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxnbHparJour;
        private System.Windows.Forms.TextBox textBoxnbJours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAjouter;
    }
}