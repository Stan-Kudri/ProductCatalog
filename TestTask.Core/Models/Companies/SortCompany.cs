using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Companies
{
    public class SortCompany : ISortEntity<Company, CompanySortType>
    {
        protected IEnumerable<CompanySortType> _sortFields = new HashSet<CompanySortType>() { CompanySortType.Id };

        public SortCompany()
        {
        }

        public CompanySortType sortType { get; set; }

        public virtual IEnumerable<CompanySortType> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }

        public ObservableCollection<CompanySortType> Items { get; set; } = new ObservableCollection<CompanySortType>(CompanySortType.List);

        public IQueryable<Company> Apply(IQueryable<Company> items, bool? ascending = true)
        {
            var sorter = new Sorter<Company, CompanySortType>(CompanySortType.Id);
            return sorter.Apply(items, _sortFields, ascending);
        }

        public void Clear() => _sortFields = new HashSet<CompanySortType>();
    }
}
