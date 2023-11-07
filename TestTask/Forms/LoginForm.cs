using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.Core;
using TestTask.Core.Models.Users;

namespace TestTask.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserService _userService;
        private readonly IMessageBox _messageBox;

        public LoginForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = serviceProvider.GetRequiredService<UserService>();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
            tbLogIn.Text = "Sergey";
            tbPassword.Text = "qwe123";
        }

        private void BtnSignUpNow_Click(object sender, EventArgs e)
        {
            Hide();

            using (var registrForm = _serviceProvider.GetRequiredService<RegistrationForm>())
            {
                if (registrForm.ShowDialog() == DialogResult.Cancel)
                {
                    ClearEnteredData();
                    Show();
                }
            }
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateData(out var message, out var user))
            {
                _messageBox.ShowInfo(message);
                return;
            }

            Hide();

            using (var tableForm = _serviceProvider.GetRequiredService<MainForm>())
            {
                if (tableForm.ShowDialog() == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private bool ValidateData(out string message, out User user)
        {
            user = null;
            var username = tbLogIn.Text;
            var password = tbPassword.Text;

            var userValidator = _serviceProvider.GetRequiredService<UserValidator>();
            if (!userValidator.ValidFormatUsername(username, out string messageValidUsername))
            {
                message = messageValidUsername;
                return false;
            }

            if (!userValidator.ValidFormatPassword(password, out string messageValidPassword))
            {
                message = messageValidPassword;
                return false;
            }

            if (_userService.IsFreeUsername(username))
            {
                message = "This user does not exist.";
                return false;
            }

            user = new UserModel(username, password).ToUser();

            if (_userService.IsUserData(user))
            {
                message = "Invalid username or password.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        private void ClearEnteredData() => tbLogIn.Text = tbPassword.Text = string.Empty;
    }
}
