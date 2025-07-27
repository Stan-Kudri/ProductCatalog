using TestTask.Core.Models.Companies;

namespace TestTask.Core.Export.SheetFillers.Model
{
    public class CompanySheetFiller : SheetFiller<Company, CompanyField>
    {
        public CompanySheetFiller(CompanyService service) : base(service)
        {
        }
    }
}
