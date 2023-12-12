using Ardalis.SmartEnum;
using System.Linq;

namespace TestTask.Core.Models.Categories
{
    public abstract class SortTypeCategories : SmartEnum<SortTypeCategories>
    {
        public static readonly SortTypeCategories Id = new IdSortType("Id", 0);
        public static readonly SortTypeCategories Name = new NameSortType("Name", 1);

        public SortTypeCategories(string name, int value)
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

    partial class IdSortType : SortTypeCategories
    {
        public IdSortType(string name, int value)
            : base(name, value)
        {

        }

        public override IOrderedQueryable<Category> OrderBy(IQueryable<Category> query, bool asc) => asc ? query.OrderBy(e => e.Id) : query.OrderByDescending(e => e.Id);
        public override IOrderedQueryable<Category> ThenBy(IOrderedQueryable<Category> query, bool asc) => asc ? query.ThenBy(e => e.Id) : query.ThenByDescending(e => e.Id);
    }

    partial class NameSortType : SortTypeCategories
    {
        public NameSortType(string name, int value)
            : base(name, value)
        {

        }

        public override IOrderedQueryable<Category> OrderBy(IQueryable<Category> query, bool asc) => asc ? query.OrderBy(e => e.Name) : query.OrderByDescending(e => e.Name);
        public override IOrderedQueryable<Category> ThenBy(IOrderedQueryable<Category> query, bool asc) => asc ? query.ThenBy(e => e.Name) : query.ThenByDescending(e => e.Name);
    }
}
