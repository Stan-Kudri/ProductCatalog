using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models.Companies;

namespace ProductCatalog.Model.Importer
{
    public class ExcelImporterCompany : ExcelImpoterTable<Company>
    {
        public ExcelImporterCompany(IMessageBox messageBox, CompanyService service, ExcelImporter<Company> excelImport)
            : base(messageBox, service, excelImport, Table.Company)
        {
        }
    }
}
