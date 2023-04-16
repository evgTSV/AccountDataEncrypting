using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace AccountForms.DataModel
{
    public sealed class AccountsXmlDataBase : [AccountDataBase](https://github.com/Evgeny608799/AccountDataEncrypting/blob/master/AccountForms/DataModel/AccountDataBase.cs)
    {
        public AccountsXmlDataBase(string xmlFilePath, IEncryptor passwordEncryptor)
            : base (passwordEncryptor)
        {
            _xmlFilePath = xmlFilePath;
            InitializeXmlDocument();
        }

        #region Xml Elements Names
        private string _rootName = "accounts";
        private string _accountName = "account";
        private string _passwordName = "password";
        #endregion

        private string _loginAttributeName = "login";

        private string _xmlFilePath;
        private XmlDocument? _xmlDocument;

        public string XmlFilePath => Path.GetFullPath(_xmlFilePath);

        private void InitializeXmlDocument()
        {
            try
            {
                _xmlDocument = XmlDocument.CreateXmlDocument(_xmlFilePath, _rootName);
            }
            catch (IOException)
            {
                // Если xml документ уже существует вызвать метод XmlDocument.LoadDocument(string filePath)
                // для загрузки уже созданного документа.
                _xmlDocument = XmlDocument.LoadXmlDocument(_xmlFilePath);
            }
        }

        public override AccountDataBaseResult SendGetRequest(Account account)
        {
            try
            {
                XElement accountNode = FindAccountByLogin(account.Login);
                bool isVerify = EncryptAndChekAccountPassword(accountNode, account.Password);
                ThrowIfPasswordNotVerify(isVerify);

                return new AccountDataBaseResult(isSuccess: true);
            }
            catch (Exception ex)
            {
                return new AccountDataBaseResult(ex);
            }
        }

        private XElement FindAccountByLogin(string login)
        {
            XElement? account = null;

            var accounts = _xmlDocument?.RootElements?.Where((element) => element?.Name == _accountName).Select((e) => e);

            if (accounts != null)
            {
                foreach (XElement? a in accounts)
                {
                    if (a?.Attribute("login")?.Value == login)
                    {
                        account = a;
                        break;
                    }
                }
            }

            if (account == null)
            {
                throw new NullReferenceException("Аккаунт не найден!");
            }
            
            return account;
        }

        private bool EncryptAndChekAccountPassword(XElement accountNode, string password)
        {
            string encryptedPassword = PasswordEncryptor.Encrypt(password);

            bool result = ChekPassword(accountNode, encryptedPassword);

            return result;
        }

        private bool ChekPassword(XElement accountNode, string password)
        {
            XElement? passwordNode = accountNode.Element(_passwordName);

            if (passwordNode == null)
            {
                throw new NullReferenceException("Xml фаил повреждён!");
            }

            return passwordNode.Value == password;
        }

        private void ThrowIfPasswordNotVerify(bool isVerify)
        {
            if (!isVerify)
            {
                throw new InvalidOperationException("Неверный логин/пароль");
            }
        }

        public override AccountDataBaseResult SendSetRequest(Account account)
        {
            List<ValidationResult> validationResults = new List<ValidationResult>();
            try
            {
                if (!ValidateAccount(account, validationResults))
                {
                    throw new ValidationException("Введены неправильные данные!");
                }

                AddAccountToDataBase(account);

                return new AccountDataBaseResult(isSuccess: true);
            }
            catch (Exception ex)
            {
                return new AccountDataBaseResult(ex, validationResults);
            }
        }

        private bool ValidateAccount(Account account, List<ValidationResult> validationResults)
        {
            validationResults.AddRange(account.ValidateAccountData(new ValidationContext(account)));

            if (validationResults.Count > 0 || !ChekUniquenessOfLogin(account.Login))
            {
                return false;
            }

            return true;
        }

        private bool ChekUniquenessOfLogin(string login)
        {
            try
            {
                FindAccountByLogin(login);
                return false;
            }
            catch (NullReferenceException)
            {
                return true;
            }
        }

        private void AddAccountToDataBase(Account account)
        {
            XElement accountElement = CreateAccountElement(account);
            _xmlDocument?.AddElementToRoot(accountElement);
        }

        private XElement CreateAccountElement(Account account)
        {
            XElement accountElement = new XElement(_accountName);

            XAttribute loginAttribute = new XAttribute(_loginAttributeName, account.Login);

            string encryptedPassword = PasswordEncryptor.Encrypt(account.Password);
            XElement passwordElement = new XElement(_passwordName, encryptedPassword);

            accountElement.Add(loginAttribute);
            accountElement.Add(passwordElement);
            
            return accountElement;
        }
    }
}
