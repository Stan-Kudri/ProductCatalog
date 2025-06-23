using MudBlazor;
using TestTask.Core;
using TestTask.MudBlazors.Extension;

namespace TestTask.MudBlazors.Messages
{
    public class MessageDialog(IDialogService dialogService) : IMessageBox
    {
        public Task ShowError(string message)
            => dialogService.ShowMessageBox(title: "Error", message, yesText: "Ok");

        public Task ShowInfo(string message)
            => dialogService.ShowMessageBox(title: "Information", message, yesText: "Ok");

        public Task<bool> ShowQuestion(string message)
            => dialogService.DialogYesNoShow(title: "Question", message);

        public Task ShowWarning(string message)
            => dialogService.ShowMessageBox(title: "Warning", message, yesText: "Ok");

        public Task ShowWarning(string message, string title)
            => dialogService.ShowMessageBox(title, message, yesText: "Ok");
    }
}
