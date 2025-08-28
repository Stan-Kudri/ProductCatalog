using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.BindingItem.Pages.Sort
{
    public class SortTypeProductModel : CommonSortModel<ProductType>
    {
        public SortTypeProductModel() : base(new SortProductType())
        {
        }
    }
}
