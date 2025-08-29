using System.Threading.Tasks;
using ProductCatalog.Core.DataTable;

namespace ProductCatalog.Model.Importer
{
    public interface IExcelImpoterTable
    {
        Table Table { get; }

        Task ImportAsync(string path);
    }
}
