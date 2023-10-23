using System;
using System.Windows.Forms;
using TestTask.Core.Components;

namespace TestTask.ChildForms.ModeForm
{
    public class EditItemModeForm : ModeFormBase
    {
        private readonly Mode _oldMode;

        private Mode _editMode;
        private bool _сhangedName = false;

        public EditItemModeForm(IServiceProvider serviceProvider, Mode mode)
            : base(serviceProvider)
        {
            Text = "Edit Mode";
            _oldMode = mode;
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            if (tbNameMode.Text == string.Empty)
            {
                _messageBox.ShowWarning("Fill in the field Name");
                return;
            }

            _editMode = GetModeModel().ToMode(_oldMode.Id);
            if (_oldMode.Equals(_editMode))
            {
                _messageBox.ShowInfo("The mode has not been modified.");
                DialogResult = DialogResult.Cancel;
            }

            _сhangedName = _editMode.Name != _oldMode.Name;
            DialogResult = DialogResult.OK;
        }

        protected override void DefaultValue()
        {
            tbNameMode.Text = _oldMode.Name;
            tbMaxUsedTips.Text = _oldMode.MaxUsedTips.ToString();
            tbMaxBottle.Text = _oldMode.MaxBottleNumber.ToString();
        }

        public Mode GetEditMode() => _editMode;

        public bool ChangedModeName() => _сhangedName;
    }
}
