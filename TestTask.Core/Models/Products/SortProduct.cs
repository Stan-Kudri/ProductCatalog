using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Products
{
    public class SortProduct
    {
        private IEnumerable<SortFieldProduct> _sortFields = new HashSet<SortFieldProduct>() { SortFieldProduct.Id };

        public SortFieldProduct sortType { get; set; }

        public SortProduct()
        {
        }

        public virtual IEnumerable<SortFieldProduct> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }

        public ObservableCollection<SortFieldProduct> Items { get; set; } = new ObservableCollection<SortFieldProduct>(SortFieldProduct.List);

        public IQueryable<Product> Apply(IQueryable<Product> items, bool? ascending = true)
        {
            var sorter = new Sorter<Product, SortFieldProduct>(SortFieldProduct.Id);
            return sorter.Apply(items, _sortFields, ascending);
        }

        public void Clear() => _sortFields = new HashSet<SortFieldProduct>();
    }
}
