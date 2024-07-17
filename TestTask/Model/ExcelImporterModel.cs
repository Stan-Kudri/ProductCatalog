using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.DataTable;
using TestTask.Model.Importer;

namespace TestTask.Model
{
    public class ExcelImporterModel
    {
        private readonly List<IExcelImpoterTable> _excelImporterTables;

        public ExcelImporterModel(
            ExcelImporterCompany excelImporterCompany,
            ExcelImporterCategory excelImporterCategory,
            ExcelImporterTypeProduct excelImporterTypeProduct,
            ExcelImporterProduct excelImporterProduct)
        {
            _excelImporterTables = new List<IExcelImpoterTable>()
            {
                excelImporterCompany,
                excelImporterCategory,
                excelImporterTypeProduct,
                excelImporterProduct,
            };
        }

        public async Task UpdataDB(HashSet<Tables> selectTables, string path)
        {
            foreach (var table in _excelImporterTables)
            {
                await table.UpsertData(selectTables, path);
            }
        }
    }
}
