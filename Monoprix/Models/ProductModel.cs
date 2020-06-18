using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoprix.Models
{
    public class ProductModel
    {
        public int Code { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }
        public int Id_Categorie { get; set; }
        public string Image { get; set; }

        public ProductModel()
        {
        }

    }
}
