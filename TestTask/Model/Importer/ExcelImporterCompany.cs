using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Models.Companies;

namespace TestTask.Model.Importer
{
    public class ExcelImporterCompany : ExcelImpoterTable<Company>
    {
        public ExcelImporterCompany(IMessageBox messageBox, CompanyRepository repository, ExcelImporter<Company> excelImport)
            : base(messageBox, repository, excelImport)
        {
        }
    }
}
