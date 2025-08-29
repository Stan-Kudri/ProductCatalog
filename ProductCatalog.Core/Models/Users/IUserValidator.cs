namespace ProductCatalog.Core.Models.Users
{
    public interface IUserValidator
    {
        bool ValidatePassword(string password, out string message);

        bool ValidateUsername(string username, out string message);
    }
}
