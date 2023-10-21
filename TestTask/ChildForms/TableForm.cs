using System;
using System.Windows.Forms;
using TestTask.ChildForms.ModeForm;
using TestTask.Core.Service;

namespace TestTask.ChildForms
{
    public partial class TableForm : Form
    {
        private readonly ModeService _modeService;
        private readonly StepService _stepService;

        public TableForm(ModeService modeService, StepService stepService)
        {
            InitializeComponent();
            _modeService = modeService;
            _stepService = stepService;
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
