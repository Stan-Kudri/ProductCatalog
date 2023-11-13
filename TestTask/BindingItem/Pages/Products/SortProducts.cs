using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestTask.Core.Models.Products;

namespace TestTask.BindingItem.Pages.Products
{
    public class SortProducts : ModelBase
    {
        public const string NoSorting = "No Sorting";

        private string _sortField;

        private static Dictionary<string, ProductSortListViewField> _sortMapField = new Dictionary<string, ProductSortListViewField>()
        {
            { "Id", ProductSortListViewField.ID },
            { "Company", ProductSortListViewField.Company },
            { "Category", ProductSortListViewField.Category },
            { "Type", ProductSortListViewField.Type },
            { "Price", ProductSortListViewField.Price },
        };

        public SortProducts()
        {
            Items.Add(NoSorting);
            foreach (var item in _sortMapField.Keys)
            {
                Items.Add(item);
            }

            _sortField = NoSorting;
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

        public IQueryable<Product> Apply(IQueryable<Product> items)
        {
            if (_sortMapField.TryGetValue(_sortField, out var field))
            {
                switch (field)
                {
                    case ProductSortListViewField.ID:
                        return items.OrderBy(e => e.Id);
                    case ProductSortListViewField.Company:
                        return items.OrderBy(e => e.Company.Name);
                    case ProductSortListViewField.Category:
                        return items.OrderBy(e => e.Category.Name);
                    case ProductSortListViewField.Type:
                        return items.OrderBy(e => e.Type);
                    case ProductSortListViewField.Price:
                        return items.OrderBy(e => e.Price);
                    default:
                        return items;
                }
            }

            return items;
        }
    }
}
