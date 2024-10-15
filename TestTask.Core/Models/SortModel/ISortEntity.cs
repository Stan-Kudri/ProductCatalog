using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.SortModel
{
    public interface ISortEntity<T>
        where T : Entity
    {
        ISortableField<T> SortField { get; set; }

        IEnumerable<ISortableField<T>> SortFields { get; set; }

        ObservableCollection<ISortableField<T>> Items { get; set; }

        IQueryable<T> Apply(IQueryable<T> items, bool? ascending = true);

        void Clear() => SortFields = new HashSet<ISortableField<T>>();
    }
}
