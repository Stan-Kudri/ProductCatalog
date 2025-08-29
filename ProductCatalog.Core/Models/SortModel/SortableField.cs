using System;
using System.Linq;
using System.Linq.Expressions;

namespace ProductCatalog.Core.Models.SortModel
{
    public class SortableField<T, TKey>(Expression<Func<T, TKey>> expression)
        : ISortableField<T> where T : Entity
    {
        public IOrderedQueryable<T> OrderBy(IQueryable<T> query, bool asc)
                => asc ? query.OrderBy(expression) : query.OrderByDescending(expression);
        public IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> query, bool asc)
                => asc ? query.ThenBy(expression) : query.ThenByDescending(expression);
    }
}
