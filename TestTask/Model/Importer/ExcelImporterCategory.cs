using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;

namespace TestTask.Model.Importer
{
    public class ExcelImporterCategory : ExcelImpoterTable<Category>
    {
        public ExcelImporterCategory(IMessageBox messageBox, CategoryRepository repository, ExcelImporter<Category> excelImport)
            : base(messageBox, repository, excelImport)
        {
        }
    }
}
