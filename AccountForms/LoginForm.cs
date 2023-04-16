// Open sourсe проект по Научной Практической Конференции 
// По предмету информатика на тему "Шифрование. Как хранятся пароли в Базе данных"

using AccountForms.DataModel;

namespace AccountForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Load += LoginFormLoad;
        }

        #region Constants
        private int indexOfLoginTabPage = 0;
        private int indexOfRegistrationTabPage = 1;
        private string programDirectoryName = "НПК Информатика";
        private string xmlFileName = "Accounts Data Base.xml";
        #endregion

        private AccountDataBase accountsDataBase;
        private string programDirectoryPath => Path.Combine(appDataPath, programDirectoryName);
        private string appDataPath => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private void LoginFormLoad(object? sender, EventArgs e)
        {
            CreateProgramDirectoryIfNotExist();
            accountsDataBase = new AccountsXmlDataBase(Path.Combine(programDirectoryPath, xmlFileName), new MD5Encryptor());
        }

        private void RegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logIn_tabControl.SelectTab(indexOfRegistrationTabPage);
        }

        private void HideOrShow_button_Click(object sender, EventArgs e)
        {
            password_textBox.UseSystemPasswordChar =
                password_textBox.UseSystemPasswordChar == true ? false : true;
        }

        private void OnLogIn_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logIn_tabControl.SelectTab(indexOfLoginTabPage);
        }

        private void CreateProgramDirectoryIfNotExist()
        {
            if (Directory.Exists(programDirectoryPath))
            {
                return;
            }
            else
            {
                CreateProgramDirectory();
            }
        }

        private void CreateProgramDirectory()
        {
            Directory.CreateDirectory(programDirectoryPath);
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            string login = login_textBox.Text;
            string password = password_textBox.Text;

            Account account = new Account(login, password);

            LogInAccount(account);
        }

        private void LogInAccount(Account account)
        {
            AccountDataBaseResult response = accountsDataBase.SendGetRequest(account);

            response.DisplayErrors();

            if (response.IsSuccess)
            {
                MessageBox.Show("Успех!");
                LoadCabinetForm(account.Login);
            }
        }

        private void LoadCabinetForm(string login)
        {
            CabinetForm form = new CabinetForm();
            form.SetLogin(login);
            form.FormClosed += CabinetForm_FormClosed;
            Hide();
            form.Show();
        }

        private void CabinetForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            string login = newLogin_textBox.Text;
            string password = newPassword_textBox.Text;
            string repartedPassword = repartPassword_textBox.Text;

            if (repartedPassword == password)
            {
                Account account = new Account(login, password);

                AccountDataBaseResult response = accountsDataBase.SendSetRequest(account);

                response.DisplayErrors();

                if (response.IsSuccess)
                {
                    MessageBox.Show("Аккаунт успешнго зарегестрирован!");
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }

        private void ClearTextBoxes()
        {
            newLogin_textBox.Clear();
            newPassword_textBox.Clear();
            repartPassword_textBox.Clear();
        }
    }
}