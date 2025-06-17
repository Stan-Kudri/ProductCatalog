using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TestTask.BindingItem;
using TestTask.Core;
using TestTask.Core.Models.Users;

namespace TestTask.Forms
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

        private async void BtnSignUpNow_Click(object sender, System.EventArgs e)
        {
            if (!ValidateData(out var message, out var user))
            {
                await _messageBox.ShowInfo(message);
                return;
            }

            Hide();

            _userService.Add(user);
            DialogResult = DialogResult.OK;

            Close();
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

            if (!_userService.IsFreeUsername(username))
            {
                message = "Username is taken.";
                return false;
            }

            message = string.Empty;
            user = new UserModel(username, password).ToUser();
            return true;
        }
    }
}
