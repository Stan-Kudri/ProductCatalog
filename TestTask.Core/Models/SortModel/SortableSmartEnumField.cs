using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TestTask.Core.Models.SortModel
{
    public class SortableSmartEnumField<TSmartEnum, T> : SmartEnum<TSmartEnum>, ISortableField<T>, ISortableSmartEnumOperation<T>
        where TSmartEnum : SortableSmartEnumField<TSmartEnum, T>
        where T : Entity
    {
        private static readonly SortableField<T, int> Id = new SortableField<T, int>(e => e.Id);

        private ISortableField<T> _field;

        public SortableSmartEnumField(string name, int value, ISortableField<T> field) : base(name, value)
        {
            _field = field;
        }

        public static ISortableField<T> DefaultValue => Id;

        static IReadOnlyCollection<ISortableField<T>> ISortableSmartEnumOperation<T>.List => List;

        public IOrderedQueryable<T> OrderBy(IQueryable<T> query, bool asc) => _field.OrderBy(query, asc);

        public IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> query, bool asc) => _field.ThenBy(query, asc);

        protected static ISortableField<T> CreateField<TKey>(Expression<Func<T, TKey>> expression) => new SortableField<T, TKey>(expression);

        public override string ToString() => Name;
    }
}
