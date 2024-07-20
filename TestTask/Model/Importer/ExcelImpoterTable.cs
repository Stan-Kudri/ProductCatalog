using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core;
using TestTask.Core.DataTable;
using TestTask.Core.Extension;
using TestTask.Core.Import;
using TestTask.Core.Models;

namespace TestTask.Model.Importer
{
    public class ExcelImpoterTable<T> : IExcelImpoterTable
        where T : Entity
    {
        private readonly IMessageBox _messageBox;
        private readonly IRepository<T> _repository;
        private readonly ExcelImporter<T> _excelImport;

        public ExcelImpoterTable(IMessageBox messageBox, IRepository<T> repository, ExcelImporter<T> excelImport)
        {
            _messageBox = messageBox;
            _repository = repository;
            _excelImport = excelImport;
        }

        public async Task ImportAsync(HashSet<Tables> selectTable, string path)
        {
            if (selectTable.Contains(Tables.Company))
            {
                var reader = _excelImport.ImportFromFile(path);

                foreach (var item in reader)
                {
                    if (item.Success)
                    {
                        _repository.Upsert(item.Value);
                    }
                }

                if (!reader.IsNoErrorLine(out var message))
                {
                    await _messageBox.ShowWarning(message, typeof(T).Name);
                }
            }
        }
    }
}
