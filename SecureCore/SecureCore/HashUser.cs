using System;
using System.Security.Cryptography;

namespace SecureCore
{
    public static class HashUser
    {
        private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HashingIterationsCount = 10101;

        public static string GenerarSalt()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltByteSize];
                rng.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }

        public static string PasswordSaltat(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            using (Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, saltBytes))
            {
                hashGenerator.IterationCount = HashingIterationsCount;
                return Convert.ToBase64String(hashGenerator.GetBytes(HashByteSize));
            }
        }
    }
}
