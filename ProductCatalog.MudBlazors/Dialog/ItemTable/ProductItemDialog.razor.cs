using Microsoft.AspNetCore.Components;
using MudBlazor;
using ProductCatalog.Core;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.MudBlazors.Extension;
using ProductCatalog.MudBlazors.Model.TableComponent;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Dialog.ItemTable
{
    public partial class ProductItemDialog : IItemDialog
    {
        [CascadingParameter] IMudDialogInstance MudDialog { get; set; } = null!;
        [Inject] private ProductService ProductService { get; set; } = null!;
        [Inject] private CompanyService CompanyService { get; set; } = null!;
        [Inject] private CategoryService CategoryService { get; set; } = null!;
        [Inject] private ProductTypeService ProductTypeService { get; set; } = null!;
        [Inject] private IMessageBox MessageDialog { get; set; } = null!;

        private ProductModel ProductModel { get; set; } = new ProductModel();

        private const string MessageFieldRequired = "Field is required.";

        private string[] errors = [];
        private bool isAddItem = true;
        private bool isDisabledType = true;

        private Product _oldProduct = null!;

        private List<Company> selectCompanies = new List<Company>();
        private List<Category> selectCategories = new List<Category>();
        private List<ProductType> selectTypes = new List<ProductType>();

        [Parameter] public Guid? Id { get; set; } = null;

        protected override async void OnInitialized()
        {
            selectCompanies = await CompanyService.GetAll();
            selectCategories = await CategoryService.GetAll();

            if (Id == null)
            {
                isAddItem = true;
                return;
            }

            isAddItem = isDisabledType = false;
            _oldProduct = await ProductService.GetItem((Guid)Id);
            selectTypes = ProductTypeService.GetListTypesByCategory(_oldProduct.CategoryId);
            ProductModel = _oldProduct.GetProductModel();
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

            if (!await ProductService.IsFreeName(ProductModel.Name))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            var product = ProductModel.GetProductType();
            await ProductService.AddAsync(product);

            MudDialog.Close();
        }

        private void ClearData() => ProductModel.ClearData();

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

            var product = ProductModel.GetModifyType(_oldProduct.Id);

            if (!await ProductService.IsFreeNameItemUpsert(product))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            if (!_oldProduct.Equals(product))
            {
                await ProductService.UpdataAsync(product);
            }

            MudDialog.Close();
        }

        private void RecoverPastData() => ProductModel = _oldProduct.GetProductModel();

        private void ChangeValueCategory(Category? item)
        {
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
            ProductModel.Category = item;
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.

            selectTypes = ProductTypeService.GetListTypesByCategory(ProductModel.Category.Id);
            ProductModel.Category.Types = selectTypes;

            if (ProductModel.Category == null || ProductModel.Category.Types == null)
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
            if (!decimal.TryParse(str, out decimal value))
            {
                yield return MessageFieldRequired;
            }
        }

        private bool ValidateFields(out string message)
        {
            message = string.Empty;

            if (ProductModel.Name == null || ProductModel.Name == string.Empty)
            {
                message = "Name is required.";
                return false;
            }

            if (ProductModel.Price <= 0)
            {
                message = "Price is required";
                return false;
            }

            if (ProductModel.Company == null)
            {
                message = "Company not selected.";
                return false;
            }

            if (ProductModel.Category == null)
            {
                message = "Category not selected.";
                return false;
            }

            if (ProductModel.ProductType == null)
            {
                message = "Product Type not selected.";
                return false;
            }

            return true;
        }
    }
}
