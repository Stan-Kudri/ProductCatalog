using System;
using System.Collections.ObjectModel;
using TestTask.Control.CategoryCantrol;

namespace TestTask.BindingItem.Pages
{
    public class SortPageCategory : ModelBase
    {
        private bool _isAscending = true;

        public SortPageCategory(string sort = "Ascending")
        {
            if (sort == "Ascending")
            {
                _isAscending = true;
                return;
            }
            else if (sort == "Descending")
            {
                _isAscending = false;
                return;
            }

            throw new ArgumentException("Unknown sort.");
        }

        public bool IsAscending
        {
            get => _isAscending;
            set => SetField(ref _isAscending, value);
        }

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>() { "Ascending", "Descending" };

        public SortCategory ToSortCategory(bool isAscending) => new SortCategory(isAscending);
    }
}
