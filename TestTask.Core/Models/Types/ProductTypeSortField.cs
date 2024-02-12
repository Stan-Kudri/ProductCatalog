using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Models.Types
{
    public abstract class ProductTypeSortField : SmartEnum<ProductTypeSortField>, ISortableSmartEnum<ProductType>, ISortableSmartEnumOperation<ProductType>
    {
        public static readonly ProductTypeSortField Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly ProductTypeSortField Name = new SortType<string>("Name", 1, e => e.Name);
        public static readonly ProductTypeSortField Category = new SortType<Category>("Category", 2, e => e.Category);

        static ISortableSmartEnum<ProductType> ISortableSmartEnumOperation<ProductType>.DefaultValue => Id;
        static IReadOnlyCollection<ISortableSmartEnum<ProductType>> ISortableSmartEnumOperation<ProductType>.List => List;

        public ProductTypeSortField(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<ProductType> OrderBy(IQueryable<ProductType> query, bool asc);
        public abstract IOrderedQueryable<ProductType> ThenBy(IOrderedQueryable<ProductType> query, bool asc);

        public override string ToString() => base.Name;

        private sealed class SortType<TKey> : ProductTypeSortField
        {
            private readonly Expression<Func<ProductType, TKey>> _expression;

            public SortType(string name, int value, Expression<Func<ProductType, TKey>> expression)
                : base(name, value)
            {
                _expression = expression;
            }

            public override IOrderedQueryable<ProductType> OrderBy(IQueryable<ProductType> query, bool asc)
                => asc ? query.OrderBy(_expression) : query.OrderByDescending(_expression);

            public override IOrderedQueryable<ProductType> ThenBy(IOrderedQueryable<ProductType> query, bool asc)
                => asc ? query.ThenBy(_expression) : query.ThenByDescending(_expression);
        }
    }
}
