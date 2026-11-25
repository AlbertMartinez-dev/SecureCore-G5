using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureCore
{
    public static class HashUser
    {
        
        public static string Hash(string text)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(bytes);
            }
        }

        
        public static string GenerarSalt()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }

        public static string PasswordSaltat(string password, string salt)
        {
            return Hash(password + salt);
        }
    }
}