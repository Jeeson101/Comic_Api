using System.Collections;
using System.Text;
using System.Security.Cryptography;

namespace Comic_Api.Models.DB
{
	public class User
	{
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }



         public bool VerifyPassword(string IngevoerdeWW)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute hash of the plaintext password
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(IngevoerdeWW));

                // Compare the computed hash with the stored password hash
                return StructuralComparisons.StructuralEqualityComparer.Equals(hashBytes, PasswordHash);
            }
        }
	}
}
