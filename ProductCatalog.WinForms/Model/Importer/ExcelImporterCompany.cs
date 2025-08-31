using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models.Companies;

namespace ProductCatalog.WinForms.Model.Importer
{
    public class ExcelImporterCompany(IMessageBox messageBox, CompanyService service, ExcelImporter<Company> excelImport)
        : ExcelImpoterTable<Company>(messageBox, service, excelImport, Table.Company)
    {
    }
}
