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
            this.connectionString =  "Server=MSI\\VIVES;Database=SuperheroDB;Trusted_Connection=True;TrustServerCertificate=True";
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
            }

            return users;
        }
	}
}
