using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace App1
{
    class Password
    {
        private const int saltLengthLimit = 24;
        public String hashedPassword { get; set; }
        public String salt { get; set; }
        
        public Password(string password)
        {
            salt = System.Text.Encoding.Default.GetString(GetSalt());
            hashedPassword = hash(password + salt);
        }
        public Password(string password, string salt)
        {
            this.salt = salt;
            this.hashedPassword = hash(password + salt);
        }
        public bool provjeriPass(string password)
        {
            return hashedPassword == hash(password + salt);
        }
        private static byte[] GetHash(string inputString) 
        {
            HashAlgorithm algorithm = MD5.Create();  
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        private String hash(String inputString) //vraca md5 hash unesenog stringa
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
        private static byte[] GetSalt() //daje random salt definirane duzine
        {
            return GetSalt(saltLengthLimit);
        }
        private static byte[] GetSalt(int maximumSaltLength) 
        {
            var salt = new byte[maximumSaltLength];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }
            return salt;
        }
    }
}
