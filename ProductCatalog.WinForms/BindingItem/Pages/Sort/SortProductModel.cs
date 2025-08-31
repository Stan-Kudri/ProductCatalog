using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.WinForms.BindingItem.Pages.Sort
{
    public class SortProductModel : CommonSortModel<Product>
    {
        public SortProductModel() : base(new SortProduct())
        {
        }
    }
}
