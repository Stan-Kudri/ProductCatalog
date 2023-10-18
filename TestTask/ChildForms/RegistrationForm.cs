using MaterialSkin.Controls;

namespace TestTask.ChildForms
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
            => DialogResult = System.Windows.Forms.DialogResult.Cancel;
    }
}
