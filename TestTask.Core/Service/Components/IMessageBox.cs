namespace TestTask.Core.Service.Components
{
    public interface IMessageBox
    {
        void ShowInfo(string message);

        void ShowWarning(string message);

        void ShowError(string message);

        bool ShowQuestion(string message);
    }
}
