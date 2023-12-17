using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Companies;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;
using TestTask.MudBlazors.Model.TableComponent;

namespace TestTask.MudBlazors.Pages.Table.Companies
{
    public partial class CompanyItemPage
    {
        [Inject] CompanyService? CompanyService { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] NavigationManager? Navigation { get; set; }

        private CompanyModel companyModel { get; set; } = new CompanyModel();
        private string[] errors = { };
        private bool IsAddItem = true;

        private Company oldCompany;

        [Parameter] public int? Id { get; set; } = null;

        protected override void OnInitialized()
        {
            if (Id == null)
            {
                IsAddItem = true;
                return;
            }

            if (Id <= 0)
            {
                NavigationInCompanyTable();
            }

            IsAddItem = false;
            oldCompany = CompanyService.GetCompany((int)Id);
            companyModel = oldCompany.GetCompanyModel();
        }

        private void Close() => NavigationInCompanyTable();

        //Methods for add item company
        private async Task Add()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!CheckTheCompletionFields(out var message))
            {
                ShowMessageWarning(message);
                return;
            }



            if (!CompanyService.IsFreeName(companyModel.Name))
            {
                ShowMessageWarning("Name is not free.");
                return;
            }

            var company = companyModel.GetCompany();
            CompanyService.Add(company);
            NavigationInCompanyTable();
        }

        private void ClearData() => companyModel.ClearData();

        //Methods for edit item company
        private async Task Updata()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!CheckTheCompletionFields(out var message))
            {
                ShowMessageWarning(message);
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

        private void NavigationInCompanyTable() => Navigation.NavigateTo($"/table/{TabTable.Company.ActiveTabIndex}");

        private async void ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");

        private bool CheckTheCompletionFields(out string message)
        {
            message = string.Empty;

            if (companyModel.Name == null || companyModel.Name == string.Empty)
            {
                message = "Name is required.";
                return false;
            }

            if (companyModel.DateCreation == null)
            {
                message = "The company creation date has not been selected.";
                return false;
            }

            return true;
        }
    }
}
