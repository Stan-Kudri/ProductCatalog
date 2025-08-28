using System.Threading.Tasks;

namespace ProductCatalog.Core
{
    public interface IMessageBox
    {
        Task ShowInfo(string message);

        Task ShowWarning(string message);

        Task ShowWarning(string message, string title);

        Task ShowError(string message);

        Task<bool> ShowQuestion(string message);
    }
}
