using System;
using System.Collections.Generic;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.Core.Models.Companies
{
    public class Company : Entity
    {
        public Company()
        {
        }

        public Company(string name, DateTime dateCreation, string country, Guid id)
            : this(name, dateCreation, country) => Id = id;

        public Company(string name, DateTime dateCreation, string country, List<Product> products = null)
        {
            BusinessLogicException.ThrowIfNullOrEmpty(name);
            BusinessLogicException.ThrowIfNullOrEmpty(country);
            BusinessLogicException.EnsureRangeDate<Company>(dateCreation, nameof(dateCreation), DateTime.Now);

            Name = name;
            Country = country;
            DateCreation = dateCreation;
            Product = products;
        }

        public string Name { get; set; } = string.Empty;

        public DateTime DateCreation { get; set; } = DateTime.Now;

        public string Country { get; set; } = string.Empty;

        public List<Product> Product { get; set; } = null;

        public override bool Equals(object obj) => Equals(obj as Company);

        public bool Equals(Company other)
        {
            if (other == null)
            {
                return false;
            }

            return other.Id == Id
                   && other.Name == Name
                   && other.DateCreation == DateCreation
                   && other.Country == Country;
        }

        public override int GetHashCode() => HashCode.Combine(Name, Id, DateCreation, Country);

        public override string ToString() => Name;
    }
}
