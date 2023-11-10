using System.Linq;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Models.Page.Categories
{
    public class SortCategory
    {
        private bool IsAscending = true;

        public SortCategory(bool isAscending = true) => IsAscending = isAscending;

        public IQueryable<Category> Apply(IQueryable<Category> items)
            => IsAscending ?
            items.OrderBy(e => e.Name).Select(e => e) :
            items.OrderByDescending(e => e.Name).Select(e => e);
    }
}
