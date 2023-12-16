using Ardalis.SmartEnum;
using System;
using System.Linq;
using System.Linq.Expressions;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Models.Categories
{
    public abstract class SortTypeCategories : SmartEnum<SortTypeCategories>, ISortableSmartEnum<Category>
    {
        public static readonly SortTypeCategories Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly SortTypeCategories Name = new SortType<string>("Name", 1, e => e.Name);

        public SortTypeCategories(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Category> OrderBy(IQueryable<Category> query, bool asc);
        public abstract IOrderedQueryable<Category> ThenBy(IOrderedQueryable<Category> query, bool asc);

        public override string ToString()
        {
            return base.Name;
        }

        private sealed class SortType<TKey> : SortTypeCategories
        {
            private readonly Expression<Func<Category, TKey>> _expression;

            public SortType(string name, int value, Expression<Func<Category, TKey>> expression)
                : base(name, value)
            {
                _expression = expression;
            }

            public override IOrderedQueryable<Category> OrderBy(IQueryable<Category> query, bool asc)
                => asc ? query.OrderBy(_expression) : query.OrderByDescending(_expression);

            public override IOrderedQueryable<Category> ThenBy(IOrderedQueryable<Category> query, bool asc)
                => asc ? query.ThenBy(_expression) : query.ThenByDescending(_expression);
        }
    }
}
