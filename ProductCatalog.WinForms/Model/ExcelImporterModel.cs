using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCatalog.Core.DataTable;
using ProductCatalog.WinForms.Model.Importer;

namespace ProductCatalog.WinForms.Model
{
    public sealed class ExcelImporterModel(IEnumerable<IExcelImpoterTable> excelImpoterTables)
    {
        public async Task UpdataDB(HashSet<Table> selectTables, string path)
        {
            var toImport = excelImpoterTables.Where(importer => selectTables.Contains(importer.Table));

            foreach (var table in toImport)
            {
                await table.ImportAsync(path);
            }
        }
    }
}
