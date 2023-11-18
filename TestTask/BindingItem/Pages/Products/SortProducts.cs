using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestTask.Core.Models.Products;

namespace TestTask.BindingItem.Pages.Products
{
    public class SortProducts : ModelBase
    {
        public const string IdSort = "Id";
        private const bool IsSortAscending = true;

        private string _sortField;

        private static Dictionary<string, ProductSortListViewField> _sortMapField = new Dictionary<string, ProductSortListViewField>()
        {
            { "Id", ProductSortListViewField.ID },
            { "Name", ProductSortListViewField.Name },
            { "Company", ProductSortListViewField.Company },
            { "Category", ProductSortListViewField.Category },
            { "Type", ProductSortListViewField.Type },
            { "Price", ProductSortListViewField.Price },
        };

        public SortProducts()
        {
            foreach (var item in _sortMapField.Keys)
            {
                Items.Add(item);
            }

            _sortField = Items[0];
        }

        public string SortField
        {
            get => _sortField;
            set
            {
                if (!Items.Contains(value))
                {
                    throw new ArgumentException("The resulting string is not a sort element.", value);
                }

                SetField(ref _sortField, value);
            }
        }

        public ObservableCollection<string> Items = new ObservableCollection<string>();

        public IQueryable<Product> Apply(IQueryable<Product> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            if (_sortMapField.TryGetValue(_sortField, out var field))
            {
                switch (field)
                {
                    case ProductSortListViewField.ID:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Id)
                            : items.OrderByDescending(e => e.Id);
                    case ProductSortListViewField.Name:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Name)
                            : items.OrderByDescending(e => e.Name);
                    case ProductSortListViewField.Company:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Company.Name)
                            : items.OrderByDescending(e => e.Company.Name);
                    case ProductSortListViewField.Category:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Category.Name)
                            : items.OrderByDescending(e => e.Category.Name);
                    case ProductSortListViewField.Type:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Type)
                            : items.OrderByDescending(e => e.Type);
                    case ProductSortListViewField.Price:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Price)
                            : items.OrderByDescending(e => e.Price);
                }
            }

            return items;
        }
    }
}
