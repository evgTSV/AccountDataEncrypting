namespace AccountForms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            logIn_tabControl = new TabControl();
            logIn_tabPage = new TabPage();
            registrationLinkLabel = new LinkLabel();
            LogIn_button = new Button();
            HideOrShow_button = new Button();
            password_textBox = new TextBox();
            label2 = new Label();
            login_textBox = new TextBox();
            label1 = new Label();
            registration_tabPage = new TabPage();
            repartPassword_textBox = new TextBox();
            label5 = new Label();
            onLogIn_linkLabel = new LinkLabel();
            registration_button = new Button();
            newPassword_textBox = new TextBox();
            label3 = new Label();
            newLogin_textBox = new TextBox();
            label4 = new Label();
            logIn_tabControl.SuspendLayout();
            logIn_tabPage.SuspendLayout();
            registration_tabPage.SuspendLayout();
            SuspendLayout();
            // 
            // logIn_tabControl
            // 
            logIn_tabControl.Controls.Add(logIn_tabPage);
            logIn_tabControl.Controls.Add(registration_tabPage);
            logIn_tabControl.Location = new Point(12, 12);
            logIn_tabControl.Name = "logIn_tabControl";
            logIn_tabControl.SelectedIndex = 0;
            logIn_tabControl.Size = new Size(402, 547);
            logIn_tabControl.TabIndex = 0;
            // 
            // logIn_tabPage
            // 
            logIn_tabPage.BackColor = Color.FromArgb(124, 172, 201);
            logIn_tabPage.Controls.Add(registrationLinkLabel);
            logIn_tabPage.Controls.Add(LogIn_button);
            logIn_tabPage.Controls.Add(HideOrShow_button);
            logIn_tabPage.Controls.Add(password_textBox);
            logIn_tabPage.Controls.Add(label2);
            logIn_tabPage.Controls.Add(login_textBox);
            logIn_tabPage.Controls.Add(label1);
            logIn_tabPage.ForeColor = SystemColors.ButtonHighlight;
            logIn_tabPage.Location = new Point(4, 24);
            logIn_tabPage.Name = "logIn_tabPage";
            logIn_tabPage.Padding = new Padding(3);
            logIn_tabPage.Size = new Size(394, 519);
            logIn_tabPage.TabIndex = 0;
            logIn_tabPage.Text = "Вход";
            // 
            // registrationLinkLabel
            // 
            registrationLinkLabel.AutoSize = true;
            registrationLinkLabel.LinkVisited = true;
            registrationLinkLabel.Location = new Point(101, 458);
            registrationLinkLabel.Name = "registrationLinkLabel";
            registrationLinkLabel.Size = new Size(198, 15);
            registrationLinkLabel.TabIndex = 6;
            registrationLinkLabel.TabStop = true;
            registrationLinkLabel.Text = "Нет аккаунта? Зарегистрироваться";
            registrationLinkLabel.LinkClicked += RegistrationLinkLabel_LinkClicked;
            // 
            // LogIn_button
            // 
            LogIn_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LogIn_button.ForeColor = SystemColors.ActiveCaptionText;
            LogIn_button.Location = new Point(39, 380);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Size = new Size(317, 62);
            LogIn_button.TabIndex = 5;
            LogIn_button.Text = "Войти";
            LogIn_button.UseVisualStyleBackColor = true;
            LogIn_button.Click += LogIn_button_Click;
            // 
            // HideOrShow_button
            // 
            HideOrShow_button.ForeColor = SystemColors.ActiveCaptionText;
            HideOrShow_button.Location = new Point(320, 284);
            HideOrShow_button.Name = "HideOrShow_button";
            HideOrShow_button.Size = new Size(36, 35);
            HideOrShow_button.TabIndex = 4;
            HideOrShow_button.Text = "👀";
            HideOrShow_button.UseVisualStyleBackColor = true;
            HideOrShow_button.Click += HideOrShow_button_Click;
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            password_textBox.Location = new Point(39, 284);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(275, 35);
            password_textBox.TabIndex = 3;
            password_textBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(101, 196);
            label2.Name = "label2";
            label2.Size = new Size(195, 63);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // login_textBox
            // 
            login_textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            login_textBox.Location = new Point(40, 113);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(316, 35);
            login_textBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(118, 29);
            label1.Name = "label1";
            label1.Size = new Size(167, 63);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // registration_tabPage
            // 
            registration_tabPage.BackColor = Color.FromArgb(192, 251, 189);
            registration_tabPage.Controls.Add(repartPassword_textBox);
            registration_tabPage.Controls.Add(label5);
            registration_tabPage.Controls.Add(onLogIn_linkLabel);
            registration_tabPage.Controls.Add(registration_button);
            registration_tabPage.Controls.Add(newPassword_textBox);
            registration_tabPage.Controls.Add(label3);
            registration_tabPage.Controls.Add(newLogin_textBox);
            registration_tabPage.Controls.Add(label4);
            registration_tabPage.ForeColor = SystemColors.ActiveCaptionText;
            registration_tabPage.Location = new Point(4, 24);
            registration_tabPage.Name = "registration_tabPage";
            registration_tabPage.Padding = new Padding(3);
            registration_tabPage.Size = new Size(394, 519);
            registration_tabPage.TabIndex = 1;
            registration_tabPage.Text = "Регистрация";
            // 
            // repartPassword_textBox
            // 
            repartPassword_textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            repartPassword_textBox.Location = new Point(39, 341);
            repartPassword_textBox.Name = "repartPassword_textBox";
            repartPassword_textBox.Size = new Size(317, 35);
            repartPassword_textBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(6, 275);
            label5.Name = "label5";
            label5.Size = new Size(374, 49);
            label5.TabIndex = 14;
            label5.Text = "Повторить пароль";
            // 
            // onLogIn_linkLabel
            // 
            onLogIn_linkLabel.AutoSize = true;
            onLogIn_linkLabel.LinkVisited = true;
            onLogIn_linkLabel.Location = new Point(128, 469);
            onLogIn_linkLabel.Name = "onLogIn_linkLabel";
            onLogIn_linkLabel.Size = new Size(116, 15);
            onLogIn_linkLabel.TabIndex = 13;
            onLogIn_linkLabel.TabStop = true;
            onLogIn_linkLabel.Text = "Есть аккаунт? Войти";
            onLogIn_linkLabel.LinkClicked += OnLogIn_linkLabel_LinkClicked;
            // 
            // registration_button
            // 
            registration_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            registration_button.ForeColor = SystemColors.ActiveCaptionText;
            registration_button.Location = new Point(39, 388);
            registration_button.Name = "registration_button";
            registration_button.Size = new Size(317, 62);
            registration_button.TabIndex = 12;
            registration_button.Text = "Зарегистрироваться";
            registration_button.UseVisualStyleBackColor = true;
            registration_button.Click += Registration_button_Click;
            // 
            // newPassword_textBox
            // 
            newPassword_textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            newPassword_textBox.Location = new Point(39, 237);
            newPassword_textBox.Name = "newPassword_textBox";
            newPassword_textBox.ShortcutsEnabled = false;
            newPassword_textBox.Size = new Size(317, 35);
            newPassword_textBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(102, 171);
            label3.Name = "label3";
            label3.Size = new Size(195, 63);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // newLogin_textBox
            // 
            newLogin_textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            newLogin_textBox.Location = new Point(40, 121);
            newLogin_textBox.Name = "newLogin_textBox";
            newLogin_textBox.Size = new Size(316, 35);
            newLogin_textBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(118, 37);
            label4.Name = "label4";
            label4.Size = new Size(167, 63);
            label4.TabIndex = 7;
            label4.Text = "Логин";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(426, 571);
            Controls.Add(logIn_tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Log In";
            logIn_tabControl.ResumeLayout(false);
            logIn_tabPage.ResumeLayout(false);
            logIn_tabPage.PerformLayout();
            registration_tabPage.ResumeLayout(false);
            registration_tabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl logIn_tabControl;
        private TabPage logIn_tabPage;
        private TabPage registration_tabPage;
        private LinkLabel registrationLinkLabel;
        private Button LogIn_button;
        private Button HideOrShow_button;
        private TextBox password_textBox;
        private Label label2;
        private TextBox login_textBox;
        private Label label1;
        private LinkLabel onLogIn_linkLabel;
        private Button registration_button;
        private TextBox newPassword_textBox;
        private Label label3;
        private TextBox newLogin_textBox;
        private Label label4;
        private TextBox repartPassword_textBox;
        private Label label5;
    }
}