using Microsoft.AspNetCore.Components;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;

namespace TestTask.MudBlazors.Model.TableComponent
{
    public class ProductModel
    {
        private string _name = string.Empty;
        private Company? _company = null;
        private Category? _category = null;
        private ProductType? _productType = null;
        private decimal _price = decimal.Zero;
        private string _description = string.Empty;

        public ProductModel()
        {
        }

        public ProductModel(string name, Company company, Category category, ProductType productType, string description, decimal price)
        {
            Name = name;
            Company = company;
            Category = category;
            ProductType = productType;
            Description = description;
            Price = price;
        }

        [Parameter]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        [Parameter]
        public Company? Company
        {
            get => _company;
            set => _company = value;
        }

        [Parameter]
        public Category? Category
        {
            get => _category;
            set => _category = value;
        }

        [Parameter]
        public ProductType? ProductType
        {
            get => _productType;
            set => _productType = value;
        }

        [Parameter]
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        [Parameter]
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public Product GetProductType() => new Product(Name, Company.Id, Category.Id, ProductType.Id, Description, Price);

        public Product GetModifyType(int idOldItem) => new Product(Name, Company.Id, Category.Id, ProductType.Id, Description, Price, idOldItem);

        public void ClearData()
        {
            Name = string.Empty;
            Company = null;
            Category = null;
            ProductType = null;
            Description = string.Empty;
            Price = decimal.Zero;
        }
    }
}
