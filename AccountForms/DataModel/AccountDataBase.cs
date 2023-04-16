namespace AccountForms.DataModel
{
    public abstract class AccountDataBase
    {
        public AccountDataBase(IEncryptor passwordEncryptor)
        {
            PasswordEncryptor = passwordEncryptor;
        }

        protected IEncryptor PasswordEncryptor;

        public abstract AccountDataBaseResult SendGetRequest(Account account);
        public abstract AccountDataBaseResult SendSetRequest(Account account);
    }
}
