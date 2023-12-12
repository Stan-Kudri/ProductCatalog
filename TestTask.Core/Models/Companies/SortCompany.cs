using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestTask.Core.Models.Companies
{
    public class SortCompany
    {
        private IEnumerable<SortTypeCompany> _sortFields = new HashSet<SortTypeCompany>() { SortTypeCompany.Id };

        public SortTypeCompany sortType { get; set; }

        public SortCompany()
        {

        }

        public virtual IEnumerable<SortTypeCompany> SortFields
        {
            get => _sortFields;
            set => _sortFields = value;
        }
        public ObservableCollection<SortTypeCompany> Items { get; set; } = new ObservableCollection<SortTypeCompany>(SortTypeCompany.List);

        public IQueryable<Company> Apply(IQueryable<Company> items, bool? isSortAscending = true)
        {
            if (isSortAscending == null)
            {
                return items;
            }

            if (SortFields.Contains(SortTypeCompany.Id))
            {
                IOrderedQueryable<Company> query = SortTypeCompany.Id.OrderBy(items, (bool)isSortAscending);

                if (SortFields.Contains(SortTypeCompany.Name))
                {
                    query = SortTypeCompany.Name.ThenBy(query, (bool)isSortAscending);
                }

                if (SortFields.Contains(SortTypeCompany.Country))
                {
                    query = SortTypeCompany.Country.ThenBy(query, (bool)isSortAscending);
                }

                return SortFields.Contains(SortTypeCompany.DataCreate)
                        ? SortTypeCompany.DataCreate.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            else if (SortFields.Contains(SortTypeCompany.Name))
            {
                IOrderedQueryable<Company> query = SortTypeCompany.Name.OrderBy(items, (bool)isSortAscending);

                if (SortFields.Contains(SortTypeCompany.Country))
                {
                    query = SortTypeCompany.Country.ThenBy(query, (bool)isSortAscending);
                }

                return SortFields.Contains(SortTypeCompany.DataCreate)
                        ? SortTypeCompany.DataCreate.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            else if (SortFields.Contains(SortTypeCompany.Country))
            {
                IOrderedQueryable<Company> query = SortTypeCompany.Country.OrderBy(items, (bool)isSortAscending);

                return SortFields.Contains(SortTypeCompany.DataCreate)
                        ? SortTypeCompany.DataCreate.ThenBy(query, (bool)isSortAscending)
                        : query;
            }

            else if (SortFields.Contains(SortTypeCompany.DataCreate))
            {
                return SortFields.Contains(SortTypeCompany.DataCreate)
                        ? SortTypeCompany.DataCreate.OrderBy(items, (bool)isSortAscending)
                        : items;
            }

            return items;
        }

        public void Clear() => _sortFields = new HashSet<SortTypeCompany>();
    }
}
