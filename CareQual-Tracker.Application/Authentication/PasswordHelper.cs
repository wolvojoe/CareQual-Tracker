using System;
using System.Security.Cryptography;

namespace CareQual_Tracker.Application.Authentication
{
    public static class PasswordHelper
    {
        public static void CreatePasswordHash(string password, out string hash, out string salt)
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }

            salt = Convert.ToBase64String(saltBytes);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000))
            {
                byte[] hashBytes = pbkdf2.GetBytes(32);
                hash = Convert.ToBase64String(hashBytes);
            }
        }


        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000))
            {
                byte[] hashBytes = pbkdf2.GetBytes(32);
                string computedHash = Convert.ToBase64String(hashBytes);

                return computedHash == storedHash;
            }
        }
    }
}
