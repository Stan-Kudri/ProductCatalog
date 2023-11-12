using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestTask.Core.Models.Companies;

namespace TestTask.BindingItem.Pages.Companies
{
    public class SortCompanies : ModelBase
    {
        public const string NoSorting = "No Sorting";

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
            Items.Add(NoSorting);
            foreach (var item in _sortMapField.Keys)
            {
                Items.Add(item);
            }
            /*
            var field = Enum.GetValues(typeof(CompanyField)).Cast<CompanyField>();
            foreach (var item in field)
            {
                Items.Add(item.ToString());
            }
            */
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

        public IQueryable<Company> Apply(IQueryable<Company> items)
        {
            if (_sortMapField.TryGetValue(_sortField, out var field))
            {
                switch (field)
                {
                    case CompanyField.ID:
                        return items.OrderBy(e => e.Id);
                    case CompanyField.Name:
                        return items.OrderBy(e => e.Name);
                    case CompanyField.DateCreation:
                        return items.OrderBy(e => e.DateCreation);
                    case CompanyField.Country:
                        return items.OrderBy(e => e.Country);
                }
            }

            return items;
        }
    }
}
