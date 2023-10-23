using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.ChildForms;
using TestTask.Core.Components;
using TestTask.Core.Extension;
using TestTask.Core.Service;
using TestTask.Core.Service.Components;

namespace TestTask
{
    public partial class LoginForm : MaterialForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserService _userService;
        private readonly ModeService _modeService;
        private readonly StepService _stepService;
        private readonly IMessageBox _messageBox;

        public LoginForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetRequiredService<UserService>();
            _modeService = _serviceProvider.GetRequiredService<ModeService>();
            _stepService = _serviceProvider.GetRequiredService<StepService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
        }

        private void BtnSignUpNow_Click(object sender, EventArgs e)
        {
            Hide();

            using (var registrForm = new RegistrationForm(_serviceProvider))
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

            using (var tableForm = new TableForm(_serviceProvider))
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
