using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.WinForms.Model.Importer
{
    public class ExcelImporterCategory(IMessageBox messageBox, CategoryService service, ExcelImporter<Category> excelImport)
        : ExcelImpoterTable<Category>(messageBox, service, excelImport, Table.Category)
    {
    }
}
