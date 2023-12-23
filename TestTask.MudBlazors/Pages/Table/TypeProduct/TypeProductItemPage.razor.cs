using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;
using TestTask.MudBlazors.Model.TableComponent;

namespace TestTask.MudBlazors.Pages.Table.TypeProduct
{
    public partial class TypeProductItemPage
    {
        [Inject] private ProductTypeService ProductTypeService { get; set; } = null!;
        [Inject] private CategoryService CategoryService { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;

        private TypeProductModel typeProductModel { get; set; } = new TypeProductModel();
        private string[] errors = { };
        private bool isAddItem = true;

        private ProductType? oldTypeProduct;

        private List<Category> selectCategories = new List<Category>();

        [Parameter] public int? Id { get; set; } = null;

        protected override void OnInitialized()
        {
            selectCategories = CategoryService.GetAll();

            if (Id == null)
            {
                isAddItem = true;
                return;
            }

            if (Id <= 0)
            {
                NavigationInTypeProductTable();
            }

            isAddItem = false;
            oldTypeProduct = ProductTypeService.GetItem((int)Id);
            typeProductModel = oldTypeProduct.GetTypeProductModel();
        }

        private void Close() => NavigationInTypeProductTable();

        //Methods for add item type product
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

            if (!ProductTypeService.IsFreeName(typeProductModel.Name))
            {
                ShowMessageWarning("Name is not free.");
                return;
            }

            var typeProduct = typeProductModel.GetProductType();
            ProductTypeService.Add(typeProduct);
            NavigationInTypeProductTable();
        }

        private void ClearData() => typeProductModel.ClearData();

        //Methods for edit item type product
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

            var typeProduct = typeProductModel.GetModifyType(oldTypeProduct.Id);

            if (!oldTypeProduct.Equals(typeProduct))
            {
                ProductTypeService.Updata(typeProduct);
            }

            NavigationInTypeProductTable();
        }

        private void RecoverPastData() => typeProductModel = oldTypeProduct.GetTypeProductModel();

        private IEnumerable<string> ValidFormatText(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                yield return "Field is required.";
            }
        }

        private void NavigationInTypeProductTable() => Navigation.NavigateTo($"/table/{TabTable.TypeProduct.ActiveTabIndex}");

        private async void ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");

        private bool CheckTheCompletionFields(out string message)
        {
            message = string.Empty;

            if (typeProductModel.Name == null || typeProductModel.Name == string.Empty)
            {
                message = "Name is required.";
                return false;
            }

            if (typeProductModel.Category == null)
            {
                message = "Category not selected.";
                return false;
            }

            return true;
        }
    }
}
