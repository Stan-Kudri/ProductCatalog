using System;
using System.Windows.Forms;
using TestTask.BindingItem.UserBinding;
using TestTask.BindingItem.UserBinding.StepBinding;
using TestTask.Core.Components;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.StepForm
{
    public partial class AddStepForm : Form
    {
        private readonly IMessageBox _messageBox;
        private readonly SelectMode _modes;

        public AddStepForm(IMessageBox messageBox, SelectMode modes)
        {
            InitializeComponent();
            _messageBox = messageBox;
            _modes = modes;
        }

        protected Mode SelectedMode =>
            cmbModeValue.SelectedValue != null ? (Mode)cmbModeValue.SelectedValue : throw new Exception("Wrong combo box format");

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                _messageBox.ShowInfo(message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, EventArgs e) => SetDefoultValueData();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddStepForm_Load(object sender, EventArgs e)
        {
            selectModeBindingSource.DataSource = _modes.Items;
        }

        private void TbTimer_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        private void TbSpeed_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        private void TbVolume_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        private void KeyPressDigit(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void SetDefoultValueData()
        {
            cmbModeValue.SelectedItem = _modes.Mode;
            tbTimer.Text = "0";
            tbDestination.Text = string.Empty;
            tbSpeed.Text = "0";
            tbType.Text = string.Empty;
            tbVolume.Text = "0";
        }

        private bool IsDataFilled(out string message)
        {
            if (cmbModeValue.Text.Length <= 0)
            {
                message = "Select your mode.";
                return false;
            }

            if (tbType.Text.Length == decimal.Zero)
            {
                message = "Please enter a Type.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        public StepModel GetModeModel()
        {
            if (!int.TryParse(tbTimer.Text, out var timer))
            {
                throw new Exception("The Timer field is filled in incorrectly.");
            }

            if (!int.TryParse(tbSpeed.Text, out var speed))
            {
                throw new Exception("The Speed field is filled in incorrectly.");
            }

            if (tbType.Text == string.Empty)
            {
                throw new Exception("The Type field is filled in incorrectly.");
            }

            if (!int.TryParse(tbVolume.Text, out var volume))
            {
                throw new Exception("The Volume field is filled in incorrectly.");
            }

            return new StepModel(SelectedMode, timer, tbDestination.Text, speed, tbType.Text, volume);
        }
    }
}
