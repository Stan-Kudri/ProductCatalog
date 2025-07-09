using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Authenticate
{
    public interface IUsersAuthenticate
    {
        Task<string> LoginAsync(UserModel user);
    }
}
