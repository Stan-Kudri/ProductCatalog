using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.DataTable;
using TestTask.Model.Importer;

namespace TestTask.Model
{
    public sealed class ExcelImporterModel
    {
        private readonly IEnumerable<IExcelImpoterTable> _excelImporterTables;

        public ExcelImporterModel(IEnumerable<IExcelImpoterTable> excelImpoterTables)
            => _excelImporterTables = excelImpoterTables;

        public async Task UpdataDB(HashSet<Tables> selectTables, string path)
        {
            foreach (var table in _excelImporterTables)
            {
                await table.UpsertData(selectTables, path);
            }
        }
    }
}
