using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.Model.Importer
{
    public class ExcelImporterProduct : ExcelImpoterTable<Product>
    {
        public ExcelImporterProduct(IMessageBox messageBox, ProductService service, ExcelImporter<Product> excelImport)
            : base(messageBox, service, excelImport, Table.Product)
        {
        }
    }
}
