using TestTask.Core.Models.Categories;

namespace TestTask.BindingItem.Pages.Sort
{
    public class SortCategoryModel : CommonSortModel<Category>
    {
        public SortCategoryModel() : base(new SortCategories())
        {
        }
    }
}
