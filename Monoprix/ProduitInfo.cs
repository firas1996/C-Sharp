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
    
    public partial class ProduitInfo : Form
    {
        private int id;
        private ProductsService produitService = new ProductsService();
        public ProduitInfo(int id)
        {
            InitializeComponent();
            this.id = id;
            InitFields();
        }
        public void InitFields()
        {
            var produit = produitService.GetProduitById(this.id);
            var category = produitService.GetCategoryById(produit.Id_Categorie);

            this.lblName.Text = produit.Nom;
            this.lblActeur.Text = produit.Prix.ToString();
            this.lblCategory.Text = category.Nom;
            this.lblRelease.Text = produit.Quantite.ToString();
            this.imgProduit.Image = Image.FromFile(produit.Image);
        }
    }
}
