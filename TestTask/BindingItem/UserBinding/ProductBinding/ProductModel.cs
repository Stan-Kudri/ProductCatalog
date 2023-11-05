using System;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;

namespace TestTask.BindingItem.UserBinding.ProductBinding
{
    public class ProductModel : ModelBase
    {
        private Company _company = null;
        private string _category = string.Empty;
        private string _type = string.Empty;
        private decimal _price = 0;
        private string _destination = null;

        public ProductModel(Company company, string category, string type, decimal price, string destination)
        {
            Company = company ?? throw new ArgumentException("The company cannot be null.", nameof(company));

            Category = category != string.Empty && category != null ?
                Category = category :
                throw new ArgumentException("The category product cannot be empty.", nameof(category));

            Type = type != string.Empty && type != null ?
                Type = type :
                throw new ArgumentException("The type product cannot be empty.", nameof(type));

            Destination = destination;

            Price = price > 0 ? Price = price : throw new ArgumentException("The price is greater than zero.", nameof(price));
        }

        public Company Company
        {
            get => _company;
            set => SetField(ref _company, value);
        }

        public string Category
        {
            get => _category;
            set => SetField(ref _category, value);
        }

        public string Type
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

        public Product ToStep() => new Product(_company.Id, _category, _type, _destination, _price);

        public Product ToStep(int companyId) => new Product(_company.Id, _category, _type, _destination, _price, companyId);
    }
}
