using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.WinForms.BindingItem.Pages.Sort
{
    public class SortCategoryModel : CommonSortModel<Category>
    {
        public SortCategoryModel() : base(new SortCategories())
        {
        }
    }
}
