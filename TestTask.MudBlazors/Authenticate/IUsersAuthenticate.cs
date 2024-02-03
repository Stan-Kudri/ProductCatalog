using TestTask.Core.Models.Users;

namespace TestTask.MudBlazors.Authenticate
{
    public interface IUsersAuthenticate
    {
        Task<string> LoginAsync(User user);
    }
}
