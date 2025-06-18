using TestTask.Core.Models.Companies;

namespace TestTask.BindingItem.Pages.Sort
{
    public class SortCompanyModel : CommonSortModel<Company>
    {
        public SortCompanyModel() : base(new SortCompany())
        {
        }
    }
}
