using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OrderOrganizer_Capstone.Objects
{
    public class CryptoManager
    {
        // TODO extract magic numbers
        // TODO method cleanup / comments

        private const int ITERATIONS = 5000;

        public HashedPasswordInfo GetNewHash(string password)
        {
            byte[] salt;
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, ITERATIONS);
            var hash = pbkdf2.GetBytes(20);
            var hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            var storedPasswordHash = Convert.ToBase64String(hashBytes);

            return new HashedPasswordInfo(salt, storedPasswordHash);
        }

        public bool CheckPasswordMatch(string password, string retreived_hash, byte[] retrieved_salt)
        {
            byte[] hashBytes = Convert.FromBase64String(retreived_hash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, ITERATIONS);
            byte[] hash = pbkdf2.GetBytes(20);

            bool isMatch = true;
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i]) isMatch = false;
            }

            return isMatch;
        }
    }

    public struct HashedPasswordInfo
    {
        public HashedPasswordInfo(byte[] _salt, string _storedPasswordHash)
        {
            PasswordHash = _storedPasswordHash;
            Salt = _salt;
        }
        public string PasswordHash { get; }
        public byte[] Salt { get; }
    }
}
