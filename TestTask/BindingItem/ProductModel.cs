using System;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using ProductType = TestTask.Core.Models.Types.ProductType;

namespace TestTask.BindingItem
{
    public class ProductModel : ModelBase
    {
        private Company _company = null;
        private Category _category = null;
        private ProductType _type = null;
        private decimal _price = 0;
        private string _destination = null;

        public ProductModel(Company company, Category category, ProductType type, decimal price, string destination)
        {
            Company = company ?? throw new ArgumentException("The company cannot be null.", nameof(company));

            Category = category ?? throw new ArgumentException("The category cannot be null.", nameof(category));

            Type = type ?? throw new ArgumentException("The type cannot be null.", nameof(type));

            Destination = destination;

            Price = price > 0 ? Price = price : throw new ArgumentException("The price is greater than zero.", nameof(price));
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

        public Product ToProduct() => new Product(_company.Id, _category.Id, _type.Id, _destination, _price);

        public Product ToProduct(int productId) => new Product(_company.Id, _category.Id, _type.Id, _destination, _price, productId);
    }
}
