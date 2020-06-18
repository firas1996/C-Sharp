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
    public class ProductsService
    {
        public IEnumerable<ProductModel> GetAllProducts()
        {
            var allProds = new List<ProductModel>();
            SqlDataReader reader = null;
            try
            {
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Produit", DbConnection.connection);


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var prod = new ProductModel
                    {
                        Code = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                        Prix = reader.GetDouble(2),
                        Quantite = reader.GetInt32(3),
                        Id_Categorie = reader.GetInt32(4),
                        Image = reader.GetString(5)
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
        public IEnumerable<CategorieModel> GetAllCategories()
        {
            var categories = new List<CategorieModel>();
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
                    var category = new CategorieModel
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                    };

                    categories.Add(category);
                }
                reader.Close();
                return categories;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                reader.Close();
                return null;
            }
        }
        public ProductModel GetProduitById(int id)
        {
            SqlDataReader reader = null;
            try
            {
                ProductModel produit = null;
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Produit WHERE (Code = @code)", DbConnection.connection);


                cmd.Parameters.AddWithValue("@code", id);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    produit = new ProductModel
                    {
                        Code = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                        Prix = reader.GetDouble(2),
                        Quantite = reader.GetInt32(3),
                        Id_Categorie = reader.GetInt32(4),
                        Image = reader.GetString(5)
                    };

                }
                reader.Close();
                return produit;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                reader.Close();
                return null;
            }
        }

        public CategorieModel GetCategoryById(int id)
        {
            SqlDataReader reader = null;
            try
            {
                CategorieModel category = null;
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Categorie WHERE (Id = @id)", DbConnection.connection);


                cmd.Parameters.AddWithValue("@id", id);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    category = new CategorieModel { Id = id, Nom = reader.GetString(1) };

                }
                reader.Close();
                return category;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                reader.Close();
                return null;
            }
        }
        public bool AddProduit(ProductModel produit)
        {
            try
            {
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Produit (Code, Nom, Prix, Quantite, Id_Categorie, Image) VALUES(@code, @nom, @prix, @quantite, @cat, @img)",
                    DbConnection.connection);

                cmd.Parameters.AddWithValue("@code", produit.Code);
                cmd.Parameters.AddWithValue("@nom", produit.Nom);
                cmd.Parameters.AddWithValue("@prix", produit.Prix);
                cmd.Parameters.AddWithValue("@quantite", produit.Quantite);
                cmd.Parameters.AddWithValue("@cat", produit.Id_Categorie);
                cmd.Parameters.AddWithValue("@img", produit.Image);

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
