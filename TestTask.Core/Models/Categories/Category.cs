using System;
using System.Collections.Generic;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Products;
using ProductType = TestTask.Core.Models.Types.ProductType;

namespace TestTask.Core.Models.Categories
{
    public class Category : Entity, IEquatable<Category>
    {
        public Category()
        {
        }

        public Category(string name, int id)
            : this(name)
            => Id = id > 0
                    ? Id = id
                    : throw BusinessLogicException.EnsureIdLessThenZero<Category>(id);

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
