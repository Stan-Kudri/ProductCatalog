using Ardalis.SmartEnum;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.SortModel
{
    public class SortEntity<T, TSortField> : ISortEntity<T>
        where TSortField : SmartEnum<TSortField>, ISortableField<T>, ISortableSmartEnumOperation<T>
        where T : Entity
    {
        public ISortableField<T> SortField { get; set; }

        public IEnumerable<ISortableField<T>> SortFields { get; set; } = new HashSet<ISortableField<T>>() { TSortField.DefaultValue };

        public ObservableCollection<ISortableField<T>> Items { get; set; } = new ObservableCollection<ISortableField<T>>(TSortField.List);

        public IQueryable<T> Apply(IQueryable<T> items, bool? ascending = true)
        {
            var sorter = new Sorter<T>(TSortField.DefaultValue);
            return sorter.Apply(items, SortFields, ascending);
        }
    }
}
