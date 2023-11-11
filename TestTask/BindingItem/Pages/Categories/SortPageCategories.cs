using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestTask.BindingItem.Pages.Categories
{
    public class SortPageCategories : ModelBase
    {
        public const string NoSorting = "No Sorting";

        private const string Ascending = "Ascending";
        private const string Descending = "Descending";

        private bool? _isAscending = true;

        private static Dictionary<string, bool?> _sortMap = new Dictionary<string, bool?>() { { NoSorting, null }, { Ascending, true }, { Descending, false } };

        public SortPageCategories()
            : this(null)
        {
        }

        public SortPageCategories(bool? isAscending) => _isAscending = isAscending;

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

        public bool? IsAscending
        {
            get => _isAscending;
            set => SetField(ref _isAscending, value);
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
