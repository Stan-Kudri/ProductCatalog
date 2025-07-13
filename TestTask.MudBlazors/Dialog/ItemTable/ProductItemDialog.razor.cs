using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model.TableComponent;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Dialog.ItemTable
{
    public partial class ProductItemDialog : IItemDialog
    {
        [CascadingParameter] IMudDialogInstance MudDialog { get; set; } = null!;
        [Inject] private ProductRepository ProductRepository { get; set; } = null!;
        [Inject] private CompanyRepository CompanyRepository { get; set; } = null!;
        [Inject] private CategoryRepository CategoryRepository { get; set; } = null!;
        [Inject] private ProductTypeRepository ProductTypeRepository { get; set; } = null!;
        [Inject] private IMessageBox MessageDialog { get; set; } = null!;

        private ProductModel productModel { get; set; } = new ProductModel();

        private const string MessageFieldRequired = "Field is required.";

        private string[] errors = [];
        private bool isAddItem = true;
        private bool isDisabledType = true;

        private Product _oldProduct = null!;

        private List<Company> selectCompanies = new List<Company>();
        private List<Category> selectCategories = new List<Category>();
        private List<ProductType> selectTypes = new List<ProductType>();

        [Parameter] public int? Id { get; set; } = null;

        protected override async void OnInitialized()
        {
            selectCompanies = await CompanyRepository.GetAll();
            selectCategories = await CategoryRepository.GetAll();

            if (Id == null)
            {
                isAddItem = true;
                return;
            }

            BusinessLogicException.EnsureIdLessThenZero(Id);

            isAddItem = isDisabledType = false;
            _oldProduct = await ProductRepository.GetItem((int)Id);
            selectTypes = ProductTypeRepository.GetListTypesByCategory(_oldProduct.CategoryId);
            productModel = _oldProduct.GetProductModel();
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

            if (!await ProductRepository.IsFreeName(productModel.Name))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            var product = productModel.GetProductType();
            await ProductRepository.AddAsync(product);

            MudDialog.Close();
        }

        private void ClearData() => productModel.ClearData();

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

            var product = productModel.GetModifyType(_oldProduct.Id);

            if (!await ProductRepository.IsFreeNameItemUpsert(product))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            if (!_oldProduct.Equals(product))
            {
                await ProductRepository.UpdataAsync(product);
            }

            MudDialog.Close();
        }

        private void RecoverPastData() => productModel = _oldProduct.GetProductModel();

        private void ChangeValueCategory(Category? item)
        {
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
            productModel.Category = item;
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.

            selectTypes = ProductTypeRepository.GetListTypesByCategory(productModel.Category.Id);
            productModel.Category.Types = selectTypes;

            if (productModel.Category == null || productModel.Category.Types == null)
            {
                isDisabledType = true;
                return;
            }

            isDisabledType = false;
        }

        private IEnumerable<string> ValidFormatText(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                yield return MessageFieldRequired;
            }
        }

        private IEnumerable<string> ValidFormatPrice(string str)
        {
            if (!decimal.TryParse(str, out var value))
            {
                yield return MessageFieldRequired;
            }
        }

        private bool ValidateFields(out string message)
        {
            message = string.Empty;

            if (productModel.Name == null || productModel.Name == string.Empty)
            {
                message = "Name is required.";
                return false;
            }

            if (productModel.Price <= 0)
            {
                message = "Price is required";
                return false;
            }

            if (productModel.Company == null)
            {
                message = "Company not selected.";
                return false;
            }

            if (productModel.Category == null)
            {
                message = "Category not selected.";
                return false;
            }

            if (productModel.ProductType == null)
            {
                message = "Product Type not selected.";
                return false;
            }

            return true;
        }
    }
}
