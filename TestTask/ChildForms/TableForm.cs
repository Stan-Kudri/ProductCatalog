using System;
using System.Windows.Forms;
using TestTask.BindingItem.UserBinding.StepBinding;
using TestTask.ChildForms.ModeForm;
using TestTask.ChildForms.StepForm;
using TestTask.Core.Service;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms
{
    public partial class TableForm : Form
    {
        private readonly ModeService _modeService;
        private readonly StepService _stepService;
        private readonly IMessageBox _messageBox;

        private SelectMode _selectMode;

        public TableForm(ModeService modeService, StepService stepService, IMessageBox messageBox)
        {
            InitializeComponent();
            _modeService = modeService;
            _stepService = stepService;
            _messageBox = messageBox;
        }

        private void BtnAddMode_Click(object sender, EventArgs e)
        {
            var addFormMode = new AddModeForm(_messageBox);

            if (addFormMode.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var mode = addFormMode.GetModeModel().ToMode();
            _modeService.Add(mode);
            UpdateSelectMode();
        }

        private void BtnAddItemStep_Click(object sender, EventArgs e)
        {
            if (_selectMode.Items == null || _selectMode.Items.Count == 0)
            {
                _messageBox.ShowWarning("Add a mode to the table to add a step.");
                return;
            }

            var addFormStep = new AddStepForm(_messageBox, _selectMode);

            if (addFormStep.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var step = addFormStep.GetModeModel().ToStep();
            _stepService.Add(step);
        }

        private void UpdateSelectMode() => _selectMode = new SelectMode(_modeService.GetAllMode());

        private void TableForm_Load(object sender, EventArgs e)
        {
            UpdateSelectMode();
        }
    }
}
