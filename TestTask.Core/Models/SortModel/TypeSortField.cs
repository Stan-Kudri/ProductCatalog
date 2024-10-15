using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestTask.Core.Models.SortModel
{
    public class TypeSortField
    {
        public const string NoSorting = "No Sorting";

        private const string Ascending = "Ascending";
        private const string Descending = "Descending";

        protected bool? _isAscending = true;

        private static Dictionary<string, bool?> _sortMap = new Dictionary<string, bool?>()
        {
            { NoSorting, null },
            { Ascending, true },
            { Descending, false }
        };

        public TypeSortField()
            : this(null)
        {
        }

        public TypeSortField(bool? isAscending) => _isAscending = isAscending;

        public string SortType
        {
            get
            {
                if (_isAscending == null)
                {
                    return NoSorting;
                }

                return _isAscending == true ? Ascending : Descending;
            }
        }

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>(_sortMap.Keys);

        public virtual bool? IsAscending
        {
            get => _isAscending;
            set => _isAscending = value;
        }

        public void SetSort(string type)
        {
            if (type == NoSorting)
            {
                IsAscending = null;
                return;
            }

            _isAscending = type == Ascending;
        }
    }
}
