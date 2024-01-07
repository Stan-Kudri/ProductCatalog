using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Categories
{
    public class SortCategories : ISortEntity<Category, CategoriesSortType>
    {
        private IEnumerable<CategoriesSortType> _sortFields = new HashSet<CategoriesSortType>() { CategoriesSortType.Id };

        public CategoriesSortType sortType { get; set; }

        public SortCategories()
        {
        }

        public virtual IEnumerable<CategoriesSortType> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }
        public ObservableCollection<CategoriesSortType> Items { get; set; } = new ObservableCollection<CategoriesSortType>(CategoriesSortType.List);

        public IQueryable<Category> Apply(IQueryable<Category> items, bool? ascending = true)
        {
            var sorter = new Sorter<Category, CategoriesSortType>(CategoriesSortType.Id);
            return sorter.Apply(items, _sortFields, ascending);
        }

        public void Clear() => _sortFields = new HashSet<CategoriesSortType>();
    }
}
