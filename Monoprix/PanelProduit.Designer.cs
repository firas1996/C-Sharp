namespace Monoprix
{
    partial class PanelProduit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(-1, 78);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(168, 17);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "label1";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrix
            // 
            this.lblPrix.Location = new System.Drawing.Point(-1, 104);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(168, 23);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "label2";
            this.lblPrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(124, 78);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "label1";
            this.lblId.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PanelProduit";
            this.Size = new System.Drawing.Size(167, 128);
            this.Load += new System.EventHandler(this.PanelProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.Label lblPrix;
        public System.Windows.Forms.Label lblId;
    }
}
