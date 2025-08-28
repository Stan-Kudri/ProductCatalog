using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.Model.Importer
{
    public class ExcelImporterCategory : ExcelImpoterTable<Category>
    {
        public ExcelImporterCategory(IMessageBox messageBox, CategoryService service, ExcelImporter<Category> excelImport)
            : base(messageBox, service, excelImport, Table.Category)
        {
        }
    }
}
