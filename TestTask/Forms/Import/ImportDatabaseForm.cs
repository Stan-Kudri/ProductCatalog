using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.Core;
using TestTask.Core.DataTable;
using TestTask.Forms;

namespace TestTask.ChildForms.Import
{
    public partial class ImportDatabaseForm : BaseForm
    {
        private readonly IMessageBox _messageBox;

        public ImportDatabaseForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
        }

        private Dictionary<Tables, bool> SelectTables = new Dictionary<Tables, bool>()
        {
            { Tables.Company, true},
            { Tables.Category, true},
            { Tables.TypeProduct, true},
            { Tables.Product, true}
        };

        public HashSet<Tables> GetSelectTable()
        {
            var selectTable = new HashSet<Tables>();

            foreach (var table in SelectTables)
            {
                if (table.Value)
                {
                    selectTable.Add(table.Key);
                }
            }

            return selectTable;
        }

        private async void BtnImportData_Click(object sender, EventArgs e)
        {
            if (!SelectTables.ContainsValue(true))
            {
                await _messageBox.ShowWarning("The tables to load are not selected.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbCompany_CheckedChanged(object sender, EventArgs e)
            => SelectTables[Tables.Company] = cbCompany.Checked;

        private void cbProduct_CheckedChanged(object sender, EventArgs e)
            => SelectTables[Tables.Product] = cbProduct.Checked;

        private void cbType_CheckedChanged(object sender, EventArgs e)
            => SelectTables[Tables.TypeProduct] = cbType.Checked;

        private void cbCategory_CheckedChanged(object sender, EventArgs e)
            => SelectTables[Tables.Category] = cbCategory.Checked;
    }
}
