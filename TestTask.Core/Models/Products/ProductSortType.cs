using Ardalis.SmartEnum;
using System;
using System.Linq;
using System.Linq.Expressions;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Types;

namespace TestTask.Core.Models.Products
{
    public abstract class ProductSortType : SmartEnum<ProductSortType>, ISortableSmartEnum<Product>
    {
        public static readonly ProductSortType Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly ProductSortType Name = new SortType<string>("Name", 1, e => e.Name);
        public static readonly ProductSortType Company = new SortType<Company>("Company", 2, e => e.Company);
        public static readonly ProductSortType Category = new SortType<Category>("Category", 3, e => e.Category);
        public static readonly ProductSortType ProductType = new SortType<ProductType>("Product Type", 4, e => e.Type);
        public static readonly ProductSortType Price = new SortType<decimal>("Price", 5, e => e.Price);

        public ProductSortType(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc);
        public abstract IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc);

        public override string ToString() => base.Name;

        private sealed class SortType<TKey> : ProductSortType
        {
            private readonly Expression<Func<Product, TKey>> _expression;

            public SortType(string name, int value, Expression<Func<Product, TKey>> expression)
                : base(name, value)
            {
                _expression = expression;
            }

            public override IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc)
            => asc ? query.OrderBy(_expression) : query.OrderByDescending(_expression);

            public override IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc)
                => asc ? query.ThenBy(_expression) : query.ThenByDescending(_expression);
        }
    }
}
