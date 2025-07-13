using MudBlazor;
using TestTask.MudBlazors.Dialog;

namespace TestTask.MudBlazors.Extension
{
    public static class DialogServiceShow
    {
        public static async Task<bool> DialogYesNoShow(this IDialogService dialogService, string title, string content)
        {
            var parameters = new DialogParameters<DialogYesNo> { { x => x.Content, content } };
            return await dialogService.DialogShowAsync(parameters, title, content);
        }

        private static async Task<bool> DialogShowAsync(this IDialogService dialogService, DialogParameters<DialogYesNo> dialogParameters, string title, string content)
        {
            var options = new DialogOptions { CloseOnEscapeKey = true };
            var dialog = await dialogService.ShowAsync<DialogYesNo>(title, dialogParameters, options);
            var result = await dialog.Result;
            return result == null || !result.Canceled;
        }
    }
}
