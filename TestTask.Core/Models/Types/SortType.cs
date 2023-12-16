using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Types
{
    public class SortType
    {
        private IEnumerable<SortTypeProduct> _sortFields = new HashSet<SortTypeProduct>() { SortTypeProduct.Id };

        public SortTypeProduct sortType { get; set; }

        public SortType()
        {
        }

        public virtual IEnumerable<SortTypeProduct> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }
        public ObservableCollection<SortTypeProduct> Items { get; set; } = new ObservableCollection<SortTypeProduct>(SortTypeProduct.List);

        public IQueryable<ProductType> Apply(IQueryable<ProductType> items, bool? ascending = true)
        {
            var sorter = new Sorter<ProductType, SortTypeProduct>(SortTypeProduct.Id);
            return sorter.Apply(items, _sortFields, ascending);
        }

        public void Clear() => _sortFields = new HashSet<SortTypeProduct>();
    }
}
