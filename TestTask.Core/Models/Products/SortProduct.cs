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

            if (SortFields.Contains(SortFieldProduct.Id))
            {
                IOrderedQueryable<Product> query = SortFieldProduct.Id.OrderBy(items, (bool)isSortAscending);

                if (SortFields.Contains(SortFieldProduct.Name))
                {
                    query = SortFieldProduct.Name.ThenBy(query, (bool)isSortAscending);
                }

                if (SortFields.Contains(SortFieldProduct.Category))
                {
                    query = SortFieldProduct.Category.ThenBy(query, (bool)isSortAscending);
                }

                if (SortFields.Contains(SortFieldProduct.Category))
                {
                    query = SortFieldProduct.Category.ThenBy(query, (bool)isSortAscending);
                }

                if (SortFields.Contains(SortFieldProduct.ProductType))
                {
                    query = SortFieldProduct.ProductType.ThenBy(query, (bool)isSortAscending);
                }

                return SortFields.Contains(SortFieldProduct.Price)
                        ? SortFieldProduct.Price.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            if (SortFields.Contains(SortFieldProduct.Name))
            {
                IOrderedQueryable<Product> query = SortFieldProduct.Name.OrderBy(items, (bool)isSortAscending);

                if (SortFields.Contains(SortFieldProduct.Category))
                {
                    query = SortFieldProduct.Category.ThenBy(query, (bool)isSortAscending);
                }

                if (SortFields.Contains(SortFieldProduct.Category))
                {
                    query = SortFieldProduct.Category.ThenBy(query, (bool)isSortAscending);
                }

                if (SortFields.Contains(SortFieldProduct.ProductType))
                {
                    query = SortFieldProduct.ProductType.ThenBy(query, (bool)isSortAscending);
                }

                return SortFields.Contains(SortFieldProduct.Price)
                        ? SortFieldProduct.Price.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            if (SortFields.Contains(SortFieldProduct.Category))
            {
                IOrderedQueryable<Product> query = SortFieldProduct.Category.OrderBy(items, (bool)isSortAscending);

                if (SortFields.Contains(SortFieldProduct.Category))
                {
                    query = SortFieldProduct.Category.ThenBy(query, (bool)isSortAscending);
                }

                if (SortFields.Contains(SortFieldProduct.ProductType))
                {
                    query = SortFieldProduct.ProductType.ThenBy(query, (bool)isSortAscending);
                }

                return SortFields.Contains(SortFieldProduct.Price)
                        ? SortFieldProduct.Price.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            if (SortFields.Contains(SortFieldProduct.Category))
            {
                IOrderedQueryable<Product> query = SortFieldProduct.Category.OrderBy(items, (bool)isSortAscending);

                if (SortFields.Contains(SortFieldProduct.ProductType))
                {
                    query = SortFieldProduct.ProductType.ThenBy(query, (bool)isSortAscending);
                }

                return SortFields.Contains(SortFieldProduct.Price)
                        ? SortFieldProduct.Price.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            if (SortFields.Contains(SortFieldProduct.ProductType))
            {
                IOrderedQueryable<Product> query = SortFieldProduct.ProductType.OrderBy(items, (bool)isSortAscending);

                return SortFields.Contains(SortFieldProduct.Price)
                        ? SortFieldProduct.Price.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            if (SortFields.Contains(SortFieldProduct.ProductType))
            {
                return SortFields.Contains(SortFieldProduct.Price)
                        ? SortFieldProduct.Price.OrderBy(items, (bool)isSortAscending)
                        : items;
            }

            return items;
        }

        public void Clear() => _sortFields = new HashSet<SortFieldProduct>();
    }
}
