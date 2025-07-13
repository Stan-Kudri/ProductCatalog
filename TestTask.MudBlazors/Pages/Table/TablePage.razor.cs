using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.MudBlazors.Pages.Export;
using TestTask.MudBlazors.Pages.Import;

namespace TestTask.MudBlazors.Pages.Table
{
    public partial class TablePage
    {
        private const string TitleImportTable = "Import table";
        private const string TitleExportTable = "Export table";

        [Inject] private IDialogService DialogService { get; set; } = null!;

        private async Task OpenDialogImport()
        {
            DialogOptions closeOnEscapeKey = new DialogOptions { CloseOnEscapeKey = true };
            await DialogService.ShowAsync<DialogImportData>(TitleImportTable, closeOnEscapeKey);
        }

        private async Task OpenDialogExport()
        {
            DialogOptions closeOnEscapeKey = new DialogOptions { CloseOnEscapeKey = true };
            await DialogService.ShowAsync<ExportExcel>(TitleExportTable, closeOnEscapeKey);
        }
    }
}
