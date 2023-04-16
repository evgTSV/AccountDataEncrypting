using System.Security.Cryptography;
using System.Text;

namespace AccountForms.DataModel
{
    public class MD5Encryptor : IEncryptor
    {
        // TODO: Добавить дескриптор при переходе к релизной модели
        public string Decrypt(string enryptedText)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            byte[] hash = md5.ComputeHash(buffer);

            StringBuilder passwordBuilder = new StringBuilder();

            foreach (byte b in hash)
            {
                passwordBuilder.Append(b.ToString("X2"));
            }

            return passwordBuilder.ToString();
        }
    }
}
