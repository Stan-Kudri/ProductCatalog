using System;
using System.Collections.Generic;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Models.Companies
{
    public class Company : Entity
    {
        public Company()
        {
        }

        public Company(string name, DateTime dateCreation, string country, int id)
            : this(name, dateCreation, country)
        {
            Id = id > 0 ? Id = id : throw new ArgumentException("The ID must be greater than zero.", nameof(id));
        }

        public Company(string name, DateTime dateCreation, string country, List<Product> products = null)
        {
            Name = name != string.Empty && name != null ? Name = name : throw new ArgumentException("The product name cannot be empty.", nameof(name));

            DateCreation = dateCreation <= DateTime.Now ?
                DateCreation = dateCreation :
                throw new ArgumentException("The creation date is currently impossible.", nameof(dateCreation));

            Country = country != string.Empty && country != null ? Country = country : throw new ArgumentException("The country cannot be empty.", nameof(country));

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

        public override int GetHashCode() => Id.GetHashCode() + DateCreation.GetHashCode() + Country.GetHashCode();

        public override string ToString() => Name;
    }
}
