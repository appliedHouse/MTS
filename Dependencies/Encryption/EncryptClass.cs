using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    public class EncryptClass
    {
        private static string KeyValue = "L7j+gP3aCV4As6Er1LRzYz6uP5UO8mHgBtKVJz6NzOw=";
        private static string IVValue = "6Fh9nWTv7q7K7hU3e2PG9g==";

        private static readonly byte[] Key = Convert.FromBase64String(KeyValue);
        private static readonly byte[] IV = Convert.FromBase64String(IVValue);


        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static string EncryptPW(string plainText)
        {
            using var aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;

            using var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            using (var sw = new StreamWriter(cs))
            {
                sw.Write(plainText);
            }

            var encryptedBytes = ms.ToArray();
            return Convert.ToBase64String(encryptedBytes);
        }


        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static string DecryptPW(string encryptedBase64)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(encryptedBase64))
                    return "[Invalid input: empty or null]";

                byte[] cipherBytes;
                try
                {
                    cipherBytes = Convert.FromBase64String(encryptedBase64);
                }
                catch
                {
                    return "[Invalid Base64 string]";
                }

                using var aes = Aes.Create();
                aes.Key = Key;   // Must be 16/24/32 bytes
                aes.IV = IV;     // Must be 16 bytes
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using var ms = new MemoryStream(cipherBytes);
                using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
                using var sr = new StreamReader(cs);
                return sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                return $"[Decryption failed: {ex.Message}]";
            }
        }

    }
}
