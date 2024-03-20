using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Comic_Api.Models.DB
{
	public class FavoriteSuperheroDB
	{

        private string connectionString;

        public FavoriteSuperheroDB()
        {
            // Set your SQL Server connection string here
            this.connectionString = "Server=MSI\\VIVES;Database=SuperheroDB;Trusted_Connection=True;TrustServerCertificate=True";
        }

        public List<FavoriteSuperhero> GetFavoriteSuperheroesByUserID(int userID)
        {
            List<FavoriteSuperhero> favoriteSuperheroes = new List<FavoriteSuperhero>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FavoriteID, UserID, SuperheroID FROM FavoriteSuperhero WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    FavoriteSuperhero favoriteSuperhero = new FavoriteSuperhero
                    {
                        FavoriteID = Convert.ToInt32(reader["FavoriteID"]),
                        UserID = Convert.ToInt32(reader["UserID"]),
                        SuperheroID = Convert.ToInt32(reader["SuperheroID"])
                    };
                    favoriteSuperheroes.Add(favoriteSuperhero);
                }
                reader.Close();
                connection.Close();
            }

            return favoriteSuperheroes;
        }

        public void AddFavoriteSuperhero(int userID, int superheroID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO FavoriteSuperhero (UserID, SuperheroID) VALUES (@UserID, @SuperheroID)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@SuperheroID", superheroID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void RemoveFavoriteSuperhero(int userID, int superheroID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM FavoriteSuperhero WHERE UserID = @UserID AND SuperheroID = @SuperheroID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@SuperheroID", superheroID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}