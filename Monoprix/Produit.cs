using Monoprix.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monoprix
{
    public partial class Produit : Form
    {
        private int initialX = 7;
        private int initialY = 31;
    //    private int idCategory;
        private ProductsService productService = new ProductsService();

        public Produit()
        {
            InitializeComponent();
          //  this.idCategory = id;
            InitPanelProducts();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); menu.Show();
            this.Hide();
        }

        public void InitPanelProducts()
        {
           
            var allProducts = productService.GetAllProducts();
            var newX = initialX;
            var newY = initialY;

            var i = 0;
            foreach (var product in allProducts)
            {
                PanelProduit panel = new PanelProduit();
                panel.lblId.Text = product.Code.ToString();
                panel.lblNom.Text = product.Nom;
                panel.lblPrix.Text = product.Prix.ToString()+"dt";
                panel.pictureBox1.Image = Image.FromFile(product.Image);
                panel.pictureBox1.Click += new EventHandler((s, e) => ImgProduct_Click(s, e, Int32.Parse(panel.lblId.Text)));

                panel.Location = new Point(newX, newY);

                this.panel5.Controls.Add(panel);
                i++;
                newX += 236;

                if (i % 4 == 0)
                {
                    newY += 147;
                    newX = initialX;
                }

            }
        }


        private void ImgProduct_Click(Object sender, EventArgs e, int id)
        {
            new ProduitInfo(id).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterProduit categorie = new AjouterProduit(); categorie.Show();
            this.Hide();
        }
    }
}
