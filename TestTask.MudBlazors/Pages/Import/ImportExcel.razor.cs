using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;

namespace TestTask.MudBlazors.Pages.Import
{
    public partial class ImportExcel
    {
        [Inject] CompanyService CompanyService { get; set; }
        [Inject] CategoryService CategoryService { get; set; }
        [Inject] ProductTypeService ProductTypeService { get; set; }
        [Inject] ProductService ProductService { get; set; }
        [Inject] ExcelImporter<Company> ExcelImportCompany { get; set; }
        [Inject] ExcelImporter<Category> ExcelImportCategory { get; set; }
        [Inject] ExcelImporter<ProductType> ExcelImportTypeProduct { get; set; }
        [Inject] ExcelImporter<Product> ExcelImportProduct { get; set; }

        private async Task UploadFiles(IBrowserFile fileload)
        {
            var buffer = new byte[fileload.Size];
            await fileload.OpenReadStream().ReadAsync(buffer);

            var companyRead = ExcelImportCompany.Import(buffer);
            foreach (var item in companyRead)
            {
                if (item.Success)
                {
                    CompanyService.Upsert(item.Value);
                }
            }

            var categoryRead = ExcelImportCategory.Import(buffer);
            foreach (var item in categoryRead)
            {
                if (item.Success)
                {
                    CategoryService.Upsert(item.Value);
                }
            }

            var typeProductRead = ExcelImportTypeProduct.Import(buffer);
            foreach (var item in typeProductRead)
            {
                if (item.Success)
                {
                    ProductTypeService.Upsert(item.Value);
                }
            }

            var productRead = ExcelImportProduct.Import(buffer);
            foreach (var item in productRead)
            {
                if (item.Success)
                {
                    ProductService.Upsert(item.Value);
                }
            }
        }
    }
}
