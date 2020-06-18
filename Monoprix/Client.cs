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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); menu.Show();
            this.Hide();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
