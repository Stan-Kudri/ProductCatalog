using System;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.Core;
using TestTask.Core.Models.Modes;
using TestTask.Core.Models.Steeps;
using TestTask.Core.Models.Users;

namespace TestTask.Forms
{
    public partial class LoginForm : BaseForm
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
            tbLogIn.Text = "Sergey";
            tbPassword.Text = "qwe123";
        }

        private void BtnSignUpNow_Click(object sender, EventArgs e)
        {
            Hide();

            using (var registrForm = new RegistrationForm(_userService, _messageBox))
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

            using (var tableForm = new TableForm(_modeService, _stepService, _messageBox))
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

            var userValidator = new UserValidator();
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
