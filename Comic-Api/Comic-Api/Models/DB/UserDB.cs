using Microsoft.AspNetCore.Hosting.Server;
using System.Data.SqlClient;

namespace Comic_Api.Models.DB
{
    public class UserDB
    {
        private string connectionString;

        public UserDB()
        {
            //Hier moet je je sql server invoeren 
           // this.connectionString = "Server=YES\\VIVES;Database=SuperheroDB;Trusted_Connection=True;TrustServerCertificate=True";
           this.connectionString = "Server=MSI\\VIVES;Database=SuperheroDB;Trusted_Connection=True;TrustServerCertificate=True";
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, FirstName, LastName, Email, PasswordHash FROM UserAccounts";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        PasswordHash = (byte[])reader["PasswordHash"]
                    };
                    users.Add(user);
                }
                reader.Close();
                connection.Close();
            }

            return users;
        }

        public User GetUserByID(int userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, FirstName, LastName, Email, PasswordHash FROM UserAccounts WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    User user = new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        PasswordHash = (byte[])reader["PasswordHash"]
                    };
                    reader.Close();
                    connection.Close();
                    return user;
                }
                connection.Close();
            }

            return null; // User not found
        }

        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserAccounts (FirstName, LastName, Email, PasswordHash) VALUES (@FirstName, @LastName, @Email, @PasswordHash)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
