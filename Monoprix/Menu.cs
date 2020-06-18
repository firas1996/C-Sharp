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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GetUser_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur(); utilisateur.Show();
            this.Hide();
        }

        private void GetProduct_Click(object sender, EventArgs e)
        {
            Produit produit = new Produit(); produit.Show();
            this.Hide();
        }

        private void GetCategorie_Click(object sender, EventArgs e)
        {
            ListCategorie categorie = new ListCategorie(); categorie.Show();
            this.Hide();
        }

        private void GetClient_Click(object sender, EventArgs e)
        {
            Client client = new Client(); client.Show();
            this.Hide();
        }
    }
}
