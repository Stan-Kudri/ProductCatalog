using System;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Products;
using ProductType = ProductCatalog.Core.Models.Types.ProductType;

namespace ProductCatalog.WinForms.BindingItem.DBItemModel
{
    public class ProductModel : ModelBase
    {
        private string _name = string.Empty;
        private Company _company = null;
        private Category _category = null;
        private ProductType _type = null;
        private decimal _price = 0;
        private string _destination = null;

        public ProductModel(string name, Company company, Category category, ProductType type, decimal price, string destination)
        {
            BusinessLogicException.ThrowIfNullOrEmpty(name);
            BusinessLogicException.ThrowIfNull(company);
            BusinessLogicException.ThrowIfNull(category);
            BusinessLogicException.ThrowIfNull(type);
            BusinessLogicException.ThrowIfNull(company);
            BusinessLogicException.EnsureRangeMinValue(price, 0);

            Name = name;
            Company = company;
            Category = category;
            Type = type;
            Destination = destination;
            Price = price;
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public Company Company
        {
            get => _company;
            set => SetField(ref _company, value);
        }

        public Category Category
        {
            get => _category;
            set => SetField(ref _category, value);
        }

        public ProductType Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        public string Destination
        {
            get => _destination;
            set => SetField(ref _destination, value);
        }

        public decimal Price
        {
            get => _price;
            set => SetField(ref _price, value);
        }

        public Product ToProduct() => new Product(_name, _company.Id, _category.Id, _type.Id, _destination, _price);

        public Product ToProduct(Guid productId) => new Product(_name, _company.Id, _category.Id, _type.Id, _destination, _price, productId);
    }
}
