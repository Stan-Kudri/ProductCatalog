using System;
using System.Collections.Generic;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Products;
using ProductType = ProductCatalog.Core.Models.Types.ProductType;

namespace ProductCatalog.Core.Models.Categories
{
    public class Category : Entity, IEquatable<Category>
    {
        public Category()
        {
        }

        public Category(string name, Guid id)
            : this(name) => Id = id;

        public Category(string name, List<Product> product = null, List<ProductType> type = null)
        {
            BusinessLogicException.ThrowIfNullOrEmpty(name);
            Name = name;
            Products = product;
            Types = type;
        }

        public string Name { get; set; }

        public List<Product> Products { get; set; } = null;

        public List<ProductType> Types { get; set; } = null;

        public override bool Equals(object obj) => Equals(obj as Category);

        public bool Equals(Category other)
            => other != null && other.Id == Id && other.Name == Name;

        public override int GetHashCode() => Id.GetHashCode() + Name.GetHashCode();

        public override string ToString() => Name;
    }
}
