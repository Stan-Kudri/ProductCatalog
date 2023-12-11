using Microsoft.AspNetCore.Components;
using TestTask.Core.Models.Companies;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.Companies
{
    public partial class CompanyItemPage
    {
        [Inject] CompanyService? CompanyService { get; set; }
        [Inject] NavigationManager? Navigation { get; set; }

        private CompanyModel companyModel { get; set; } = new CompanyModel();
        private string[] errors = { };
        private bool IsAddItem = true;

        private Company oldCompany;

        [Parameter] public int? idCompany { get; set; } = null;

        protected override void OnInitialized()
        {
            if (idCompany == null)
            {
                IsAddItem = true;
                return;
            }

            if (idCompany <= 0)
            {
                NavigationInCompanyTable();
            }

            IsAddItem = false;
            oldCompany = CompanyService.GetCompany((int)idCompany);
            companyModel = oldCompany.GetCompanyModel();
        }

        private void Close() => NavigationInCompanyTable();

        //Methods for add item company
        private void Add()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!CompanyService.IsFreeName(companyModel.Name))
            {
                return;
            }

            var company = companyModel.GetCompany();
            CompanyService.Add(company);
            NavigationInCompanyTable();
        }

        private void ClearData() => companyModel.ClearData();

        //Methods for edit item company
        private void Updata()
        {
            if (errors.Length != 0)
            {
                return;
            }

            var company = companyModel.GetModifyCompany(oldCompany.Id);

            if (!oldCompany.Equals(company))
            {
                CompanyService.Updata(company);
            }

            NavigationInCompanyTable();
        }

        private void RecoverPastData() => companyModel = oldCompany.GetCompanyModel();

        private IEnumerable<string> ValidFormatText(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                yield return "Field is required.";
            }
        }

        private IEnumerable<string> ValidFormatDate(DateTime date)
        {
            if (date == null)
            {
                yield return "Date is required.";
                yield break;
            }

            if (date > DateTime.Now)
            {
                yield return "The creation date is not within the valid range.";
            }
        }

        private void NavigationInCompanyTable() => Navigation.NavigateTo("/company");
    }
}
