using MudBlazor;
using TestTask.Core;
using TestTask.MudBlazors.Extension;

namespace TestTask.MudBlazors.Messages
{
    public class MessageDialog : IMessageBox
    {
        private readonly IDialogService _dialogService;

        public MessageDialog(IDialogService dialogService)
            => _dialogService = dialogService;

        public Task ShowError(string message)
            => _dialogService.ShowMessageBox(title: "Error", message, yesText: "Ok");

        public Task ShowInfo(string message)
            => _dialogService.ShowMessageBox(title: "Information", message, yesText: "Ok");

        public Task<bool> ShowQuestion(string message)
            => _dialogService.DialogYesNoShow(title: "Question", message);

        public Task ShowWarning(string message)
            => _dialogService.ShowMessageBox(title: "Warning", message, yesText: "Ok");

        public Task ShowWarning(string message, string title)
            => _dialogService.ShowMessageBox(title, message, yesText: "Ok");
    }
}
