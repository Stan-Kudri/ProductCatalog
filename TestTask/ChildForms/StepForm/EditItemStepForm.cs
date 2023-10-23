using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.Core.Components;
using TestTask.Core.Components.ItemsTables;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.StepForm
{
    public class EditItemStepForm : StepFormBase
    {
        private readonly Step _oldStep;

        private Step _editStep;

        public EditItemStepForm(IMessageBox messageBox, List<Mode> modes, Step oldStep)
            : base(messageBox, modes)
        {
            Text = "Edit Step";
            _oldStep = oldStep;
        }

        protected override void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                _messageBox.ShowInfo(message);
                return;
            }

            _editStep = GetStepModel().ToStep(_oldStep.Id);
            if (_oldStep.Equals(_editStep))
            {
                _messageBox.ShowInfo("The step has not been modified.");
                DialogResult = DialogResult.Cancel;
            }

            DialogResult = DialogResult.OK;
        }

        protected override void AddStepForm_Load(object sender, EventArgs e)
        {
            selectModeBindingSource.DataSource = _modes.Items;
            _modes.SetValueMode(_oldStep.ModeId);
            SetDefaultValueData();
        }

        protected override void SetDefaultValueData()
        {
            cmbModeValue.SelectedItem = _modes.Mode;
            tbTimer.Text = _oldStep.Timer.ToString();
            tbDestination.Text = _oldStep.Destination.ToString();
            tbSpeed.Text = _oldStep.Speed.ToString();
            tbType.Text = _oldStep.Type;
            tbVolume.Text = _oldStep.Volume.ToString();
        }

        public Step GetEditStep() => _editStep;
    }
}
