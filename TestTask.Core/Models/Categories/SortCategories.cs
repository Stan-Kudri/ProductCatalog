using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestTask.Core.Models.Companies;

namespace TestTask.Core.Models.Categories
{
    public class SortCategories
    {
        private IEnumerable<SortType> _sortFields = new HashSet<SortType>() { SortType.Id };

        public SortType sortType { get; set; }

        public SortCategories()
        {

        }

        public virtual IEnumerable<SortType> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }
        public ObservableCollection<SortType> Items { get; set; } = new ObservableCollection<SortType>(SortType.List);

        public IQueryable<Category> Apply(IQueryable<Category> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            if (SortFields.Contains(SortType.Id))
            {
                IOrderedQueryable<Category> query = SortType.Id.OrderBy(items, (bool)isSortAscending);

                return SortFields.Contains(SortType.Name)
                        ? SortType.Name.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            else if (SortFields.Contains(SortType.Name))
            {
                return SortType.Name.OrderBy(items, (bool)isSortAscending);
            }

            return items;
        }

        public void Clear() => _sortFields = new HashSet<SortType>();
    }
}
