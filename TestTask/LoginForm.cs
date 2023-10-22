using MaterialSkin.Controls;
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
        private readonly UserService _userService;
        private readonly ModeService _modeService;
        private readonly StepService _stepService;
        private readonly IMessageBox _messageBox;

        public LoginForm(UserService userService, ModeService modeService, StepService stepService, IMessageBox messageBox)
        {
            InitializeComponent();
            _userService = userService;
            _modeService = modeService;
            _stepService = stepService;
            _messageBox = messageBox;
        }

        private void BtnSignUpNow_Click(object sender, EventArgs e)
        {
            var registrForm = new RegistrationForm(_userService, _messageBox);

            Hide();

            if (registrForm.ShowDialog() == DialogResult.Cancel)
            {
                Show();
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

            var tableForm = new TableForm(_modeService, _stepService, _messageBox);
            if (tableForm.ShowDialog() == DialogResult.Cancel)
            {
                _messageBox.ShowInfo("Account logout completed successfully.");
                ClearEnteredData();
                Show();
                return;
            }

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
