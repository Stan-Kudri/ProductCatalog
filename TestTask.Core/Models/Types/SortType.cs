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


            IOrderedQueryable<ProductType> query = null;

            if (SortFields.Contains(SortTypeProduct.Id))
            {
                query = SortTypeProduct.Id.OrderBy(items, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortTypeProduct.Name))
            {
                if (query == null)
                {
                    query = SortTypeProduct.Name.OrderBy(items, (bool)isSortAscending);
                }

                query = SortTypeProduct.Name.ThenBy(query, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortTypeProduct.Category))
            {
                if (query == null)
                {
                    query = SortTypeProduct.Category.OrderBy(items, (bool)isSortAscending);
                }

                query = SortTypeProduct.Category.ThenBy(query, (bool)isSortAscending);
            }

            return query == null ? items : query;
        }

        public void Clear() => _sortFields = new HashSet<SortTypeProduct>();
    }
}
