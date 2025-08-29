using ProductCatalog.MudBlazors.Model;

namespace ProductCatalog.MudBlazors.Authenticate
{
    public interface IUsersAuthenticate
    {
        Task<string> LoginAsync(UserModel user);
    }
}
