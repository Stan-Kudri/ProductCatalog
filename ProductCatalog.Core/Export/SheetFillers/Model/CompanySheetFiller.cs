using ProductCatalog.Core.Models.Companies;

namespace ProductCatalog.Core.Export.SheetFillers.Model
{
    public class CompanySheetFiller : SheetFiller<Company, CompanyField>
    {
        public CompanySheetFiller(CompanyService service) : base(service)
        {
        }
    }
}
