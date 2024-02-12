using TestTask.Core.Models.Types;

namespace TestTask.BindingItem.Pages.Sort
{
    public class SortTypeProductModel : CommonSortModel<ProductType>
    {
        public SortTypeProductModel() : base(new SortProductType())
        {
        }
    }
}
