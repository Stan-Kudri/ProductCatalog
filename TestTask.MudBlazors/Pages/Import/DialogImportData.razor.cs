using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;

namespace TestTask.MudBlazors.Pages.Import
{
    public partial class DialogImportData
    {
        [Inject] private CompanyService CompanyService { get; set; } = null!;
        [Inject] private CategoryService CategoryService { get; set; } = null!;
        [Inject] private ProductTypeService ProductTypeService { get; set; } = null!;
        [Inject] private ProductService ProductService { get; set; } = null!;
        [Inject] private ExcelImporter<Company> ExcelImportCompany { get; set; } = null!;
        [Inject] private ExcelImporter<Category> ExcelImportCategory { get; set; } = null!;
        [Inject] private ExcelImporter<ProductType> ExcelImportTypeProduct { get; set; } = null!;
        [Inject] private ExcelImporter<Product> ExcelImportProduct { get; set; } = null!;


        [CascadingParameter] private MudDialogInstance MudDialog { get; set; } = null!;

        private ImportSelectTable selectedTable = new ImportSelectTable();

        private void Cancel() => MudDialog.Cancel();

        private async Task UploadFiles(IBrowserFile fileload)
        {
            if (selectedTable.SelectTable.Count() == 0 || fileload.Size == decimal.Zero)
            {
                return;
            }

            var buffer = new byte[fileload.Size];
            await fileload.OpenReadStream().ReadAsync(buffer);
            Cancel();

            if (selectedTable.SelectTable.Contains(ImportTable.Company))
            {
                var companyRead = ExcelImportCompany.Import(buffer);
                foreach (var row in companyRead)
                {
                    if (row.Success)
                    {
                        CompanyService.Upsert(row.Value);
                    }
                }
            }

            if (selectedTable.SelectTable.Contains(ImportTable.Category))
            {
                var categoryRead = ExcelImportCategory.Import(buffer);
                foreach (var row in categoryRead)
                {
                    if (row.Success)
                    {
                        CategoryService.Upsert(row.Value);
                    }
                }
            }

            if (selectedTable.SelectTable.Contains(ImportTable.TypeProduct))
            {
                var typeProductRead = ExcelImportTypeProduct.Import(buffer);
                foreach (var row in typeProductRead)
                {
                    if (row.Success)
                    {
                        ProductTypeService.Upsert(row.Value);
                    }
                }
            }

            if (selectedTable.SelectTable.Contains(ImportTable.Product))
            {
                var productRead = ExcelImportProduct.Import(buffer);
                foreach (var row in productRead)
                {
                    if (row.Success)
                    {
                        ProductService.Upsert(row.Value);
                    }
                }
            }
        }
    }
}
