using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.BindingItem.Pages.Sort
{
    public class SortProductModel : CommonSortModel<Product>
    {
        public SortProductModel() : base(new SortProduct())
        {
        }
    }
}
