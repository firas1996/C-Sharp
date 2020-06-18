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
    public partial class ListCategorie : Form
    {
        private int initialX = 15;
        private int initialY = 31;

        private CategorieService categorieService = new CategorieService();
        public ListCategorie()
        {
            InitializeComponent();
            InitPanelCategorie();
        }
        public void InitPanelCategorie()
        {

            var allProducts = categorieService.GetAllCategories();
            var newX = initialX;
            var newY = initialY;

            var i = 0;
            foreach (var product in allProducts)
            {
                PanelCategorie panel = new PanelCategorie();
                //panel.lblId.Text = product.Id.ToString();
                panel.labelCat.Text = product.Nom;
                // panel.lblPrix.Text = product.Price.ToString() + "dt";
                // panel.pictureBox1.Image = Image.FromFile(product.Image);
                // panel.pictureBox1.Click += new EventHandler((s, e) => ImgProduct_Click(s, e, Int32.Parse(panel.lblId.Text)));

                panel.Location = new Point(newX, newY);

                this.panel5.Controls.Add(panel);
                i++;
                newX += 310;

                if (i % 3 == 0)
                {
                    newY += 70;
                    newX = initialX;
                }

            }
        }
        private void ListCategorie_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categorie categorie = new Categorie(); categorie.Show();
            this.Hide();
        }
    }
}
