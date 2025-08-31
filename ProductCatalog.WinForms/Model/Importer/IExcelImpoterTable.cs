using ProductCatalog.Core.DataTable;
using System.Threading.Tasks;

namespace ProductCatalog.WinForms.Model.Importer
{
    public interface IExcelImpoterTable
    {
        Table Table { get; }

        Task ImportAsync(string path);
    }
}
