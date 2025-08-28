using ProductCatalog.Core.Models.Companies;

namespace ProductCatalog.BindingItem.Pages.Sort
{
    public class SortCompanyModel : CommonSortModel<Company>
    {
        public SortCompanyModel() : base(new SortCompany())
        {
        }
    }
}
