using System;
using System.Collections.Generic;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Models.Types
{
    public class ProductType : Entity, IEquatable<ProductType>
    {
        public ProductType()
        {
        }

        public ProductType(string name, Guid categoryId, Guid id)
            : this(name, categoryId) => Id = id;

        public ProductType(string name, Guid categoryId)
        {
            BusinessLogicException.ThrowIfNullOrEmpty(name);
            Name = name;
            CategoryId = categoryId;
        }

        public string Name { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public List<Product> Products { get; set; } = null;

        public override bool Equals(object obj) => Equals(obj as ProductType);

        public bool Equals(ProductType other)
            => other != null && other.Id == Id && other.Name == Name;

        public override int GetHashCode() => Id.GetHashCode() + Name.GetHashCode();

        public override string ToString() => Name;
    }
}
