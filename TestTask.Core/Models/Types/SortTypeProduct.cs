using Ardalis.SmartEnum;
using System;
using System.Linq;
using System.Linq.Expressions;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Models.Types
{
    public abstract class SortTypeProduct : SmartEnum<SortTypeProduct>, ISortableSmartEnum<ProductType>
    {
        public static readonly SortTypeProduct Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly SortTypeProduct Name = new SortType<string>("Name", 1, e => e.Name);
        public static readonly SortTypeProduct Category = new SortType<Category>("Category", 2, e => e.Category);

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

        private sealed class SortType<TKey> : SortTypeProduct
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
