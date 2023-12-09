using TestTask.Core.Models.Companies;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Extension
{
    public static class CompanyItemExtension
    {
        public static CompanyModel GetCompanyModel(this Company company)
            => new CompanyModel(company.Name, company.DateCreation, company.Country);
    }
}
