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
            this.progressBarChargement.Location = new System.Drawing.Point(12, 156);
            this.progressBarChargement.Name = "progressBarChargement";
            this.progressBarChargement.Size = new System.Drawing.Size(476, 20);
            this.progressBarChargement.TabIndex = 1;
            this.progressBarChargement.Click += new System.EventHandler(this.progressBarChargement_Click);
            // 
            // labelChargement
            // 
            this.labelChargement.AutoSize = true;
            this.labelChargement.BackColor = System.Drawing.Color.Transparent;
            this.labelChargement.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChargement.ForeColor = System.Drawing.Color.White;
            this.labelChargement.Location = new System.Drawing.Point(12, 133);
            this.labelChargement.Name = "labelChargement";
            this.labelChargement.Size = new System.Drawing.Size(95, 20);
            this.labelChargement.TabIndex = 2;
            this.labelChargement.Text = "Chargement ...";
            // 
            // fenChargement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 188);
            this.Controls.Add(this.labelChargement);
            this.Controls.Add(this.progressBarChargement);
            this.DoubleBuffered = true;
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