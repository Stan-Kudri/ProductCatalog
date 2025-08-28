using Microsoft.AspNetCore.Components;
using MudBlazor;
using ProductCatalog.Core;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.MudBlazors.Extension;
using ProductCatalog.MudBlazors.Model.TableComponent;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Dialog.ItemTable
{
    public partial class ProductTypeItemDialog : IItemDialog
    {
        [CascadingParameter] IMudDialogInstance MudDialog { get; set; } = null!;
        [Inject] private ProductTypeService ProductTypeService { get; set; } = null!;
        [Inject] private CategoryService CategoryService { get; set; } = null!;
        [Inject] private IMessageBox MessageDialog { get; set; } = null!;

        private TypeProductModel typeProductModel { get; set; } = new TypeProductModel();
        private string[] errors = Array.Empty<string>();
        private bool isAddItem = true;

        private ProductType? oldTypeProduct;

        private List<Category> selectCategories = new List<Category>();

        [Parameter] public Guid? Id { get; set; } = null;

        protected override async void OnInitialized()
        {
            selectCategories = await CategoryService.GetAll();

            if (Id == null)
            {
                isAddItem = true;
                return;
            }

            isAddItem = false;
            oldTypeProduct = await ProductTypeService.GetItem((Guid)Id);
            typeProductModel = oldTypeProduct.GetTypeProductModel();
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

            if (!await ProductTypeService.IsFreeName(typeProductModel.Name))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            var typeProduct = typeProductModel.GetProductType();
            await ProductTypeService.AddAsync(typeProduct);

            MudDialog.Close();
        }

        private void ClearData() => typeProductModel.ClearData();

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

            var typeProduct = typeProductModel.GetModifyType(oldTypeProduct.Id);

            if (!await ProductTypeService.IsFreeNameItemUpsert(typeProduct))
            {
                await MessageDialog.ShowWarning("Name is not free.");
                return;
            }

            if (!oldTypeProduct.Equals(typeProduct))
            {
                await ProductTypeService.UpdataAsync(typeProduct);
            }

            MudDialog.Close();
        }

        private void RecoverPastData() => typeProductModel = oldTypeProduct.GetTypeProductModel();

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
