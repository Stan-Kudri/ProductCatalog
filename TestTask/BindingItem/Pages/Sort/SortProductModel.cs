using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using TestTask.Core.Models.Products;

namespace TestTask.BindingItem.Pages.Sort
{
    public class SortProductModel : SortProduct
    {
        private event PropertyChangedEventHandler PropertyChanged;

        private string[] _selectField;

        public SortProductModel()
            => _selectField = Items.Select(e => e.ToString()).ToArray();

        public string[] SelectField => _selectField;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
            {
                return;
            }

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public override IEnumerable<ProductSortType> SortFields
        {
            get => _sortFields;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The result is not null.", nameof(value));
                }

                if (_sortFields == value)
                {
                    return;
                }

                _sortFields = value;
                OnPropertyChanged(nameof(_sortFields));
            }
        }
    }
}
