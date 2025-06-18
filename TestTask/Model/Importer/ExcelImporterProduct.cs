using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Models.Products;

namespace TestTask.Model.Importer
{
    public class ExcelImporterProduct : ExcelImpoterTable<Product>
    {
        public ExcelImporterProduct(IMessageBox messageBox, ProductRepository repository, ExcelImporter<Product> excelImport)
            : base(messageBox, repository, excelImport)
        {
        }
    }
}
