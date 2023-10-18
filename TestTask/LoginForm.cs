using MaterialSkin.Controls;
using TestTask.ChildForms;

namespace TestTask
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnSignUpNow_Click(object sender, System.EventArgs e)
        {
            var registrForm = new RegistrationForm();

            Hide();

            if (registrForm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                Show();
            }
        }
    }
}
