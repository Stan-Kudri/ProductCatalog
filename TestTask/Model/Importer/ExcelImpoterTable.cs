using System.Threading.Tasks;
using TestTask.Core;
using TestTask.Core.DataTable;
using TestTask.Core.Extension;
using TestTask.Core.Import;
using TestTask.Core.Models;

namespace TestTask.Model.Importer
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
