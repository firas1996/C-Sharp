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
    public partial class Utilisateur : Form
    {
        private int errors = 0;
        userService _userService = new userService();
        public Utilisateur()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            errors = 0;
            UserModel newUser = new UserModel();
            newUser.Nom = txtNom.Text;
            newUser.Prenom = txtPrenom.Text;
            newUser.Email = txtEmail.Text;
           // newUser.CIN = txtCIN.Value;
            newUser.Password = txtPassword.Text;
            //newUser.Tel = txtCIN.Value;
            newUser.Poste = txtCIN.Text;
            if (radioAdmin.Checked)
            {
                newUser.IsAdmin = 1;
            }
            else
            {
                newUser.IsAdmin = 0;
            }
         bool result =   _userService.CreateEmployee(newUser);
            if (result) { MessageBox.Show("Modification effecutée avec succès !"); }
            else { MessageBox.Show("Modification échouée, veuillez réessayer !"); }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); menu.Show();
            this.Hide();
        }
    }
}
