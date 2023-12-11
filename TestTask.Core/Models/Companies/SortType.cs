using Ardalis.SmartEnum;
using System.Linq;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Models.Companies
{
    public abstract class SortType : SmartEnum<SortType>
    {
        public static readonly SortType Id = new IdSortType("Id", 0);
        public static readonly SortType Name = new NameSortType("Name", 1);

        public SortType(string name, int value)
            : base(name, value)
        {
        }

        public abstract IOrderedQueryable<Category> OrderBy(IQueryable<Category> query, bool asc);
        public abstract IOrderedQueryable<Category> ThenBy(IOrderedQueryable<Category> query, bool asc);

        public override string ToString()
        {
            return base.Name;
        }
    }

    partial class IdSortType : SortType
    {
        public IdSortType(string name, int value)
            : base(name, value)
        {

        }

        public override IOrderedQueryable<Category> OrderBy(IQueryable<Category> query, bool asc) => asc ? query.OrderBy(e => e.Id) : query.OrderByDescending(e => e.Id);
        public override IOrderedQueryable<Category> ThenBy(IOrderedQueryable<Category> query, bool asc) => asc ? query.ThenBy(e => e.Id) : query.ThenByDescending(e => e.Id);
    }

    partial class NameSortType : SortType
    {
        public NameSortType(string name, int value)
            : base(name, value)
        {

        }

        public override IOrderedQueryable<Category> OrderBy(IQueryable<Category> query, bool asc) => asc ? query.OrderBy(e => e.Name) : query.OrderByDescending(e => e.Name);
        public override IOrderedQueryable<Category> ThenBy(IOrderedQueryable<Category> query, bool asc) => asc ? query.ThenBy(e => e.Name) : query.ThenByDescending(e => e.Name);
    }
}
