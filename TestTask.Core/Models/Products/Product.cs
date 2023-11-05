using System;

namespace TestTask.Core.Models.Products
{
    public class Product : Entity, IEquatable<Product>
    {
        public Product()
        {
        }

        public Product(int modeId, string category, string type, string destination, decimal price, int id)
            : this(modeId, category, type, destination, price)
        {
            Id = id > 0 ? Id = id : throw new ArgumentException("The ID must be greater than zero.", nameof(id));
        }

        public Product(int modeId, string category, string type, string destination, decimal price)
        {
            CompanyId = modeId > 0 ? CompanyId = modeId : throw new ArgumentException("Company ID greater than zero.", nameof(modeId));

            Category = category != string.Empty && category != null ?
                Category = category :
                throw new ArgumentException("The category name cannot be empty.", nameof(category));

            Type = type != string.Empty && type != null ?
                Type = type :
                throw new ArgumentException("The type name cannot be empty.", nameof(type));

            Destination = destination;

            Price = price > 0 ? Price = price : throw new ArgumentException("The price is greater than zero.", nameof(price));
        }

        public int CompanyId { get; set; } = 0;

        public string Category { get; set; } = string.Empty;

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
                   && other.Category == Category
                   && other.Type == Type
                   && other.Price == Price
                   && other.Destination == Destination;
        }

        public override int GetHashCode() => Id.GetHashCode() * CompanyId.GetHashCode() + Type.GetHashCode();
    }
}
