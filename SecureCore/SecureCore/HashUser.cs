using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureCore
{
    public static class HashUser
    {
        // SHA256: text -> bytes (UTF8) -> hash -> text "7A-EF-..."
        public static string Hash(string text)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(bytes);
            }
        }

        // Salt aleatori i segur, en Base64 per guardar-lo a la BD
        public static string GenerarSalt()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }

        // La fórmula del projecte: hash del password + salt
        public static string PasswordSaltat(string password, string salt)
        {
            return Hash(password + salt);
        }
    }
}