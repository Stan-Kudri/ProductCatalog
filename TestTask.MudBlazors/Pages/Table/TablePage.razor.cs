using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.MudBlazors.Pages.Export;
using TestTask.MudBlazors.Pages.Import;

namespace TestTask.MudBlazors.Pages.Table
{
    public partial class TablePage
    {
        [Inject] private IDialogService DialogService { get; set; } = null!;

        private async void OpenDialogImport()
        {
            DialogOptions closeOnEscapeKey = new DialogOptions { CloseOnEscapeKey = true };
            await DialogService.ShowAsync<DialogImportData>("Import table", closeOnEscapeKey);
        }

        private async void OpenDialogExport()
        {
            DialogOptions closeOnEscapeKey = new DialogOptions { CloseOnEscapeKey = true };
            await DialogService.ShowAsync<ExportExcel>("Export table", closeOnEscapeKey);
        }
    }
}
