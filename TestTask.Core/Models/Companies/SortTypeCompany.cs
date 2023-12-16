using Ardalis.SmartEnum;
using System;
using System.Linq;
using System.Linq.Expressions;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Models.Companies
{
    public abstract class SortTypeCompany : SmartEnum<SortTypeCompany>, ISortableSmartEnum<Company>
    {
        public static readonly SortTypeCompany Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly SortTypeCompany Name = new SortType<string>("Name", 1, e => e.Name);
        public static readonly SortTypeCompany Country = new SortType<string>("Country", 2, e => e.Country);
        public static readonly SortTypeCompany DataCreate = new SortType<DateTime>("DataCreate", 3, e => e.DateCreation);

        public SortTypeCompany(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Company> OrderBy(IQueryable<Company> query, bool asc);
        public abstract IOrderedQueryable<Company> ThenBy(IOrderedQueryable<Company> query, bool asc);

        public override string ToString() => base.Name;

        private sealed class SortType<TKey> : SortTypeCompany
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
