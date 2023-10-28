namespace TestTask.Core
{
    public interface IMessageBox
    {
        void ShowInfo(string message);

        void ShowWarning(string message);

        void ShowWarning(string message, string title);

        void ShowError(string message);

        bool ShowQuestion(string message);
    }
}
