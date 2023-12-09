using MudBlazor;
using TestTask.Core;

namespace TestTask.MudBlazors.Model
{
    public class MessageBoxMudBlazor : IMessageBox
    {
        public void ShowInfo(string message)
        {
            new DialogService().ShowMessageBox("Info", message, yesText: "OK");
        }

        public void ShowWarning(string message)
        {
            new DialogService().ShowMessageBox("Warning", message, yesText: "OK");
        }

        public void ShowWarning(string message, string title)
        {
            new DialogService().ShowMessageBox(title, message, yesText: "OK");
        }

        public void ShowError(string message)
        {
            new DialogService().ShowMessageBox("Error", message, yesText: "OK");
        }

        public bool ShowQuestion(string message)
        {
            var result = new DialogService().ShowMessageBox("Question",
                                                                message,
                                                                yesText: "Yes", cancelText: "No");
            return result == null ? false : true;
        }
    }
}
