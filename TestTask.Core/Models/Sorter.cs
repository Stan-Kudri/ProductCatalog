using System.Collections.Generic;
using System.Linq;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Models
{
    public sealed class Sorter<T, TEnum>
        where TEnum : ISortableSmartEnum<T>
    {
        private readonly TEnum _defaultValue;

        public Sorter(TEnum defaultValue)
        {
            _defaultValue = defaultValue;
        }

        public IQueryable<T> Apply(IQueryable<T> items, IEnumerable<TEnum> sortFields, bool? ascending = true)
        {
            if (ascending == null)
            {
                return items;
            }

            var asc = ascending.Value;
            var actualSortFields = sortFields.ToList();
            if (actualSortFields.Count == 0)
            {
                actualSortFields.Add(_defaultValue);
            }

            var query = actualSortFields[0].OrderBy(items, asc);
            foreach (var item in actualSortFields.Skip(1))
            {
                query = item.ThenBy(query, asc);
            }

            return query;
        }
    }
}
