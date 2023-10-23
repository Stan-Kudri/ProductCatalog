using System;
using System.Windows.Forms;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.Import
{
    public partial class ImportDatabaseForm : Form
    {
        IMessageBox _messageBox;

        public ImportDatabaseForm(IMessageBox messageBox)
        {
            InitializeComponent();
            _messageBox = messageBox;
        }

        private void BtnImportData_Click(object sender, EventArgs e)
        {
            if (cbModes.Checked == cbStep.Checked == false)
            {
                _messageBox.ShowWarning("The tables to load are not selected.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public bool IsDownloadTableMode => cbModes.Checked;

        public bool IsDownloadTableStep => cbStep.Checked;
    }
}
