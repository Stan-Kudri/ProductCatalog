using System;
using System.Linq;
using System.Linq.Expressions;

namespace TestTask.Core.Models.SortModel
{
    public class SortableField<T, TKey>
        : ISortableField<T> where T : Entity
    {
        private readonly Expression<Func<T, TKey>> _expression;

        public SortableField(Expression<Func<T, TKey>> expression)
            => _expression = expression;

        public IOrderedQueryable<T> OrderBy(IQueryable<T> query, bool asc)
                => asc ? query.OrderBy(_expression) : query.OrderByDescending(_expression);
        public IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> query, bool asc)
                => asc ? query.ThenBy(_expression) : query.ThenByDescending(_expression);
    }
}
