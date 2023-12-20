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
        [Inject] CompanyService CompanyService { get; set; }
        [Inject] CategoryService CategoryService { get; set; }
        [Inject] ProductTypeService ProductTypeService { get; set; }
        [Inject] ProductService ProductService { get; set; }
        [Inject] ExcelImporter<Company> ExcelImportCompany { get; set; }
        [Inject] ExcelImporter<Category> ExcelImportCategory { get; set; }
        [Inject] ExcelImporter<ProductType> ExcelImportTypeProduct { get; set; }
        [Inject] ExcelImporter<Product> ExcelImportProduct { get; set; }


        [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

        private ImportSelectTable selectTable = new ImportSelectTable();

        private void Cancel() => MudDialog.Cancel();

        private async Task UploadFiles(IBrowserFile fileload)
        {
            if (selectTable.SelectTable.Count() == 0 || fileload.Size == decimal.Zero)
            {
                return;
            }

            var buffer = new byte[fileload.Size];
            await fileload.OpenReadStream().ReadAsync(buffer);

            if (selectTable.SelectTable.Contains(ImportTable.Company))
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

            if (selectTable.SelectTable.Contains(ImportTable.Category))
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

            if (selectTable.SelectTable.Contains(ImportTable.TypeProduct))
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

            if (selectTable.SelectTable.Contains(ImportTable.Product))
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
