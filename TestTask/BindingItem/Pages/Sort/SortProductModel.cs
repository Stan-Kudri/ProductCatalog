using TestTask.Core.Models.Products;

namespace TestTask.BindingItem.Pages.Sort
{
    public class SortProductModel : CommonSortModel<Product>
    {
        public SortProductModel() : base(new SortProduct())
        {
        }
    }
}
