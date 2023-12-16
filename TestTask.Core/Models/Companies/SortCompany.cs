using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Companies
{
    public class SortCompany
    {
        private IEnumerable<SortTypeCompany> _sortFields = new HashSet<SortTypeCompany>() { SortTypeCompany.Id };

        public SortTypeCompany sortType { get; set; }

        public SortCompany()
        {

        }

        public virtual IEnumerable<SortTypeCompany> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }
        public ObservableCollection<SortTypeCompany> Items { get; set; } = new ObservableCollection<SortTypeCompany>(SortTypeCompany.List);

        public IQueryable<Company> Apply(IQueryable<Company> items, bool? ascending = true)
        {
            var sorter = new Sorter<Company, SortTypeCompany>(SortTypeCompany.Id);
            return sorter.Apply(items, _sortFields, ascending);
        }

        public void Clear() => _sortFields = new HashSet<SortTypeCompany>();
    }
}
