using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.BindingItem.UserBinding;
using TestTask.BindingItem.UserBinding.StepBinding;
using TestTask.Core.Components;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.StepForm
{
    public partial class StepFormBase : Form
    {
        protected readonly IMessageBox _messageBox;
        protected readonly SelectMode _modes;

        private StepFormBase()
        {
            InitializeComponent();
        }

        public StepFormBase(IMessageBox messageBox, List<Mode> modes)
        {
            InitializeComponent();
            _messageBox = messageBox;
            _modes = new SelectMode(modes);
        }

        protected Mode SelectedMode =>
            cmbModeValue.SelectedValue != null ? (Mode)cmbModeValue.SelectedValue : throw new Exception("Wrong combo box format");

        protected virtual void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                _messageBox.ShowInfo(message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, EventArgs e) => SetDefaultValueData();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected virtual void AddStepForm_Load(object sender, EventArgs e)
        {
            selectModeBindingSource.DataSource = _modes.Items;
            SetDefaultValueData();
        }

        private void TbTimer_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        private void TbSpeed_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        private void TbVolume_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        private void KeyPressDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        protected virtual void SetDefaultValueData()
        {
            cmbModeValue.SelectedItem = _modes.Mode;
            tbTimer.Text = "0";
            tbDestination.Text = string.Empty;
            tbSpeed.Text = "0";
            tbType.Text = string.Empty;
            tbVolume.Text = "0";
        }

        protected bool IsDataFilled(out string message)
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

        public StepModel GetStepModel()
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
