using System.ComponentModel.DataAnnotations;

namespace AccountForms.DataModel
{
    public class Account 
    {
        public Account(string login, string password)
        {
            Login = login;
            _password = password;
        }
        // Формат шаблона - пароль от 8 символов с заглавными буквами, цифрами и спец. символами
        // Пример - Qwerty123!
        private const string PASSWORD_PATTERN = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        private string _password;

        [Required]
        public string Login { get; private set; }

        [RegularExpression(PASSWORD_PATTERN, ErrorMessage = "Пароль слишком лёгкий")]
        public string Password => _password;

        public IEnumerable<ValidationResult> ValidateAccountData(ValidationContext context)
        {
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(this, context, validationResults, true);

            return validationResults;
        }
    }
}
