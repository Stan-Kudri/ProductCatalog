using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Ardalis.SmartEnum;

namespace ProductCatalog.Core.Models.SortModel
{
    public class SortableSmartEnumField<TSmartEnum, T>(string name, int value, ISortableField<T> field)
        : SmartEnum<TSmartEnum>(name, value), ISortableField<T>, ISortableSmartEnumOperation<T>
        where TSmartEnum : SortableSmartEnumField<TSmartEnum, T>
        where T : Entity
    {
        private static readonly SortableSmartEnumField<TSmartEnum, T> Id = new("Id", 0, CreateField(e => e.Id));

        public static ISortableField<T> DefaultValue => Id;

        static IReadOnlyCollection<ISortableField<T>> ISortableSmartEnumOperation<T>.List => List;

        public IOrderedQueryable<T> OrderBy(IQueryable<T> query, bool asc) => field.OrderBy(query, asc);

        public IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> query, bool asc) => field.ThenBy(query, asc);

        protected static ISortableField<T> CreateField<TKey>(Expression<Func<T, TKey>> expression) => new SortableField<T, TKey>(expression);

        public override string ToString() => Name;
    }
}
