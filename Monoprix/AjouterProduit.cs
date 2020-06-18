using Monoprix.Models;
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
    public partial class AjouterProduit : Form
    {
        private string filePath = "";
        private string imaage = "C:\\Users\\firas\\Downloads\\hitman.jpg";
        private ProductsService productsService = new ProductsService();
        public AjouterProduit()
        {
            InitializeComponent();
            LoadAllCategories();

            this.pictureBox1.Image = Image.FromFile(imaage);
        }

        private void LoadAllCategories()
        {
            var categories = productsService.GetAllCategories();
            foreach (var cat in categories)
            {
                this.comboCategory.Items.Add(cat.Nom);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Categorie cat = new Categorie(); cat.Show();
            this.Hide();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                filePath = choofdlog.FileName;
                pictureBox4.Image = Image.FromFile(filePath);
            }

            else
                filePath = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoryId = this.comboCategory.SelectedIndex + 1;
            var newProduit = new ProductModel
            {
                Code = Int32.Parse(this.txtCode.Text),
                Nom = this.txtNom.Text,
                Prix = Double.Parse(this.txtPrix.Text),
                Quantite = Int32.Parse(this.txtQuantite.Text),
                Id_Categorie = categoryId,
                Image = filePath
            };

            if (productsService.AddProduit(newProduit))
            {
                MessageBox.Show("Jeux ajouté avec succès.", "Succès ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); menu.Show();
            this.Hide();
        }
    }
}
