using System.Linq;
using TestTask.Core.Models.Categories;

namespace TestTask.Control.CategoryCantrol
{
    public class SortCategory
    {
        private bool IsAscending = true;

        public SortCategory(bool isAscending = true) => IsAscending = isAscending;

        public IQueryable<Category> Apply(IQueryable<Category> items)
        {
            if (IsAscending)
            {
                return items.OrderBy(e => e.Name).Select(e => e);
            }

            return items.OrderByDescending(e => e.Name).Select(e => e);
        }
    }
}
