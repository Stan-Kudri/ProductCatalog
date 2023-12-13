using System;
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

        public IQueryable<ProductType> Apply(IQueryable<ProductType> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            if (SortFields.Contains(SortTypeProduct.Id))
            {
                IOrderedQueryable<ProductType> query = SortTypeProduct.Id.OrderBy(items, (bool)isSortAscending);

                if (SortFields.Contains(SortTypeProduct.Name))
                {
                    query = SortTypeProduct.Name.ThenBy(query, (bool)isSortAscending);
                }

                return SortFields.Contains(SortTypeProduct.Category)
                        ? SortTypeProduct.Category.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            if (SortFields.Contains(SortTypeProduct.Name))
            {
                IOrderedQueryable<ProductType> query = SortTypeProduct.Name.OrderBy(items, (bool)isSortAscending);

                return SortFields.Contains(SortTypeProduct.Category)
                        ? SortTypeProduct.Category.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            if (SortFields.Contains(SortTypeProduct.Category))
            {
                return SortTypeProduct.Category.OrderBy(items, (bool)isSortAscending);
            }

            return items;
        }

        public void Clear() => _sortFields = new HashSet<SortTypeProduct>();
    }
}
