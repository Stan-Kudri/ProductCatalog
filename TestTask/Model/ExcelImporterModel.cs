using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.DataTable;
using TestTask.Model.Importer;

namespace TestTask.Model
{
    public sealed class ExcelImporterModel(IEnumerable<IExcelImpoterTable> excelImpoterTables)
    {
        public async Task UpdataDB(HashSet<Tables> selectTables, string path)
        {
            foreach (var table in excelImpoterTables)
            {
                await table.ImportAsync(selectTables, path);
            }
        }
    }
}
