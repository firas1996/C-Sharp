using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoprix.Models
{
   public class UserModel
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }
        public int CIN { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string Poste { get; set; }
        public int IsAdmin { get; set; }
        //public EnumGender Post { get; set; }

        //public EnumStatus Status { get; set; }




    }
}
