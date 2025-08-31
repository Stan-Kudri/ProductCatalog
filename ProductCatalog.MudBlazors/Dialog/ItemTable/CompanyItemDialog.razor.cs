using Microsoft.AspNetCore.Components;
using MudBlazor;
using ProductCatalog.Core;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.MudBlazors.Extension;
using ProductCatalog.MudBlazors.Model.TableComponent;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Dialog.ItemTable
{
    public partial class CompanyItemDialog : IItemDialog
    {
        [CascadingParameter] IMudDialogInstance MudDialog { get; set; } = null!;
        [Inject] private CompanyService CompanyService { get; set; } = null!;
        [Inject] private IMessageBox MessageDialog { get; set; } = null!;

        private CompanyModel CompanyModel { get; set; } = new CompanyModel();
        private string[] errors = [];
        private bool isAddItem = true;

        private Company? oldCompany;

        [Parameter] public Guid? Id { get; set; } = null;

        protected override async void OnInitialized()
        {
            if (Id == null)
            {
                isAddItem = true;
                return;
            }

            isAddItem = false;
            oldCompany = await CompanyService.GetItem((Guid)Id);
            CompanyModel = oldCompany.GetCompanyModel();
        }

        private void Close() => MudDialog.Cancel();

        private async Task Add()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!ValidateFields(out var message))
            {
                await MessageDialog.ShowWarning(message);
                return;
            }

            if (!await CompanyService.IsFreeName(CompanyModel.Name))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            var company = CompanyModel.GetCompany();
            await CompanyService.AddAsync(company);

            MudDialog.Close();
        }

        private void ClearData() => CompanyModel.ClearData();

        private async Task Updata()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!ValidateFields(out var message))
            {
                await MessageDialog.ShowWarning(message);
                return;
            }

            var company = CompanyModel.GetModifyCompany(oldCompany.Id);

            if (!await CompanyService.IsFreeNameItemUpsert(company))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            if (!oldCompany.Equals(company))
            {
                await CompanyService.UpdataAsync(company);
            }

            MudDialog.Close();
        }

        private void RecoverPastData() => CompanyModel = oldCompany.GetCompanyModel();

        private IEnumerable<string> ValidFormatText(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                yield return "Field is required.";
            }
        }

        private bool ValidateFields(out string message)
        {
            message = string.Empty;

            if (CompanyModel.Name == null || CompanyModel.Name == string.Empty)
            {
                message = "Name is required.";
                return false;
            }

            if (CompanyModel.DateCreation == null)
            {
                message = "The company creation date has not been selected.";
                return false;
            }

            return true;
        }
    }
}
