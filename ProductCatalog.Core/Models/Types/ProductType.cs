using System;
using System.Collections.Generic;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.Core.Models.Types
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
