using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestTask.Core.Models.Types;

namespace TestTask.BindingItem.Pages.TypeProduct
{
    public class SortTypeProduct : ModelBase
    {
        public const string NoSorting = "No Sorting";

        private string _sortField;

        private static Dictionary<string, TypeListViewField> _sortMapField = new Dictionary<string, TypeListViewField>()
        {
            { "Id", TypeListViewField.ID },
            { "Name", TypeListViewField.Name },
            { "Category", TypeListViewField.Category },
        };

        public SortTypeProduct()
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

        public IQueryable<ProductType> Apply(IQueryable<ProductType> items)
        {
            if (_sortMapField.TryGetValue(_sortField, out var field))
            {
                switch (field)
                {
                    case TypeListViewField.ID:
                        return items.OrderBy(e => e.Id);
                    case TypeListViewField.Name:
                        return items.OrderBy(e => e.Name);
                    case TypeListViewField.Category:
                        return items.OrderBy(e => e.Category.Name);
                    default:
                        return items;
                }
            }

            return items;
        }
    }
}
