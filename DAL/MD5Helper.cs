using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public static class MD5Helper
    {
        public static string Encrypt(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2")); // lowercase hex
                return sb.ToString();
            }
        }
    }
}
