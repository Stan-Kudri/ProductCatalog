using System;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Types;

namespace TestTask.Core.Models.Products
{
    public class Product : Entity, IEquatable<Product>
    {
        public Product()
        {
        }

        public Product(string name, int companyId, int categoryId, int typeId, string destination, decimal price, int id)
            : this(name, companyId, categoryId, typeId, destination, price)
            => Id = id > 0
                    ? Id = id
                    : throw new ArgumentException("The ID must be greater than zero.", nameof(id));

        public Product(string name, int companyId, int categoryId, int typeId, string destination, decimal price)
        {
            Name = name != null && name != string.Empty
                   ? Name = name
                   : throw new ArgumentException("The name product cannot be empty.", name);

            CompanyId = companyId > 0
                        ? CompanyId = companyId
                        : throw new ArgumentException("Company ID greater than zero.", nameof(companyId));

            CategoryId = categoryId > 0
                         ? CategoryId = categoryId
                         : throw new ArgumentException("Category ID greater than zero.", nameof(categoryId));

            TypeId = typeId > 0
                     ? TypeId = typeId
                     : throw new ArgumentException("Type ID greater than zero.", nameof(typeId));

            Price = price > 0
                    ? Price = price
                    : throw new ArgumentException("The price is greater than zero.", nameof(price));

            Destination = destination;
        }

        public string Name { get; set; }

        public decimal Price { get; set; } = decimal.Zero;

        public string Destination { get; set; } = null;

        public int TypeId { get; set; } = 0;

        public ProductType Type { get; set; }

        public int CompanyId { get; set; } = 0;

        public Company Company { get; set; }

        public int CategoryId { get; set; } = 0;

        public Category Category { get; set; }

        public override bool Equals(object obj) => Equals(obj as Product);

        public bool Equals(Product other)
        {
            if (other == null)
            {
                return false;
            }

            return other.Name == Name
                   && other.Id == Id
                   && other.CompanyId == CompanyId
                   && other.CategoryId == CategoryId
                   && other.TypeId == TypeId
                   && other.Price == Price
                   && other.Destination == Destination;
        }

        public override int GetHashCode() => Id.GetHashCode() * CompanyId.GetHashCode() + Type.GetHashCode();
    }
}
