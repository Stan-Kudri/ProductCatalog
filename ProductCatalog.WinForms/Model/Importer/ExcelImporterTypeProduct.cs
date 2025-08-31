using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.WinForms.Model.Importer
{
    public class ExcelImporterTypeProduct(IMessageBox messageBox, ProductTypeService service, ExcelImporter<ProductType> excelImport)
        : ExcelImpoterTable<ProductType>(messageBox, service, excelImport, Table.TypeProduct)
    {
    }
}
