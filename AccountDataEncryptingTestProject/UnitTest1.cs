namespace AccountDataEncryptingTestProject
{
    public class AccountDataEncryptingTests
    {
        private MD5Encryptor _md5Encryptor;
        private AccountDataBase _accountDataBase;
        private string _xmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "test.xml");

        [SetUp]
        public void Setup()
        {
            _md5Encryptor = new MD5Encryptor();
            _accountDataBase = new AccountsXmlDataBase(_xmlFilePath, _md5Encryptor);
        }

        [Test]
        public void EncryptorTest()
        {
            string text = "abc";

            string actual = _md5Encryptor.Encrypt(text);
            string expected = "900150983CD24FB0D6963F7D28E17F72";

            Assert.That(actual, Is.EqualTo(expected), "Неверно работает алгоритм шифрования!");
        }

        [Test]
        public void AccountLoginAndRegistrationTest()
        {
            Account testAccount = new Account("test", "Test123!");

            AccountDataBaseResult result1 = _accountDataBase.SendSetRequest(testAccount);

            Assert.IsTrue(result1.IsSuccess);

            AccountDataBaseResult result2 = _accountDataBase.SendSetRequest(testAccount);

            Assert.IsTrue(!result2.IsSuccess);
            Assert.IsNotNull(result2.Error);

            Account testAccount2 = new Account("test2", "test");

            Assert.IsTrue(!result2.IsSuccess);
            Assert.IsNotNull(result2.ValidationResults);

            AccountDataBaseResult result3 = _accountDataBase.SendGetRequest(testAccount);

            Assert.IsTrue(result3.IsSuccess);
        }
    }
}