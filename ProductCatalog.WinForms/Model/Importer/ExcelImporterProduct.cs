using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.WinForms.Model.Importer
{
    public class ExcelImporterProduct(IMessageBox messageBox, ProductService service, ExcelImporter<Product> excelImport)
        : ExcelImpoterTable<Product>(messageBox, service, excelImport, Table.Product)
    {
    }
}
