using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Categories
{
    public class SortCategories
    {
        public const string IdSort = "Id";

        private const bool IsSortAscending = true;

        protected string _sortField;

        private static Dictionary<string, CategoryField> _sortMapField = new Dictionary<string, CategoryField>()
        {
            { "Id", CategoryField.ID },
            { "Name", CategoryField.Name },
        };

        public SortCategories()
        {
            foreach (var item in _sortMapField.Keys)
            {
                Items.Add(item);
            }

            _sortField = Items[0];
        }

        public virtual string SortField
        {
            get => _sortField;
            set => _sortField = value;
        }

        public ObservableCollection<string> Items = new ObservableCollection<string>();

        public IQueryable<Category> Apply(IQueryable<Category> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            if (_sortMapField.TryGetValue(_sortField, out var field))
            {
                switch (field)
                {
                    case CategoryField.ID:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Id)
                            : items.OrderByDescending(e => e.Id);
                    case CategoryField.Name:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Name)
                            : items.OrderByDescending(e => e.Name);
                }
            }

            return items;
        }
    }
}
