using System.Linq;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Models.Page.Categories
{
    public class SearchRequestCategory
    {
        public SearchRequestCategory()
            : this(new FilterCategoryName(), new SortCategory(), new Page())
        {
        }

        public SearchRequestCategory(FilterCategoryName filter, SortCategory sort, Page page)
        {
            Filter = filter;
            Sort = sort;
            Page = page;
        }

        public FilterCategoryName Filter { get; set; }

        public SortCategory Sort { get; set; }

        public Page Page { get; set; }

        public IQueryable<Category> ApplyFilter(IQueryable<Category> items) => Filter.Apply(items);

        public IQueryable<Category> ApplyOrderBy(IQueryable<Category> items) => Sort.Apply(items);

    }
}
