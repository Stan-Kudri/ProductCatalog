using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TestTask.Core.Models.Categories
{
    public abstract class CategoriesSortField : SmartEnum<CategoriesSortField>, ISortableSmartEnum<Category>, ISortableSmartEnumOperation<Category>
    {
        public static readonly CategoriesSortField Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly CategoriesSortField Name = new SortType<string>("Name", 1, e => e.Name);

        static ISortableSmartEnum<Category> ISortableSmartEnumOperation<Category>.DefaultValue => Id;
        static IReadOnlyCollection<ISortableSmartEnum<Category>> ISortableSmartEnumOperation<Category>.List => List;

        public CategoriesSortField(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Category> OrderBy(IQueryable<Category> query, bool asc);
        public abstract IOrderedQueryable<Category> ThenBy(IOrderedQueryable<Category> query, bool asc);

        public override string ToString() => base.Name;

        private sealed class SortType<TKey> : CategoriesSortField
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
