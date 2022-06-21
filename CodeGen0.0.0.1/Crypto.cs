using System.IO;
using System.Security.Cryptography;
using System.Text;



namespace CodeGen0._0._0._1
{

    public class Crypto
    {
        public Crypto()
        {

        }
        public static Rfc2898DeriveBytes CreateKey(string password)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltBytes = SHA512.Create().ComputeHash(keyBytes);

            Rfc2898DeriveBytes result = new Rfc2898DeriveBytes(keyBytes, saltBytes, 500000);

            return result;
        }
        public static Rfc2898DeriveBytes CreateVector(string vector)
        {
            byte[] vectorBytes = Encoding.UTF8.GetBytes(vector);
            byte[] saltbytes = SHA512.Create().ComputeHash(vectorBytes);

            Rfc2898DeriveBytes result = new Rfc2898DeriveBytes(vectorBytes, saltbytes, 500000);
            return result;
        }

        public static byte[] Encrypt(byte[] origin, string password)
        {
            RijndaelManaged aes = new RijndaelManaged();
            Rfc2898DeriveBytes key = CreateKey(password);
            Rfc2898DeriveBytes vector = CreateVector("Er6EDVwji80SF9EDCrjf9hgtMwmHA2AA");


            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = key.GetBytes(32);
            aes.IV = vector.GetBytes(16);

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    cs.Write(origin, 0, origin.Length);
                }
                return ms.ToArray();
            }
        }
        public static byte[] Decrypt(byte[] origin, string password)
        {
            RijndaelManaged aes = new RijndaelManaged();
            Rfc2898DeriveBytes key = CreateKey(password);
            Rfc2898DeriveBytes vector = CreateVector("Er6EDVwji80SF9EDCrjf9hgtMwmHA2AA");

            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = key.GetBytes(32);
            aes.IV = vector.GetBytes(16);

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(origin, 0, origin.Length);
                    }
                    return ms.ToArray();
                }
            }
            catch
            {
                return origin;
            }

        }
    }
}
