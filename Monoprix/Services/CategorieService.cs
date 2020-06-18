using Monoprix.DatabaseAccess.Configuration;
using Monoprix.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoprix.Services
{
   public class CategorieService
    {
        public IEnumerable<CategorieModel> GetAllCategories()
        {
            var allProds = new List<CategorieModel>();
            SqlDataReader reader = null;
            try
            {
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Categorie", DbConnection.connection);


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var prod = new CategorieModel
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                       
                    };

                    allProds.Add(prod);
                }
                reader.Close();
                return allProds;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                reader.Close();
                return null;
            }
        }

        public bool AddCategorie(CategorieModel cat)
        {
            try
            {
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Categorie (Nom) VALUES(@title)",
                    DbConnection.connection);

                cmd.Parameters.AddWithValue("@title", cat.Nom);
            

                int nbLignes = cmd.ExecuteNonQuery();
                if (nbLignes != 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
