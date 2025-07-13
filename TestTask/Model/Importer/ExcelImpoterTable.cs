using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core;
using TestTask.Core.DataTable;
using TestTask.Core.Extension;
using TestTask.Core.Import;
using TestTask.Core.Models;

namespace TestTask.Model.Importer
{
    public class ExcelImpoterTable<T>(IMessageBox messageBox, BaseRepository<T> repository, ExcelImporter<T> excelImport)
        : IExcelImpoterTable
        where T : Entity
    {
        public async Task ImportAsync(HashSet<Tables> selectTable, string path)
        {
            if (selectTable.Contains(Tables.Company))
            {
                var reader = excelImport.ImportFromFile(path);

                foreach (var item in reader)
                {
                    if (item.Success)
                    {
                        await repository.UpsertAsync(item.Value);
                    }
                }

                if (!reader.IsNoErrorLine(out var message))
                {
                    await messageBox.ShowWarning(message, typeof(T).Name);
                }
            }
        }
    }
}
