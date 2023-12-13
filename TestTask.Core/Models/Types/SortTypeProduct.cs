using Ardalis.SmartEnum;
using System.Linq;

namespace TestTask.Core.Models.Types
{
    public abstract class SortTypeProduct : SmartEnum<SortTypeProduct>
    {
        public static readonly SortTypeProduct Id = new IdSortType("Id", 0);
        public static readonly SortTypeProduct Name = new NameSortType("Name", 1);

        public SortTypeProduct(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<ProductType> OrderBy(IQueryable<ProductType> query, bool asc);
        public abstract IOrderedQueryable<ProductType> ThenBy(IOrderedQueryable<ProductType> query, bool asc);

        public override string ToString()
        {
            return base.Name;
        }
    }

    partial class IdSortType : SortTypeProduct
    {
        public IdSortType(string name, int value)
            : base(name, value)
        {

        }

        public override IOrderedQueryable<ProductType> OrderBy(IQueryable<ProductType> query, bool asc) => asc ? query.OrderBy(e => e.Id) : query.OrderByDescending(e => e.Id);
        public override IOrderedQueryable<ProductType> ThenBy(IOrderedQueryable<ProductType> query, bool asc) => asc ? query.ThenBy(e => e.Id) : query.ThenByDescending(e => e.Id);
    }

    partial class NameSortType : SortTypeProduct
    {
        public NameSortType(string name, int value)
            : base(name, value)
        {

        }

        public override IOrderedQueryable<ProductType> OrderBy(IQueryable<ProductType> query, bool asc) => asc ? query.OrderBy(e => e.Name) : query.OrderByDescending(e => e.Name);
        public override IOrderedQueryable<ProductType> ThenBy(IOrderedQueryable<ProductType> query, bool asc) => asc ? query.ThenBy(e => e.Name) : query.ThenByDescending(e => e.Name);
    }

    partial class CategorySortType : SortTypeProduct
    {
        public CategorySortType(string name, int value)
            : base(name, value)
        {

        }

        public override IOrderedQueryable<ProductType> OrderBy(IQueryable<ProductType> query, bool asc) => asc ? query.OrderBy(e => e.Category.Name) : query.OrderByDescending(e => e.Category.Name);
        public override IOrderedQueryable<ProductType> ThenBy(IOrderedQueryable<ProductType> query, bool asc) => asc ? query.ThenBy(e => e.Category.Name) : query.ThenByDescending(e => e.Category.Name);
    }
}
