using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model.TableComponent;

namespace TestTask.MudBlazors.Pages.Table.TypeProduct
{
    public partial class TypeProductItemPage
    {
        [Inject] ProductTypeService? ProductTypeService { get; set; }
        [Inject] CategoryService? CategoryService { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] NavigationManager? Navigation { get; set; }

        private TypeProductModel typeProductModel { get; set; } = new TypeProductModel();
        private string[] errors = { };
        private bool IsAddItem = true;

        private ProductType oldTypeProduct;

        private List<Category> selectCategories = new List<Category>();

        [Parameter] public int? idProductType { get; set; } = null;

        protected override void OnInitialized()
        {
            selectCategories = CategoryService.GetAll();

            if (idProductType == null)
            {
                IsAddItem = true;
                return;
            }

            if (idProductType <= 0)
            {
                NavigationInTypeProductTable();
            }

            IsAddItem = false;
            oldTypeProduct = ProductTypeService.GetItem((int)idProductType);
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

        private IEnumerable<string> ValidSelectCategory(Category? category)
        {
            if (category == null)
            {
                yield return "Field is required.";
            }
        }

        private void NavigationInTypeProductTable() => Navigation.NavigateTo("/typeproduct");

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

            if (!ProductTypeService.IsFreeName(typeProductModel.Name))
            {
                message = "Name is not free.";
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
