using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NPOI.XSSF.UserModel;
using TestTask.Core.Export.SheetFillers;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;

namespace TestTask.MudBlazors.Pages.Export
{
    public partial class ExportExcel
    {
        [Inject] private CompanyRepository CompanyRepository { get; set; } = null!;
        [Inject] private CategoryRepository CategoryRepository { get; set; } = null!;
        [Inject] private ProductTypeRepository ProductTypeRepository { get; set; } = null!;
        [Inject] private ProductRepository ProductRepository { get; set; } = null!;
        [Inject] private IJSRuntime JS { get; set; } = null!;

        private async Task DownloadFile()
        {
            var companySheetFiller = new CompanySheetFiller(CompanyRepository);
            var categorySheetFiller = new CategorySheetFiller(CategoryRepository);
            var typeSheetFiller = new TypeSheetFiller(ProductTypeRepository);
            var productSheetFiller = new ProductSheetFiller(ProductRepository);

            var fillers = new ISheetFiller[]
            {
                    companySheetFiller,
                    productSheetFiller,
                    categorySheetFiller,
                    typeSheetFiller,
            };

            var workbook = new XSSFWorkbook();
            foreach (var filler in fillers)
            {
                var sheet = workbook.CreateSheet(filler.Name);
                filler.Fill(sheet);
            }

            using var root = new MemoryStream();
            using var XSSFStream = new NonClosableStream(root);
            workbook.Write(XSSFStream);
            XSSFStream.Position = 0;

            byte[] bytes = root.ToArray();
            await JS.InvokeVoidAsync("BlazorDownloadFile", "Export.xlsx", bytes);
        }
    }
}
