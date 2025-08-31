using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Core;
using ProductCatalog.Core.Models.Users;
using ProductCatalog.WinForms.BindingItem;

namespace ProductCatalog.WinForms.Forms
{
    public partial class RegistrationForm : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserService _userService;
        private readonly IMessageBox _messageBox;

        public RegistrationForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetRequiredService<UserService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
            => DialogResult = DialogResult.Cancel;

        private async void BtnSignUpNow_Click(object sender, EventArgs e)
        {
            if (!ValidateData(out var message, out var user))
            {
                await _messageBox.ShowInfo(message);
                return;
            }

            if (!_userService.IsFreeUsername(user.Username))
            {
                message = "Username is taken.";
                await _messageBox.ShowInfo(message);
                return;
            }

            Hide();

            await _userService.AddAsync(user.Username, user.Password);
            DialogResult = DialogResult.OK;

            Close();
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

            message = string.Empty;
            userModel = new UserModel(username, password);
            return true;
        }
    }
}
