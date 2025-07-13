using System;
using TestTask.Core.Exeption;
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
                    : throw BusinessLogicException.EnsureIdLessThenZero<Product>(id);

        public Product(string name, int companyId, int categoryId, int typeId, string destination, decimal price)
        {
            BusinessLogicException.ThrowIfNullOrEmpty(name);

            Name = name;

            CompanyId = companyId > 0
                        ? CompanyId = companyId
                        : throw NotFoundException.NotFoundIdProperty<Company>(companyId);

            CategoryId = categoryId > 0
                         ? CategoryId = categoryId
                         : throw NotFoundException.NotFoundIdProperty<Category>(categoryId);

            TypeId = typeId > 0
                     ? TypeId = typeId
                     : throw NotFoundException.NotFoundIdProperty<ProductType>(typeId);

            Price = price > 0
                    ? Price = price
                    : throw BusinessLogicException.EnsureValueLessThenZero<Product>(nameof(price), price);

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

        public override int GetHashCode() => HashCode.Combine(Id, CompanyId, Type);
    }
}
