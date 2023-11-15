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
            if (!cbCompany.Checked && !cbProduct.Checked && !cbCategory.Checked && !cbType.Checked)
            {
                _messageBox.ShowWarning("The tables to load are not selected.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public bool IsDownloadTableCompany => cbCompany.Checked;

        public bool IsDownloadTableProduct => cbProduct.Checked;

        public bool IsDownloadTableType => cbCategory.Checked;

        public bool IsDownloadTableCategory => cbType.Checked;
    }
}
