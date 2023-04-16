namespace AccountForms.DataModel
{
    public interface IEncryptor
    {
        public string Encrypt(string text);
        public string Decrypt(string enryptedText);
    }
}
