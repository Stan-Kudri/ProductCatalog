using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.Core;
using TestTask.Forms;

namespace TestTask.ChildForms.Import
{
    public partial class ImportDatabaseForm : BaseForm
    {
        IMessageBox _messageBox;

        public ImportDatabaseForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
        }

        private void BtnImportData_Click(object sender, EventArgs e)
        {
            if (!cbModes.Checked && !cbStep.Checked)
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
