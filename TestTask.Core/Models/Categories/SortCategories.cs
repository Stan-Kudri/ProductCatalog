using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Categories
{
    public class SortCategories
    {
        private IEnumerable<SortTypeCategories> _sortFields = new HashSet<SortTypeCategories>() { SortTypeCategories.Id };

        public SortTypeCategories sortType { get; set; }

        public SortCategories()
        {

        }

        public virtual IEnumerable<SortTypeCategories> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }
        public ObservableCollection<SortTypeCategories> Items { get; set; } = new ObservableCollection<SortTypeCategories>(SortTypeCategories.List);

        public IQueryable<Category> Apply(IQueryable<Category> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            if (SortFields.Contains(SortTypeCategories.Id))
            {
                IOrderedQueryable<Category> query = SortTypeCategories.Id.OrderBy(items, (bool)isSortAscending);

                return SortFields.Contains(SortTypeCategories.Name)
                        ? SortTypeCategories.Name.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            else if (SortFields.Contains(SortTypeCategories.Name))
            {
                return SortTypeCategories.Name.OrderBy(items, (bool)isSortAscending);
            }

            return items;
        }

        public void Clear() => _sortFields = new HashSet<SortTypeCategories>();
    }
}
