using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using TestTask.ChildForms;

namespace TestTask
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnSignUpNow_Click(object sender, EventArgs e)
        {
            var registrForm = new RegistrationForm();

            Hide();

            if (registrForm.ShowDialog() == DialogResult.Cancel)
            {
                Show();
            }
        }
    }
}
