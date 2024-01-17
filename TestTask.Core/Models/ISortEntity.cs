using Ardalis.SmartEnum;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models
{
    public interface ISortEntity<T, TSortType>
        where TSortType : SmartEnum<TSortType>
        where T : Entity
    {
        static IEnumerable<TSortType> _sortFields;

        TSortType SortType { get; set; }

        virtual IEnumerable<TSortType> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }

        ObservableCollection<TSortType> Items { get; set; }

        IQueryable<T> Apply(IQueryable<T> items, bool? ascending = true);

        void Clear() => _sortFields = new HashSet<TSortType>();
    }
}
