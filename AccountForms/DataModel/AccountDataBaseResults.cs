using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AccountForms.DataModel
{
    public class AccountDataBaseResult
    {
        public AccountDataBaseResult(bool isSuccess = true)
        {
            IsSuccess = isSuccess;
        }

        public AccountDataBaseResult(Exception error)
        {
            _error = error;
        }

        public AccountDataBaseResult(Exception error, List<ValidationResult> validationResults)
            : this(error)
        {
            _validationResults = validationResults;
        }

        private Exception? _error;
        private List<ValidationResult>? _validationResults = new List<ValidationResult>();

        public bool IsSuccess { get; }

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBox(IntPtr h, string m, string c, int type);

        public Exception? Error => _error;
        public IEnumerable<ValidationResult>? ValidationResults => _validationResults;

        public void DisplayErrors()
        {
            if (!IsSuccess && OperatingSystem.IsWindows())
            {
                DisplayException();
                DisplayValidationErrors();
            }
        }
        private void DisplayException()
        {
            if (_error != null)
                MessageBox(0, _error.Message ?? "null", "Ошибка!", 0);
        }
        private void DisplayValidationErrors()
        {
            if (_validationResults != null)
            {
                foreach (ValidationResult error in _validationResults)
                {
                    MessageBox(0, error.ErrorMessage ?? "null", "Ошибка валидации!", 0);
                }
            }
        }
    }
}
