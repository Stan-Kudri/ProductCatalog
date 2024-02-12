using Ardalis.SmartEnum;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models
{
    public class SortEntity<T, TSortField> : ISortEntity<T>
        where TSortField : SmartEnum<TSortField>, ISortableSmartEnum<T>, ISortableSmartEnumOperation<T>
        where T : Entity
    {
        public ISortableSmartEnum<T> SortField { get; set; }

        public IEnumerable<ISortableSmartEnum<T>> SortFields { get; set; } = new HashSet<ISortableSmartEnum<T>>() { TSortField.DefaultValue };

        public ObservableCollection<ISortableSmartEnum<T>> Items { get; set; } = new ObservableCollection<ISortableSmartEnum<T>>(TSortField.List);

        public IQueryable<T> Apply(IQueryable<T> items, bool? ascending = true)
        {
            var sorter = new Sorter<T>(TSortField.DefaultValue);
            return sorter.Apply(items, SortFields, ascending);
        }
    }
}
