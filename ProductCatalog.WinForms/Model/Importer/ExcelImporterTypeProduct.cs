using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.Model.Importer
{
    public class ExcelImporterTypeProduct : ExcelImpoterTable<ProductType>
    {
        public ExcelImporterTypeProduct(IMessageBox messageBox, ProductTypeService service, ExcelImporter<ProductType> excelImport)
            : base(messageBox, service, excelImport, Table.TypeProduct)
        {
        }
    }
}
