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

            IOrderedQueryable<Company> query = null;

            if (SortFields.Contains(SortTypeCompany.Id))
            {
                query = SortTypeCompany.Id.OrderBy(items, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortTypeCompany.Name))
            {
                if (query == null)
                {
                    query = SortTypeCompany.Name.OrderBy(items, (bool)isSortAscending);
                }

                query = SortTypeCompany.Name.ThenBy(query, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortTypeCompany.Country))
            {
                if (query == null)
                {
                    query = SortTypeCompany.Country.OrderBy(items, (bool)isSortAscending);
                }

                query = SortTypeCompany.Country.ThenBy(query, (bool)isSortAscending);
            }

            if (SortFields.Contains(SortTypeCompany.DataCreate))
            {
                if (query == null)
                {
                    query = SortTypeCompany.DataCreate.OrderBy(items, (bool)isSortAscending);
                }

                query = SortTypeCompany.DataCreate.ThenBy(query, (bool)isSortAscending);
            }

            return query == null ? items : query;
        }

        public void Clear() => _sortFields = new HashSet<SortTypeCompany>();
    }
}
