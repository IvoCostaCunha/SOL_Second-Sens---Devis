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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxTypeElem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations élément";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarifs";
            // 
            // tabControlTarifsElement
            // 
            this.tabControlTarifsElement.Controls.Add(this.tabTarifHeure);
            this.tabControlTarifsElement.Controls.Add(this.tabTarifJour);
            this.tabControlTarifsElement.Location = new System.Drawing.Point(12, 233);
            this.tabControlTarifsElement.Name = "tabControlTarifsElement";
            this.tabControlTarifsElement.SelectedIndex = 0;
            this.tabControlTarifsElement.Size = new System.Drawing.Size(461, 175);
            this.tabControlTarifsElement.TabIndex = 2;
            // 
            // tabTarifHeure
            // 
            this.tabTarifHeure.Controls.Add(this.dataGridViewTarifHeure);
            this.tabTarifHeure.Location = new System.Drawing.Point(4, 29);
            this.tabTarifHeure.Name = "tabTarifHeure";
            this.tabTarifHeure.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarifHeure.Size = new System.Drawing.Size(453, 142);
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
            this.dataGridViewTarifHeure.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTarifHeure.Name = "dataGridViewTarifHeure";
            this.dataGridViewTarifHeure.RowTemplate.Height = 28;
            this.dataGridViewTarifHeure.Size = new System.Drawing.Size(344, 53);
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
            this.tabTarifJour.Location = new System.Drawing.Point(4, 29);
            this.tabTarifJour.Name = "tabTarifJour";
            this.tabTarifJour.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarifJour.Size = new System.Drawing.Size(453, 142);
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
            this.dataGridViewTarifJour.Name = "dataGridViewTarifJour";
            this.dataGridViewTarifJour.RowTemplate.Height = 28;
            this.dataGridViewTarifJour.Size = new System.Drawing.Size(447, 104);
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
            this.labelQteElement.Location = new System.Drawing.Point(14, 135);
            this.labelQteElement.Name = "labelQteElement";
            this.labelQteElement.Size = new System.Drawing.Size(145, 29);
            this.labelQteElement.TabIndex = 3;
            this.labelQteElement.Text = "Qte élement";
            // 
            // labelNomElement
            // 
            this.labelNomElement.AutoSize = true;
            this.labelNomElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomElement.Location = new System.Drawing.Point(14, 106);
            this.labelNomElement.Name = "labelNomElement";
            this.labelNomElement.Size = new System.Drawing.Size(65, 29);
            this.labelNomElement.TabIndex = 4;
            this.labelNomElement.Text = "Nom";
            // 
            // textBoxNomElement
            // 
            this.textBoxNomElement.Location = new System.Drawing.Point(195, 106);
            this.textBoxNomElement.Name = "textBoxNomElement";
            this.textBoxNomElement.Size = new System.Drawing.Size(306, 26);
            this.textBoxNomElement.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 26);
            this.textBox1.TabIndex = 6;
            // 
            // comboBoxTypeElem
            // 
            this.comboBoxTypeElem.FormattingEnabled = true;
            this.comboBoxTypeElem.Location = new System.Drawing.Point(195, 72);
            this.comboBoxTypeElem.Name = "comboBoxTypeElem";
            this.comboBoxTypeElem.Size = new System.Drawing.Size(306, 28);
            this.comboBoxTypeElem.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type élément";
            // 
            // fenNouvelElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 627);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTypeElem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNomElement);
            this.Controls.Add(this.labelNomElement);
            this.Controls.Add(this.labelQteElement);
            this.Controls.Add(this.tabControlTarifsElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifTotalHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifRevientHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifMargeHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifTotalJour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifRevientJour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifMargeJour;
        private System.Windows.Forms.ComboBox comboBoxTypeElem;
        private System.Windows.Forms.Label label3;
    }
}