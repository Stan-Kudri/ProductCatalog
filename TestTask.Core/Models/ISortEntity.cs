using Ardalis.SmartEnum;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models
{
    public interface ISortEntity<T>
        where T : Entity
    {
        ISortableSmartEnum<T> SortField { get; set; }

        IEnumerable<ISortableSmartEnum<T>> SortFields { get; set; }

        ObservableCollection<ISortableSmartEnum<T>> Items { get; set; }

        IQueryable<T> Apply(IQueryable<T> items, bool? ascending = true);

        void Clear() => SortFields = new HashSet<ISortableSmartEnum<T>>();
    }
}
