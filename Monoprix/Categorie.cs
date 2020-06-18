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
    public partial class Categorie : Form
    {
        private CategorieService _categorieService = new CategorieService();
        public Categorie()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); menu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            var newFilm = new CategorieModel
            {
                Nom = this.textBoxCat.Text,
         
            };
           
            if (_categorieService.AddCategorie(newFilm))
            {
                MessageBox.Show("Categorie ajouté avec succès.", "Succès ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
