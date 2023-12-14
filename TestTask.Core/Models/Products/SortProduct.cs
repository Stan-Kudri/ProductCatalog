using System;
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

        public IQueryable<Product> Apply(IQueryable<Product> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            IOrderedQueryable<Product> query = null;

            if (SortFields.Contains(SortFieldProduct.Id))
            {
                query = SortFieldProduct.Id.OrderBy(items, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortFieldProduct.Name))
            {
                if (query == null)
                {
                    query = SortFieldProduct.Name.OrderBy(items, (bool)isSortAscending);
                }

                query = SortFieldProduct.Name.ThenBy(query, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortFieldProduct.Company))
            {
                if (query == null)
                {
                    query = SortFieldProduct.Company.OrderBy(items, (bool)isSortAscending);
                }

                query = SortFieldProduct.Company.ThenBy(query, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortFieldProduct.Category))
            {
                if (query == null)
                {
                    query = SortFieldProduct.Category.OrderBy(items, (bool)isSortAscending);
                }

                query = SortFieldProduct.Category.ThenBy(query, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortFieldProduct.ProductType))
            {
                if (query == null)
                {
                    query = SortFieldProduct.ProductType.OrderBy(items, (bool)isSortAscending);
                }

                query = SortFieldProduct.ProductType.ThenBy(query, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortFieldProduct.Price))
            {
                if (query == null)
                {
                    query = SortFieldProduct.Price.OrderBy(items, (bool)isSortAscending);
                }

                query = SortFieldProduct.Price.ThenBy(query, (bool)isSortAscending);
            }

            return query == null ? items : query;
        }

        public void Clear() => _sortFields = new HashSet<SortFieldProduct>();
    }
}
