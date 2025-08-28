using Microsoft.AspNetCore.Components;
using MudBlazor;
using ProductCatalog.Core;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.MudBlazors.Extension;
using ProductCatalog.MudBlazors.Model.TableComponent;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Dialog.ItemTable
{
    public partial class CategoryItemDialog : IItemDialog
    {
        private const string ErrorFieldRequired = "Field is required.";

        [CascadingParameter] IMudDialogInstance MudDialog { get; set; } = null!;
        [Inject] private CategoryService CategoryService { get; set; } = null!;
        [Inject] private IMessageBox MessageDialog { get; set; } = null!;

        private CategoryModel categoryModel { get; set; } = new CategoryModel();
        private string[] errors = [];
        private bool isAddItem = true;

        private Category? oldItem;

        [Parameter] public Guid? Id { get; set; } = null;

        protected override async void OnInitialized()
        {
            if (Id == null)
            {
                isAddItem = true;
                return;
            }

            isAddItem = false;
            oldItem = await CategoryService.GetItem((Guid)Id);
            categoryModel = oldItem.GetCategoryModel();
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

            if (!await CategoryService.IsFreeName(categoryModel.Name))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            var item = categoryModel.GetCategory();
            await CategoryService.AddAsync(item);

            MudDialog.Close();
        }

        private void ClearData() => categoryModel.ClearData();

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

            var item = categoryModel.GetModifyCategory(oldItem.Id);

            if (!await CategoryService.IsFreeNameItemUpsert(item))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            if (!oldItem.Equals(item))
            {
                await CategoryService.UpdataAsync(item);
            }

            MudDialog.Close();
        }

        private void RecoverPastData() => categoryModel = oldItem.GetCategoryModel();

        private IEnumerable<string> ValidFormatText(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                yield return ErrorFieldRequired;
            }
        }

        private bool ValidateFields(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrWhiteSpace(categoryModel.Name))
            {
                message = "Name is required.";
                return false;
            }

            return true;
        }
    }
}
