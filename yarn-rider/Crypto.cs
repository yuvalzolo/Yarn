using System;
using System.Text;
 
namespace yarn_rider
{
    public static class Crypto
    {
        public static string Hash(string value)
        {
            return Convert.ToBase64String(
                System.Security.Cryptography.SHA256.Create()
                    .ComputeHash(Encoding.UTF8.GetBytes(value))
            );
        }
    }
}