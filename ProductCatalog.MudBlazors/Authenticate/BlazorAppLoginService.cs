using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using ProductCatalog.MudBlazors.Model;

namespace ProductCatalog.MudBlazors.Authenticate
{
    public class BlazorAppLoginService(ProtectedLocalStorage localStorage, NavigationManager navigation, IUsersAuthenticate authenticateService, IConfiguration configuration)
    {
        private readonly string TokenKey = nameof(TokenKey);

        public async Task<bool> LoginAsync(UserModel userModel)
        {
            var isSuccess = false;
            var token = await authenticateService.LoginAsync(userModel);
            if (!string.IsNullOrEmpty(token))
            {
                isSuccess = true;
                await localStorage.SetAsync(TokenKey, token);
            }

            return isSuccess;
        }

        public async Task<List<Claim>> GetLoginInfoAsync()
        {
            var emptyResut = new List<Claim>();
            ProtectedBrowserStorageResult<string> token;
            try
            {
                token = await localStorage.GetAsync<string>(TokenKey);
            }
            catch (CryptographicException)
            {
                await LogoutAsync();
                return emptyResut;
            }

            if (!token.Success || token.Value == default)
            {
                return emptyResut;
            }

            var claims = JwtTokenHelper.ValidateDecodeToken(token.Value, configuration);
            if (claims.Count == 0)
            {
                await LogoutAsync();
            }

            return claims;
        }

        public async Task LogoutAsync()
        {
            await RemoveAuthDataFromStorageAsync();
            navigation.NavigateTo("/", true);
        }

        private async Task RemoveAuthDataFromStorageAsync()
            => await localStorage.DeleteAsync(TokenKey);
    }
}
