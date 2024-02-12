using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TestTask.Core.Models.Companies
{
    public abstract class CompanySortField : SmartEnum<CompanySortField>, ISortableSmartEnum<Company>, ISortableSmartEnumOperation<Company>
    {
        public static readonly CompanySortField Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly CompanySortField Name = new SortType<string>("Name", 1, e => e.Name);
        public static readonly CompanySortField Country = new SortType<string>("Country", 2, e => e.Country);
        public static readonly CompanySortField DataCreate = new SortType<DateTime>("DataCreate", 3, e => e.DateCreation);

        static ISortableSmartEnum<Company> ISortableSmartEnumOperation<Company>.DefaultValue => Id;
        static IReadOnlyCollection<ISortableSmartEnum<Company>> ISortableSmartEnumOperation<Company>.List => List;

        public CompanySortField(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Company> OrderBy(IQueryable<Company> query, bool asc);
        public abstract IOrderedQueryable<Company> ThenBy(IOrderedQueryable<Company> query, bool asc);

        public override string ToString() => base.Name;

        protected sealed class SortType<TKey> : CompanySortField
        {
            private readonly Expression<Func<Company, TKey>> _expression;

            public SortType(string name, int value, Expression<Func<Company, TKey>> expression)
                : base(name, value)
            {
                _expression = expression;
            }

            public override IOrderedQueryable<Company> OrderBy(IQueryable<Company> query, bool asc)
                => asc ? query.OrderBy(_expression) : query.OrderByDescending(_expression);

            public override IOrderedQueryable<Company> ThenBy(IOrderedQueryable<Company> query, bool asc)
                => asc ? query.ThenBy(_expression) : query.ThenByDescending(_expression);
        }
    }
}
