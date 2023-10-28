using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.Core;
using TestTask.Core.Models.Users;

namespace TestTask.Forms
{
    public partial class RegistrationForm : BaseForm
    {
        private readonly UserService _userService;
        private readonly IMessageBox _messageBox;

        public RegistrationForm(UserService userService, IMessageBox messageBox)
        {
            InitializeComponent();
            _userService = userService;
            _messageBox = messageBox;
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
