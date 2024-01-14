using TestTask.Core.Models.Companies;

namespace TestTask.BindingItem.Pages.Companies
{
    public abstract class SortCompanyModel : CompanySortType
    {
        public SortCompanyModel(string name, int value)
        : base(name, value)
        {
        }

        public SortCompanyModel(string name, int value, bool isSelectField)
            : this(name, value)
        {
            IsSelectField = isSelectField;
        }

        public bool IsSelectField { get; set; } = false;
    }
}
