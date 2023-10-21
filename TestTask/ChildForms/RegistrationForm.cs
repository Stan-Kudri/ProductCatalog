using MaterialSkin.Controls;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.Core.Components;
using TestTask.Core.Extension;
using TestTask.Core.Service;

namespace TestTask.ChildForms
{
    public partial class RegistrationForm : MaterialForm
    {
        private readonly UserService _userService;

        public RegistrationForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
            => DialogResult = DialogResult.Cancel;

        private void BtnSignUpNow_Click(object sender, System.EventArgs e)
        {
            if (!ValidateData(out var message, out var user))
            {
                MessageBox.Show(message, "Information", MessageBoxButtons.OK);
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
