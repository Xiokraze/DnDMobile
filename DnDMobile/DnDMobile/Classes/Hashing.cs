using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DnDMobile.Classes
{
    class Hashing
    {
        private const int ITERATIONS = 10000;
        private const int HASH_SIZE = 20;
        private const int SALT_SIZE = 16;
        private const int BYTE_SIZE = HASH_SIZE + SALT_SIZE;


        // Utilize PBKDF2 encryption with salt and hashing to convert a typed password into a string of characters.
        public string RegistrationHash(string text)
        {
            // Generate random salt.
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SALT_SIZE]);

            // Hash and salt the password using PBKDF2.
            var pbdkdf2 = new Rfc2898DeriveBytes(text, salt, ITERATIONS);
            byte[] hash = pbdkdf2.GetBytes(HASH_SIZE);

            // Create byte array to hold salt+hashed values.
            byte[] hashBytes = new byte[BYTE_SIZE];
            Array.Copy(salt, 0, hashBytes, 0, SALT_SIZE);
            Array.Copy(hash, 0, hashBytes, SALT_SIZE, HASH_SIZE);

            // Convert salt+hashed byte array to a string.
            string pwHash = Convert.ToBase64String(hashBytes);
            return pwHash;
        }
    }



}
