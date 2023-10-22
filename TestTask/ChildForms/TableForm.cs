using System;
using System.Windows.Forms;
using TestTask.ChildForms.ModeForm;
using TestTask.Core.Service;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms
{
    public partial class TableForm : Form
    {
        private readonly ModeService _modeService;
        private readonly StepService _stepService;
        private readonly IMessageBox _messageBox;

        public TableForm(ModeService modeService, StepService stepService, IMessageBox messageBox)
        {
            InitializeComponent();
            _modeService = modeService;
            _stepService = stepService;
            _messageBox = messageBox;
        }

        private void BtnAddMode_Click(object sender, EventArgs e)
        {
            var addFormMode = new AddModeForm();

            if (addFormMode.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var mode = addFormMode.GetModeModel().ToMode();
            _modeService.Add(mode);
        }
    }
}
