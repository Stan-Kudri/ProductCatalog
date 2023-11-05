using System;

namespace TestTask.Core.Models.Products
{
    public class Product : Entity, IEquatable<Product>
    {
        public Product()
        {
        }

        public Product(int companyId, int categoryId, string type, string destination, decimal price, int id)
            : this(companyId, categoryId, type, destination, price)
        {
            Id = id > 0 ? Id = id : throw new ArgumentException("The ID must be greater than zero.", nameof(id));
        }

        public Product(int companyId, int categoryId, string type, string destination, decimal price)
        {
            CompanyId = companyId > 0 ? CompanyId = companyId : throw new ArgumentException("Company ID greater than zero.", nameof(companyId));

            CategoryId = categoryId > 0 ? CategoryId = categoryId : throw new ArgumentException("Category ID greater than zero.", nameof(categoryId));

            Type = type != string.Empty && type != null ?
                Type = type :
                throw new ArgumentException("The type name cannot be empty.", nameof(type));

            Destination = destination;

            Price = price > 0 ? Price = price : throw new ArgumentException("The price is greater than zero.", nameof(price));
        }

        public int CompanyId { get; set; } = 0;

        public int CategoryId { get; set; } = 0;

        public string Type { get; set; } = string.Empty;

        public string Destination { get; set; } = null;

        public decimal Price { get; set; } = decimal.Zero;

        public override bool Equals(object obj) => Equals(obj as Product);

        public bool Equals(Product other)
        {
            if (other == null)
            {
                return false;
            }

            return other.Id == Id
                   && other.CompanyId == CompanyId
                   && other.CategoryId == CategoryId
                   && other.Type == Type
                   && other.Price == Price
                   && other.Destination == Destination;
        }

        public override int GetHashCode() => Id.GetHashCode() * CompanyId.GetHashCode() + Type.GetHashCode();
    }
}
