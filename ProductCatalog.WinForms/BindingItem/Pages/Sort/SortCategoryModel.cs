using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.BindingItem.Pages.Sort
{
    public class SortCategoryModel : CommonSortModel<Category>
    {
        public SortCategoryModel() : base(new SortCategories())
        {
        }
    }
}
