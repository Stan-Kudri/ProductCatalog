using Ardalis.SmartEnum;
using System.Linq;

namespace TestTask.Core.Models.Companies
{
    public abstract class SortTypeCompany : SmartEnum<SortTypeCompany>
    {
        public static readonly SortTypeCompany Id = new IdSortType("Id", 0);
        public static readonly SortTypeCompany Name = new NameSortType("Name", 1);
        public static readonly SortTypeCompany Country = new CountrySortType("Country", 2);
        public static readonly SortTypeCompany DataCreate = new DataCreatSortType("DataCreate", 3);

        public SortTypeCompany(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Company> OrderBy(IQueryable<Company> query, bool asc);
        public abstract IOrderedQueryable<Company> ThenBy(IOrderedQueryable<Company> query, bool asc);

        public override string ToString()
        {
            return base.Name;
        }
    }

    partial class IdSortType : SortTypeCompany
    {
        public IdSortType(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Company> OrderBy(IQueryable<Company> query, bool asc) => asc ? query.OrderBy(e => e.Id) : query.OrderByDescending(e => e.Id);
        public override IOrderedQueryable<Company> ThenBy(IOrderedQueryable<Company> query, bool asc) => asc ? query.ThenBy(e => e.Id) : query.ThenByDescending(e => e.Id);
    }

    partial class NameSortType : SortTypeCompany
    {
        public NameSortType(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Company> OrderBy(IQueryable<Company> query, bool asc) => asc ? query.OrderBy(e => e.Name) : query.OrderByDescending(e => e.Name);
        public override IOrderedQueryable<Company> ThenBy(IOrderedQueryable<Company> query, bool asc) => asc ? query.ThenBy(e => e.Name) : query.ThenByDescending(e => e.Name);
    }

    partial class CountrySortType : SortTypeCompany
    {
        public CountrySortType(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Company> OrderBy(IQueryable<Company> query, bool asc) => asc ? query.OrderBy(e => e.Country) : query.OrderByDescending(e => e.Country);
        public override IOrderedQueryable<Company> ThenBy(IOrderedQueryable<Company> query, bool asc) => asc ? query.ThenBy(e => e.Country) : query.ThenByDescending(e => e.Country);
    }

    partial class DataCreatSortType : SortTypeCompany
    {
        public DataCreatSortType(string name, int value)
            : base(name, value)
        {
        }

        public override IOrderedQueryable<Company> OrderBy(IQueryable<Company> query, bool asc) => asc ? query.OrderBy(e => e.DateCreation) : query.OrderByDescending(e => e.DateCreation);
        public override IOrderedQueryable<Company> ThenBy(IOrderedQueryable<Company> query, bool asc) => asc ? query.ThenBy(e => e.DateCreation) : query.ThenByDescending(e => e.DateCreation);
    }
}
