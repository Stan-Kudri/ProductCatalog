using System;
using System.Windows.Forms;
using TestTask.Core.Components;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.ModeForm
{
    public class EditItemModeForm : ModeForm
    {
        private readonly Mode _mode;

        private Mode _editMode;

        public EditItemModeForm(IMessageBox messageBox, Mode mode)
            : base(messageBox)
        {
            Text = "Edit Mode";
            _mode = mode;
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            if (tbNameMode.Text == string.Empty)
            {
                _messageBox.ShowWarning("Fill in the field Name");
                return;
            }

            _editMode = GetModeModel().ToMode(_mode.Id);
            if (_mode.Equals(_editMode))
            {
                _messageBox.ShowInfo("The mode has not been modified.");
                DialogResult = DialogResult.Cancel;
            }

            DialogResult = DialogResult.OK;
        }

        protected override void DefaultValue()
        {
            tbNameMode.Text = _mode.Name;
            tbMaxUsedTips.Text = _mode.MaxUsedTips.ToString();
            tbMaxBottle.Text = _mode.MaxBottleNumber.ToString();
        }

        public Mode GetEditMode() => _editMode;
    }
}
