using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.DataTable;

namespace TestTask.Model.Importer
{
    public interface IExcelImpoterTable
    {
        Task UpsertData(HashSet<Tables> selectTable, string path);
    }
}
