using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Models.Types;

namespace TestTask.Model.Importer
{
    public class ExcelImporterTypeProduct : ExcelImpoterTable<ProductType>
    {
        public ExcelImporterTypeProduct(IMessageBox messageBox, ProductTypeRepository repository, ExcelImporter<ProductType> excelImport)
            : base(messageBox, repository, excelImport)
        {
        }
    }
}
