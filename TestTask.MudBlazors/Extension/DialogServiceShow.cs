using MudBlazor;
using TestTask.MudBlazors.Pages.Table.Dialog;

namespace TestTask.MudBlazors.Extension
{
    public static class DialogServiceShow
    {
        public static async Task<DialogResult?> DialogYesNoShowAsync(this IDialogService dialogService, string title, string content)
        {
            var parameters = new DialogParameters<DialogYesNo> { { x => x.Content, content } };
            var options = new DialogOptions { CloseOnEscapeKey = true };
            var dialog = await dialogService.ShowAsync<DialogYesNo>(title, parameters, options);
            return await dialog.Result;
        }
    }
}
