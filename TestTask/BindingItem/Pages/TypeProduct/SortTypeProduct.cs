using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestTask.Core.Models.Types;

namespace TestTask.BindingItem.Pages.TypeProduct
{
    public class SortTypeProduct : ModelBase
    {
        public const string IdSort = "Id";
        private const bool IsSortAscending = true;

        private string _sortField;

        private static Dictionary<string, TypeListViewField> _sortMapField = new Dictionary<string, TypeListViewField>()
        {
            { "Id", TypeListViewField.ID },
            { "Name", TypeListViewField.Name },
            { "Category", TypeListViewField.Category },
        };

        public SortTypeProduct()
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

        public IQueryable<ProductType> Apply(IQueryable<ProductType> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            if (_sortMapField.TryGetValue(_sortField, out var field))
            {
                switch (field)
                {
                    case TypeListViewField.ID:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Id)
                            : items.OrderByDescending(e => e.Id);
                    case TypeListViewField.Name:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Name)
                            : items.OrderByDescending(e => e.Name);
                    case TypeListViewField.Category:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Category.Name)
                            : items.OrderByDescending(e => e.Category.Name);
                }
            }

            return items;
        }
    }
}
