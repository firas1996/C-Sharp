namespace Monoprix
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GetProduct = new System.Windows.Forms.PictureBox();
            this.GetCategorie = new System.Windows.Forms.PictureBox();
            this.GetClient = new System.Windows.Forms.PictureBox();
            this.GetUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GetProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Produit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Client";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Catégorie";
            // 
            // GetProduct
            // 
            this.GetProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GetProduct.BackgroundImage")));
            this.GetProduct.Location = new System.Drawing.Point(401, 12);
            this.GetProduct.Name = "GetProduct";
            this.GetProduct.Size = new System.Drawing.Size(189, 184);
            this.GetProduct.TabIndex = 3;
            this.GetProduct.TabStop = false;
            this.GetProduct.Click += new System.EventHandler(this.GetProduct_Click);
            // 
            // GetCategorie
            // 
            this.GetCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GetCategorie.BackgroundImage")));
            this.GetCategorie.Location = new System.Drawing.Point(173, 232);
            this.GetCategorie.Name = "GetCategorie";
            this.GetCategorie.Size = new System.Drawing.Size(166, 184);
            this.GetCategorie.TabIndex = 2;
            this.GetCategorie.TabStop = false;
            this.GetCategorie.Click += new System.EventHandler(this.GetCategorie_Click);
            // 
            // GetClient
            // 
            this.GetClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GetClient.BackgroundImage")));
            this.GetClient.Location = new System.Drawing.Point(401, 232);
            this.GetClient.Name = "GetClient";
            this.GetClient.Size = new System.Drawing.Size(189, 184);
            this.GetClient.TabIndex = 1;
            this.GetClient.TabStop = false;
            this.GetClient.Click += new System.EventHandler(this.GetClient_Click);
            // 
            // GetUser
            // 
            this.GetUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GetUser.BackgroundImage")));
            this.GetUser.Location = new System.Drawing.Point(159, 12);
            this.GetUser.Name = "GetUser";
            this.GetUser.Size = new System.Drawing.Size(189, 184);
            this.GetUser.TabIndex = 0;
            this.GetUser.TabStop = false;
            this.GetUser.Click += new System.EventHandler(this.GetUser_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetProduct);
            this.Controls.Add(this.GetCategorie);
            this.Controls.Add(this.GetClient);
            this.Controls.Add(this.GetUser);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.GetProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GetUser;
        private System.Windows.Forms.PictureBox GetClient;
        private System.Windows.Forms.PictureBox GetCategorie;
        private System.Windows.Forms.PictureBox GetProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}