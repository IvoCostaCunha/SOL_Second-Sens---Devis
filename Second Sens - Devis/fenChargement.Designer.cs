namespace Second_Sens___Devis
{
    partial class fenChargement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fenChargement));
            this.progressBarChargement = new System.Windows.Forms.ProgressBar();
            this.labelChargement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarChargement
            // 
            this.progressBarChargement.Location = new System.Drawing.Point(12, 241);
            this.progressBarChargement.Name = "progressBarChargement";
            this.progressBarChargement.Size = new System.Drawing.Size(776, 34);
            this.progressBarChargement.TabIndex = 1;
            this.progressBarChargement.Click += new System.EventHandler(this.progressBarChargement_Click);
            // 
            // labelChargement
            // 
            this.labelChargement.AutoSize = true;
            this.labelChargement.BackColor = System.Drawing.Color.Transparent;
            this.labelChargement.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChargement.ForeColor = System.Drawing.Color.White;
            this.labelChargement.Location = new System.Drawing.Point(12, 218);
            this.labelChargement.Name = "labelChargement";
            this.labelChargement.Size = new System.Drawing.Size(95, 20);
            this.labelChargement.TabIndex = 2;
            this.labelChargement.Text = "Chargement ...";
            // 
            // fenChargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.labelChargement);
            this.Controls.Add(this.progressBarChargement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fenChargement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "fenChargement";
            this.Load += new System.EventHandler(this.fenChargement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelChargement;
        public System.Windows.Forms.ProgressBar progressBarChargement;
    }
}