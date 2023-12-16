using Ardalis.SmartEnum;
using System;
using System.Linq;
using System.Linq.Expressions;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Types;

namespace TestTask.Core.Models.Products
{
    public interface ISortableSmartEnum<T>
    {
        IOrderedQueryable<T> OrderBy(IQueryable<T> query, bool asc);
        IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> query, bool asc);
    }

    public abstract class SortFieldProduct : SmartEnum<SortFieldProduct>, ISortableSmartEnum<Product>
    {
        public static readonly SortFieldProduct Id = new SortType<int>("Id", 0, e => e.Id);
        public static readonly SortFieldProduct Name = new SortType<string>("Name", 1, e => e.Name);
        public static readonly SortFieldProduct Company = new SortType<Company>("Company", 2, e => e.Company);
        public static readonly SortFieldProduct Category = new SortType<Category>("Category", 3, e => e.Category);
        public static readonly SortFieldProduct ProductType = new SortType<ProductType>("Product Type", 4, e => e.Type);
        public static readonly SortFieldProduct Price = new SortType<decimal>("Price", 5, e => e.Price);

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

        private sealed class SortType<TKey> : SortFieldProduct
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
