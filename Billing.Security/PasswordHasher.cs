using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Security
{
    public class PasswordHasher
    {
        private const int PBKDF2IterCount = 1000; // default for Rfc2898DeriveBytes
        private const int PBKDF2SubkeyLength = 256 / 8; // 256 bits
        private const int SaltSize = 128 / 8; // 128 bits

        /// <summary>
        /// Get new instance of PasswordHasher with HashPassword and SaltPassword
        /// </summary>
        /// <param name="Password">
        /// Password to be Hashing
        /// </param>
        public PasswordHasher(string Password)
        {
            this.GenerateHashPassword(Password);
        }

        public string SaltPassword { get; set; }
        public string HashPassword { get; set; }

        private void GenerateHashPassword(string Password)
        {
            try
            {
                if (Password == null)
                {
                    throw new ArgumentNullException("password");
                }

                using (var deriveBytes = new Rfc2898DeriveBytes(Password, SaltSize, PBKDF2IterCount))
                {
                    this.SaltPassword = Convert.ToBase64String(deriveBytes.Salt);
                    this.HashPassword = Convert.ToBase64String(deriveBytes.GetBytes(PBKDF2SubkeyLength));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool VerifyHashPassword(string hashPassword, string saltPassword, string password)
        {
            if (string.IsNullOrWhiteSpace(hashPassword))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("password");
            }
            if (string.IsNullOrWhiteSpace(saltPassword))
            {
                return (hashPassword == password);
            }

            byte[] saltArr = Convert.FromBase64String(saltPassword);
            byte[] hashArr = Convert.FromBase64String(hashPassword);

            var hashedPasswordBytes = new byte[1 + SaltSize + PBKDF2SubkeyLength];
            Buffer.BlockCopy(saltArr, 0, hashedPasswordBytes, 1, SaltSize);
            Buffer.BlockCopy(hashArr, 0, hashedPasswordBytes, 1 + SaltSize, PBKDF2SubkeyLength);


            // Verify a version 0 (see comment above) text hash.
            if (hashedPasswordBytes.Length != (1 + SaltSize + PBKDF2SubkeyLength) || hashedPasswordBytes[0] != 0x00)
            {
                // Wrong length or version header.
                return false;
            }

            byte[] generatedSubkey;
            using (var deriveBytes = new Rfc2898DeriveBytes(password, saltArr, PBKDF2IterCount))
            {
                generatedSubkey = deriveBytes.GetBytes(PBKDF2SubkeyLength);
            }
            return ByteArraysEqual(hashArr, generatedSubkey);
        }

        // Compares two byte arrays for equality. The method is specifically written so that the loop is not optimized.
        [MethodImpl(MethodImplOptions.NoOptimization)]
        private static bool ByteArraysEqual(byte[] a, byte[] b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a == null || b == null || a.Length != b.Length)
            {
                return false;
            }

            var areSame = true;
            for (var i = 0; i < a.Length; i++)
            {
                areSame &= (a[i] == b[i]);
            }
            return areSame;
        }
    }
}
