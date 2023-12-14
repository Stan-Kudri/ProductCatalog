using Ardalis.SmartEnum;
using System.Linq;

namespace TestTask.Core.Models.Products
{
    public abstract class SortFieldProduct : SmartEnum<SortFieldProduct>
    {
        public static readonly SortFieldProduct Id = new IdSortProduct("Id", 0);
        public static readonly SortFieldProduct Name = new NameSortProduct("Name", 1);
        public static readonly SortFieldProduct Company = new CompanySortProduct("Company", 2);
        public static readonly SortFieldProduct Category = new CategorySortProduct("Category", 3);
        public static readonly SortFieldProduct ProductType = new ProductTypeSortProduct("Product Type", 4);
        public static readonly SortFieldProduct Price = new PriceSortProduct("Price", 5);

        public SortFieldProduct(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc);
        public abstract IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc);

        public override string ToString()
        {
            return base.Name;
        }
    }

    partial class IdSortProduct : SortFieldProduct
    {
        public IdSortProduct(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc)
            => asc ? query.OrderBy(e => e.Id) : query.OrderByDescending(e => e.Id);

        public override IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc)
            => asc ? query.ThenBy(e => e.Id) : query.ThenByDescending(e => e.Id);
    }

    partial class NameSortProduct : SortFieldProduct
    {
        public NameSortProduct(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc)
            => asc ? query.OrderBy(e => e.Name) : query.OrderByDescending(e => e.Name);

        public override IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc)
            => asc ? query.ThenBy(e => e.Name) : query.ThenByDescending(e => e.Name);
    }

    partial class CompanySortProduct : SortFieldProduct
    {
        public CompanySortProduct(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc)
            => asc ? query.OrderBy(e => e.Company.Name) : query.OrderByDescending(e => e.Company.Name);

        public override IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc)
            => asc ? query.ThenBy(e => e.Company.Name) : query.ThenByDescending(e => e.Company.Name);
    }

    partial class CategorySortProduct : SortFieldProduct
    {
        public CategorySortProduct(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc)
            => asc ? query.OrderBy(e => e.Category.Name) : query.OrderByDescending(e => e.Category.Name);

        public override IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc)
            => asc ? query.ThenBy(e => e.Category.Name) : query.ThenByDescending(e => e.Category.Name);
    }

    partial class ProductTypeSortProduct : SortFieldProduct
    {
        public ProductTypeSortProduct(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc)
            => asc ? query.OrderBy(e => e.Type.Name) : query.OrderByDescending(e => e.Type.Name);

        public override IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc)
            => asc ? query.ThenBy(e => e.Type.Name) : query.ThenByDescending(e => e.Type.Name);
    }

    partial class PriceSortProduct : SortFieldProduct
    {
        public PriceSortProduct(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc)
            => asc ? query.OrderBy(e => e.Price) : query.OrderByDescending(e => e.Price);

        public override IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc)
            => asc ? query.ThenBy(e => e.Price) : query.ThenByDescending(e => e.Price);
    }
}
