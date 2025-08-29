using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.MudBlazors.Model.TableComponent;

namespace ProductCatalog.MudBlazors.Extension
{
    public static class GetModelItemExtension
    {
        public static CompanyModel GetCompanyModel(this Company company)
            => new CompanyModel(company.Name, company.DateCreation, company.Country);

        public static CategoryModel GetCategoryModel(this Category category)
            => new CategoryModel(category.Name);

        public static TypeProductModel GetTypeProductModel(this ProductType type)
          => new TypeProductModel(type.Name, type.Category);

        public static ProductModel GetProductModel(this Product product)
          => new ProductModel(product.Name, product.Company, product.Category, product.Type, product.Destination, product.Price);
    }
}
