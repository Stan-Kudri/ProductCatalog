using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.Core;
using TestTask.Core.DataTable;
using TestTask.Forms;
using TestTask.Model;

namespace TestTask.ChildForms.Import
{
    public partial class ImportDatabaseForm : BaseForm
    {
        private readonly IMessageBox _messageBox;
        private readonly SelectTableModel _selectTable = new SelectTableModel();

        public ImportDatabaseForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
        }

        public HashSet<Tables> GetSelectTable()
        {
            if (cbCompany.Checked)
            {
                _selectTable.Add(Tables.Company);
            }
            if (cbProduct.Checked)
            {
                _selectTable.Add(Tables.Product);
            }
            if (cbCategory.Checked)
            {
                _selectTable.Add(Tables.TypeProduct);
            }
            if (cbType.Checked)
            {
                _selectTable.Add(Tables.Category);
            }

            return _selectTable.SelectTables;
        }

        private async void BtnImportData_Click(object sender, EventArgs e)
        {
            if (!cbCompany.Checked && !cbProduct.Checked && !cbCategory.Checked && !cbType.Checked)
            {
                await _messageBox.ShowWarning("The tables to load are not selected.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
