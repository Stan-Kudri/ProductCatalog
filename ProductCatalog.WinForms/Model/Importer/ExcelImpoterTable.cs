using System.Threading.Tasks;
using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Extension;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models;
using ProductCatalog.WinForms.Model.Importer;

namespace ProductCatalog.WinForms.Model.Importer
{
    public class ExcelImpoterTable<T>(IMessageBox messageBox, BaseService<T> service, ExcelImporter<T> excelImport, Table table)
        : IExcelImpoterTable
        where T : Entity
    {
        public Table Table => table;

        public async Task ImportAsync(string path)
        {
            var reader = excelImport.ImportFromFile(path);

            foreach (var item in reader)
            {
                if (item.Success)
                {
                    await service.UpsertAsync(item.Value);
                }
            }

            if (!reader.IsNoErrorLine(out var message))
            {
                await messageBox.ShowWarning(message, typeof(T).Name);
            }
        }
    }
}
