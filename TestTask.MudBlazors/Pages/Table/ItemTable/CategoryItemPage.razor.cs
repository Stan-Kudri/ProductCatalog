using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Categories;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;
using TestTask.MudBlazors.Model.TableComponent;

namespace TestTask.MudBlazors.Pages.Table.ItemTable
{
    public partial class CategoryItemPage
    {
        [Inject] private CategoryRepository CategoryRepository { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;

        private CategoryModel categoryModel { get; set; } = new CategoryModel();
        private string[] errors = { };
        private bool IsAddItem = true;

        private Category? oldItem;

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
            oldItem = CategoryRepository.GetCategory((int)Id);
            categoryModel = oldItem.GetCategoryModel();
        }

        private void Close() => NavigationInCompanyTable();

        //Methods for add item company
        private async Task Add()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!ValidateFields(out var message))
            {
                ShowMessageWarning(message);
                return;
            }

            if (!CategoryRepository.IsFreeName(categoryModel.Name))
            {
                ShowMessageWarning("Name is not free.");
                return;
            }

            var item = categoryModel.GetCategory();
            CategoryRepository.Add(item);
            NavigationInCompanyTable();
        }

        private void ClearData() => categoryModel.ClearData();

        //Methods for edit item company
        private async Task Updata()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!ValidateFields(out var message))
            {
                ShowMessageWarning(message);
                return;
            }

            var item = categoryModel.GetModifyCategory(oldItem.Id);

            if (!CategoryRepository.IsFreeNameItemUpsert(item))
            {
                ShowMessageWarning("Name is not free.");
                return;
            }

            if (!oldItem.Equals(item))
            {
                CategoryRepository.Updata(item);
            }

            NavigationInCompanyTable();
        }

        private void NavigationInCompanyTable() => Navigation.NavigateTo($"/table/{TabTable.Category.ActiveTabIndex}");

        private void RecoverPastData() => categoryModel = oldItem.GetCategoryModel();

        private async Task ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");

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

            if (string.IsNullOrWhiteSpace(categoryModel.Name))
            {
                message = "Name is required.";
                return false;
            }

            return true;
        }
    }
}
