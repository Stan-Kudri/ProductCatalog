using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Extension
{
    public static class GetModelItemExtension
    {
        public static CompanyModel GetCompanyModel(this Company company)
            => new CompanyModel(company.Name, company.DateCreation, company.Country);

        public static CategoryModel GetCategoryModel(this Category category) => new CategoryModel(category.Name);

        public static ProductType GetTypeProductModel(this ProductType type)
          => new ProductType(type.Name, type.CategoryId);
    }
}
