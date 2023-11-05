using System;
using System.Collections.Generic;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Models.Categories
{
    public class Category : Entity
    {
        public Category()
        {
        }

        public Category(string name, int id)
            : this(name)
            => Id = id > 0 ? Id = id : throw new ArgumentException("The ID must be greater than zero.", nameof(id));

        public Category(string name, List<Product> product = null)
        {
            Name = name != string.Empty && name != null ? Name = name : throw new ArgumentException("The category name cannot be empty.", nameof(name));
            Product = product;
        }

        public string Name { get; set; }

        public List<Product> Product { get; set; } = null;

        public override bool Equals(object obj) => Equals(obj as Category);

        public bool Equals(Category other)
            => other != null && other.Id == Id && other.Name == Name;

        public override int GetHashCode() => Id.GetHashCode() + Name.GetHashCode();

        public override string ToString() => Name;
    }
}
