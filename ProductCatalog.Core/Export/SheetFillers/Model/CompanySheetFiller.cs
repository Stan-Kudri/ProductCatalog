using ProductCatalog.Core.Models.Companies;

namespace ProductCatalog.Core.Export.SheetFillers.Model
{
    public class CompanySheetFiller(CompanyService service) : SheetFiller<Company, CompanyField>(service)
    {
    }
}
