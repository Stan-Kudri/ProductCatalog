using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.Core.Components;
using TestTask.Core.Extension;
using TestTask.Core.Service;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms
{
    public partial class RegistrationForm : MaterialForm
    {
        private readonly UserService _userService;
        private readonly IMessageBox _messageBox;

        public RegistrationForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = serviceProvider.GetRequiredService<UserService>();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
            => DialogResult = DialogResult.Cancel;

        private void BtnSignUpNow_Click(object sender, System.EventArgs e)
        {
            if (!ValidateData(out var message, out var user))
            {
                _messageBox.ShowInfo(message);
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

            if (!username.ValidFormatUsername(out string messageValidUsername))
            {
                message = messageValidUsername;
                return false;
            }

            if (!password.ValidFormatPassword(out string messageValidPassword))
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
