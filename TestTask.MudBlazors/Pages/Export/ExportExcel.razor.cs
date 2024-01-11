using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using NPOI.XSSF.UserModel;
using TestTask.Core.DataTable;
using TestTask.Core.Export.SheetFillers;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using ItemSelected = TestTask.Core.DataTable.Table;

namespace TestTask.MudBlazors.Pages.Export
{
    public partial class ExportExcel
    {
        [Inject] private CompanyRepository CompanyRepository { get; set; } = null!;
        [Inject] private CategoryRepository CategoryRepository { get; set; } = null!;
        [Inject] private ProductTypeRepository ProductTypeRepository { get; set; } = null!;
        [Inject] private ProductRepository ProductRepository { get; set; } = null!;
        [Inject] private IJSRuntime JS { get; set; } = null!;

        [CascadingParameter] private MudDialogInstance MudDialog { get; set; } = null!;

        private SelectTable selectedTable = new SelectTable();

        private void Cancel() => MudDialog.Cancel();

        private async Task DownloadFile()
        {
            if (selectedTable.SelectTables.Count() <= 0)
            {
                return;
            }

            var fillers = SelectExportTable();

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

        private ISheetFiller[] SelectExportTable()
        {
            var fillers = new List<ISheetFiller>();

            if (selectedTable.SelectTables.Contains(ItemSelected.Company))
            {
                fillers.Add(new CompanySheetFiller(CompanyRepository));
            }
            if (selectedTable.SelectTables.Contains(ItemSelected.Category))
            {
                fillers.Add(new CategorySheetFiller(CategoryRepository));
            }
            if (selectedTable.SelectTables.Contains(ItemSelected.TypeProduct))
            {
                fillers.Add(new TypeSheetFiller(ProductTypeRepository));
            }
            if (selectedTable.SelectTables.Contains(ItemSelected.Product))
            {
                fillers.Add(new ProductSheetFiller(ProductRepository));
            }

            return fillers.ToArray();
        }
    }
}
