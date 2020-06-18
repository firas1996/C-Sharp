namespace Monoprix
{
    partial class ProduitInfo
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
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblActeur = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgProduit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Location = new System.Drawing.Point(499, 268);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(35, 13);
            this.lblRelease.TabIndex = 30;
            this.lblRelease.Text = "label7";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(499, 210);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(41, 13);
            this.lblCategory.TabIndex = 29;
            this.lblCategory.Text = "label10";
            // 
            // lblActeur
            // 
            this.lblActeur.AutoSize = true;
            this.lblActeur.Location = new System.Drawing.Point(499, 157);
            this.lblActeur.Name = "lblActeur";
            this.lblActeur.Size = new System.Drawing.Size(41, 13);
            this.lblActeur.TabIndex = 28;
            this.lblActeur.Text = "label11";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(499, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "label12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Quantite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nom";
            // 
            // imgProduit
            // 
            this.imgProduit.Location = new System.Drawing.Point(37, 148);
            this.imgProduit.Name = "imgProduit";
            this.imgProduit.Size = new System.Drawing.Size(167, 75);
            this.imgProduit.TabIndex = 22;
            this.imgProduit.TabStop = false;
            // 
            // ProduitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblActeur);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgProduit);
            this.Name = "ProduitInfo";
            this.Text = "ProduitInfo";
            ((System.ComponentModel.ISupportInitialize)(this.imgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblRelease;
        public System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.Label lblActeur;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgProduit;
    }
}