using System;
using System.Linq;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Models.Page.Categories
{
    public class FilterCategoryName
    {
        public const string AllCategory = "All Item";

        private string _name;

        public FilterCategoryName()
            : this(AllCategory)
        {
        }

        public string Name => _name;

        public FilterCategoryName(string name) => _name = name != null ? _name = name : throw new ArgumentException("Unknown category name.");

        public IQueryable<Category> Apply(IQueryable<Category> item) => _name == AllCategory ? item.Select(e => e) : item.Where(e => e.Name == _name);
    }
}
