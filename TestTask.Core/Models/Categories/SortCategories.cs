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

        public IQueryable<Category> Apply(IQueryable<Category> items, bool? ascending = true)
        {
            var sorter = new Sorter<Category, SortTypeCategories>(SortTypeCategories.Id);
            return sorter.Apply(items, _sortFields, ascending);
        }

        public void Clear() => _sortFields = new HashSet<SortTypeCategories>();
    }
}
