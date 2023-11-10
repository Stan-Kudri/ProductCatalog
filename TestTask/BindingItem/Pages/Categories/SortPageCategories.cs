using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.Models.Page.Categories;

namespace TestTask.BindingItem.Pages.Categories
{
    public class SortPageCategories : ModelBase
    {
        private const string Ascending = "Ascending";
        private const string Descending = "Descending";

        private bool _isAscending = true;

        private static Dictionary<string, bool> _sortMap = new Dictionary<string, bool>() { { Ascending, true }, { Descending, false } };

        public SortPageCategories()
            : this(true)
        {
        }

        public SortPageCategories(bool isAscending) => _isAscending = isAscending;

        public string SortType => _isAscending == true ? Ascending : Descending;

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>(_sortMap.Keys);

        public bool IsAscending
        {
            get => _isAscending;
            set => SetField(ref _isAscending, value);
        }

        public void SetSort(string type) => _isAscending = type == Ascending;

        public SortCategory ToSortCategory() => new SortCategory(_isAscending);
    }
}
