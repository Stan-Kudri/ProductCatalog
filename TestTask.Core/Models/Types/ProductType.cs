using System;
using System.Collections.Generic;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Models.Types
{
    public class ProductType : Entity, IEquatable<ProductType>
    {
        public ProductType()
        {
        }

        public ProductType(string name, int categoryId, int id)
            : this(name, categoryId)
            => Id = id > 0
                    ? Id = id
                    : throw new ArgumentException("The ID must be greater than zero.", nameof(id));

        public ProductType(string name, int categoryId)
        {
            Name = name != string.Empty && name != null
                   ? Name = name
                   : throw new ArgumentException("The category name cannot be empty.", nameof(name));

            CategoryId = categoryId > 0
                         ? CategoryId = categoryId
                         : throw new ArgumentException("Category ID greater than zero.", nameof(categoryId));
        }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<Product> Products { get; set; } = null;

        public override bool Equals(object obj) => Equals(obj as ProductType);

        public bool Equals(ProductType other)
            => other != null && other.Id == Id && other.Name == Name;

        public override int GetHashCode() => Id.GetHashCode() + Name.GetHashCode();

        public override string ToString() => Name;
    }
}
