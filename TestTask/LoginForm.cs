using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.ChildForms;
using TestTask.Core.Components;
using TestTask.Core.Extension;
using TestTask.Core.Service;

namespace TestTask
{
    public partial class LoginForm : MaterialForm
    {
        private readonly UserService _userService;

        public LoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void BtnSignUpNow_Click(object sender, EventArgs e)
        {
            var registrForm = new RegistrationForm(_userService);

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
                MessageBox.Show(message, "Information", MessageBoxButtons.OK);
                return;
            }

            Hide();
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
    }
}
