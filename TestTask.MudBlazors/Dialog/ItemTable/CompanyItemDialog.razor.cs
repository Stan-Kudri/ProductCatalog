using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Companies;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model.TableComponent;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Dialog.ItemTable
{
    public partial class CompanyItemDialog : IItemDialog
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; } = null!;
        [Inject] private CompanyRepository CompanyRepository { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;

        private CompanyModel companyModel { get; set; } = new CompanyModel();
        private string[] errors = { };
        private bool isAddItem = true;

        private Company? oldCompany;

        [Parameter] public int? Id { get; set; } = null;

        protected override void OnInitialized()
        {
            if (Id == null)
            {
                isAddItem = true;
                return;
            }

            if (Id <= 0)
            {
                throw new Exception("The ID value can't be less than zero.");
            }

            isAddItem = false;
            oldCompany = CompanyRepository.GetCompany((int)Id);
            companyModel = oldCompany.GetCompanyModel();
        }

        private void Close() => MudDialog.Cancel();

        //Methods for add item company
        private async Task Add()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!ValidateFields(out var message))
            {
                await ShowMessageWarning(message);
                return;
            }

            if (!CompanyRepository.IsFreeName(companyModel.Name))
            {
                await ShowMessageWarning("Name is not free.");
                return;
            }

            var company = companyModel.GetCompany();
            CompanyRepository.Add(company);

            MudDialog.Close();
        }

        private void ClearData() => companyModel.ClearData();

        //Methods for edit item company
        private async Task Updata()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!ValidateFields(out var message))
            {
                await ShowMessageWarning(message);
                return;
            }

            var company = companyModel.GetModifyCompany(oldCompany.Id);

            if (!CompanyRepository.IsFreeNameItemUpsert(company))
            {
                await ShowMessageWarning("Name is not free.");
                return;
            }

            if (!oldCompany.Equals(company))
            {
                CompanyRepository.Updata(company);
            }

            MudDialog.Close();
        }

        private void RecoverPastData() => companyModel = oldCompany.GetCompanyModel();

        private IEnumerable<string> ValidFormatText(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                yield return "Field is required.";
            }
        }

        private async Task ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");

        private bool ValidateFields(out string message)
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
