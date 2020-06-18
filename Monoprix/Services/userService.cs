using Monoprix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Monoprix.DatabaseAccess.Configuration;

namespace Monoprix.Services
{
   public class userService
    {
        static string errorMessage = "";

        public UserModel GetUserByEmail(string email)
        {
            SqlDataReader reader = null;
            try
            {
                UserModel user = null;
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE (email = @em)", DbConnection.connection);


                cmd.Parameters.AddWithValue("@em", email);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {                 
                    user = new UserModel();
                    user.Id= reader.GetInt32(0);

                    user.Nom = reader.GetString(reader.GetOrdinal("Nom"));

                    user.Prenom = reader.GetString(reader.GetOrdinal("Prenom"));
                    user.CIN = reader.GetInt32(3);
                    user.Email = reader.GetString(reader.GetOrdinal("Email"));

                    user.Password = reader.GetString(reader.GetOrdinal("Password"));
                }
                reader.Close();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                reader.Close();
                return null;
            }
        }
        public UserModel Connexion(string email, string password)
        {
            
            SqlDataReader reader = null;
            try
            {
                UserModel user = null;
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                SqlCommand cmd = new SqlCommand("SELECT Password FROM Employee  WHERE (Email = @em)", DbConnection.connection); 

                cmd.Parameters.AddWithValue("@em", email);

                reader = cmd.ExecuteReader();
                var has = reader.HasRows;
                var hasRead = reader.Read();                
                if (hasRead)
                {
                    var PasswordUser = reader.GetString(0);

                    if (PasswordUser == password) {
                        reader.Close();
                        user = GetUserByEmail(email);

                        return user;
                    }
                       
                    
                }
                reader.Close();
                return user;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;

                reader.Close();
                return null;
            }
        }
        public bool CreateEmployee(UserModel user)
        {
            try
            {
                if (!DbConnection.IsConnected())
                {
                    DbConnection.InitDb();
                }
                string firstName = user.Prenom;
                string lastName = user.Nom;
                string email = user.Email;
                string password = user.Password;
                int cin = user.CIN;


                SqlCommand cmd = new SqlCommand("INSERT INTO Employee" +
                    "(Nom, Prenom, CIN, Email, Password, Tel, Poste, IsAdmin) " +
                    "VALUES (@fn, @ln,@cn, @em, @pass, @tel, @pst, @adm)",
                    DbConnection.connection);

                cmd.Parameters.AddWithValue("@fn", firstName);
                cmd.Parameters.AddWithValue("@ln", lastName);
                cmd.Parameters.AddWithValue("@cn", email);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@pass", password);
               
                //cmd.Parameters.AddWithValue("@tel", gender);
                //cmd.Parameters.AddWithValue("@pst", profilePic);
                //cmd.Parameters.AddWithValue("@adm", status);                
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return false;
        }
    }
    
}
