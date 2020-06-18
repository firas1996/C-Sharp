namespace Monoprix
{
    partial class PanelCategorie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.BackColor = System.Drawing.Color.Transparent;
            this.labelCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.ForeColor = System.Drawing.Color.Red;
            this.labelCat.Location = new System.Drawing.Point(45, 31);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(66, 24);
            this.labelCat.TabIndex = 0;
            this.labelCat.Text = "label1";
            // 
            // PanelCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCat);
            this.Name = "PanelCategorie";
            this.Size = new System.Drawing.Size(357, 97);
            this.Load += new System.EventHandler(this.PanelCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelCat;
    }
}
