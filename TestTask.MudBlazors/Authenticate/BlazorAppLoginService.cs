using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Authenticate
{
    public class BlazorAppLoginService
    {
        private readonly string TokenKey = nameof(TokenKey);

        private readonly ProtectedLocalStorage _localStorage;
        private readonly NavigationManager _navigation;
        private readonly IUsersAuthenticate _authenticateService;
        private readonly IConfiguration _configuration;

        public BlazorAppLoginService(ProtectedLocalStorage localStorage, NavigationManager navigation, IUsersAuthenticate authenticateService, IConfiguration configuration)
        {
            _localStorage = localStorage;
            _navigation = navigation;
            _authenticateService = authenticateService;
            _configuration = configuration;
        }

        public async Task<bool> LoginAsync(UserModel userModel)
        {
            var isSuccess = false;
            var token = await _authenticateService.LoginAsync(userModel);
            if (!string.IsNullOrEmpty(token))
            {
                isSuccess = true;
                await _localStorage.SetAsync(TokenKey, token);
            }

            return isSuccess;
        }

        public async Task<List<Claim>> GetLoginInfoAsync()
        {
            var emptyResut = new List<Claim>();
            ProtectedBrowserStorageResult<string> token = default;

            try
            {
                token = await _localStorage.GetAsync<string>(TokenKey);
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

            var claims = JwtTokenHelper.ValidateDecodeToken(token.Value, _configuration);
            if (claims.Count == 0)
            {
                await LogoutAsync();
            }

            return claims;
        }

        public async Task LogoutAsync()
        {
            await RemoveAuthDataFromStorageAsync();
            _navigation.NavigateTo("/", true);
        }

        private async Task RemoveAuthDataFromStorageAsync()
            => await _localStorage.DeleteAsync(TokenKey);
    }
}
