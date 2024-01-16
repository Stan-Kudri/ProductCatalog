using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Products
{
    public class SortProduct : ISortEntity<Product, ProductSortType>
    {
        protected IEnumerable<ProductSortType> _sortFields = new HashSet<ProductSortType>() { ProductSortType.Id };

        public ProductSortType sortType { get; set; }

        public SortProduct()
        {
        }

        public virtual IEnumerable<ProductSortType> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }

        public ObservableCollection<ProductSortType> Items { get; set; } = new ObservableCollection<ProductSortType>(ProductSortType.List);

        public IQueryable<Product> Apply(IQueryable<Product> items, bool? ascending = true)
        {
            var sorter = new Sorter<Product, ProductSortType>(ProductSortType.Id);
            return sorter.Apply(items, _sortFields, ascending);
        }

        public void Clear() => _sortFields = new HashSet<ProductSortType>();
    }
}
