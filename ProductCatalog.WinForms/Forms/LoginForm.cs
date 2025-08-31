using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Core;
using ProductCatalog.Core.Models.Users;
using ProductCatalog.WinForms.BindingItem;

namespace ProductCatalog.WinForms.Forms
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

        private async void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateData(out var message, out var user))
            {
                await _messageBox.ShowInfo(message);
                return;
            }

            if (!await _userService.IsDataVerifyUser(user.Username, user.Password))
            {
                message = "Invalid username or password.";
                await _messageBox.ShowInfo(message);
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

        private bool ValidateData(out string message, out UserModel userModel)
        {
            userModel = null;
            var username = tbLogIn.Text;
            var password = tbPassword.Text;

            var userValidator = _serviceProvider.GetRequiredService<IUserValidator>();
            if (!userValidator.ValidateUsername(username, out string messageValidUsername))
            {
                message = messageValidUsername;
                return false;
            }

            if (!userValidator.ValidatePassword(password, out string messageValidPassword))
            {
                message = messageValidPassword;
                return false;
            }

            userModel = new UserModel(username, password);
            message = string.Empty;
            return true;
        }

        private void ClearEnteredData() => tbLogIn.Text = tbPassword.Text = string.Empty;
    }
}
