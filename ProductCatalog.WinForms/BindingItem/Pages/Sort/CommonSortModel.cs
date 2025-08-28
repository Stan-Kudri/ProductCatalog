using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ProductCatalog.Core.Models;
using ProductCatalog.Core.Models.SortModel;

namespace ProductCatalog.BindingItem.Pages.Sort
{
    public class CommonSortModel<T> : ISortEntity<T>
        where T : Entity
    {
        private event PropertyChangedEventHandler PropertyChanged;

        private readonly ISortEntity<T> _sortType;

        private readonly string[] _selectField;

        public CommonSortModel(ISortEntity<T> sortType)
        {
            _sortType = sortType;
            _selectField = Items.Select(e => e.ToString()).ToArray();
        }

        public string[] SelectField => _selectField;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
            {
                return;
            }

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public IQueryable<T> Apply(IQueryable<T> items, bool? ascending = true)
            => _sortType.Apply(items, ascending);

        public IEnumerable<ISortableField<T>> SortFields
        {
            get => _sortType.SortFields;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The result is not null.", nameof(value));
                }

                if (_sortType.SortFields == value)
                {
                    return;
                }

                _sortType.SortFields = value;
                OnPropertyChanged(nameof(_sortType.SortFields));
            }
        }

        public ISortableField<T> SortField
        {
            get => _sortType.SortField;
            set => _sortType.SortField = value;
        }

        public ObservableCollection<ISortableField<T>> Items
        {
            get => _sortType.Items;
            set => _sortType.Items = value;
        }
    }
}
