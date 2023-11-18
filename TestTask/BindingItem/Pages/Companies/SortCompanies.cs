using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestTask.Core.Models.Companies;

namespace TestTask.BindingItem.Pages.Companies
{
    public class SortCompanies : ModelBase
    {
        public const string IdSort = "Id";
        private const bool IsSortAscending = true;

        private string _sortField;
        private static Dictionary<string, CompanyField> _sortMapField = new Dictionary<string, CompanyField>()
        {
            { "Id", CompanyField.ID },
            { "Name", CompanyField.Name },
            { "DateCreation", CompanyField.DateCreation },
            { "Country", CompanyField.Country },
        };

        public SortCompanies()
        {
            foreach (var item in _sortMapField.Keys)
            {
                Items.Add(item);
            }
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

        public IQueryable<Company> Apply(IQueryable<Company> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            if (_sortMapField.TryGetValue(_sortField, out var field))
            {
                switch (field)
                {
                    case CompanyField.ID:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Id)
                            : items.OrderByDescending(e => e.Id);
                    case CompanyField.Name:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Name)
                            : items.OrderByDescending(e => e.Name);
                    case CompanyField.DateCreation:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.DateCreation)
                            : items.OrderByDescending(e => e.DateCreation);
                    case CompanyField.Country:
                        return isSortAscending == IsSortAscending
                            ? items.OrderBy(e => e.Country)
                            : items.OrderByDescending(e => e.Country);
                }
            }

            return items;
        }
    }
}
