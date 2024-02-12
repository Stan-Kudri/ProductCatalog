using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Types;

namespace TestTask.Core.Models.Products
{
    public abstract class ProductSortField : SmartEnum<ProductSortField>, ISortableSmartEnum<Product>, ISortableSmartEnumOperation<Product>
    {
        public static readonly ProductSortField Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly ProductSortField Name = new SortType<string>("Name", 1, e => e.Name);
        public static readonly ProductSortField Company = new SortType<Company>("Company", 2, e => e.Company);
        public static readonly ProductSortField Category = new SortType<Category>("Category", 3, e => e.Category);
        public static readonly ProductSortField ProductType = new SortType<ProductType>("Product Type", 4, e => e.Type);
        public static readonly ProductSortField Price = new SortType<decimal>("Price", 5, e => e.Price);

        static ISortableSmartEnum<Product> ISortableSmartEnumOperation<Product>.DefaultValue => Id;
        static IReadOnlyCollection<ISortableSmartEnum<Product>> ISortableSmartEnumOperation<Product>.List => List;

        public ProductSortField(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Product> OrderBy(IQueryable<Product> query, bool asc);
        public abstract IOrderedQueryable<Product> ThenBy(IOrderedQueryable<Product> query, bool asc);

        public override string ToString() => base.Name;

        private sealed class SortType<TKey> : ProductSortField
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
