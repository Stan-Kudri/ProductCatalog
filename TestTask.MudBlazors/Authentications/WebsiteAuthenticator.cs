using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using MudBlazor;
using Newtonsoft.Json;
using System.Security.Claims;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Authentications
{
    public class WebsiteAuthenticator : AuthenticationStateProvider
    {
        private readonly ISnackbar _snackbar;
        private readonly ProtectedLocalStorage _localStorage;
        private readonly UserService _userService;
        private readonly NavigationManager _navigationManager;

        private int _userId;

        public WebsiteAuthenticator(ProtectedLocalStorage protectedLocalStorage, UserService userService, ISnackbar snackbar, NavigationManager navigationManager)
        {
            _localStorage = protectedLocalStorage;
            _userService = userService;
            _snackbar = snackbar;
            _navigationManager = navigationManager;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var claimsPrincipal = new ClaimsPrincipal();
                var storedPrincipal = await _localStorage.GetAsync<string>(StorageConstants.IdentyToken);

                if (storedPrincipal.Success)
                {
                    var user = JsonConvert.DeserializeObject<User>(storedPrincipal.Value);
                    var (_, isLookUpSuccess) = LookUpUser(user);

                    if (isLookUpSuccess)
                    {
                        var identity = CreateIdentityFromUser(user);
                        claimsPrincipal = new(identity);
                    }
                }

                return new AuthenticationState(claimsPrincipal);
            }

            catch
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
        }

        public async Task LoginAsync(User userModel)
        {
            var claimsPrincipal = new ClaimsPrincipal();

            if (_userService.IsUserData(userModel))
            {
                userModel.Id = _userService.GetIdUser(userModel);
                _userId = userModel.Id;
                var identity = CreateIdentityFromUser(userModel);
                claimsPrincipal = new ClaimsPrincipal(identity);
                await _localStorage.SetAsync(StorageConstants.IdentyToken, JsonConvert.SerializeObject(userModel));
                _snackbar.Add($"Sign in account : {userModel.Username}", Severity.Success);
                _navigationManager.NavigateTo("/table");
            }
            else
            {
                _snackbar.Add($"Account login failed.", Severity.Warning);
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }

        public async Task LogoutAsync()
        {
            await _localStorage.DeleteAsync(StorageConstants.IdentyToken);
            var claimsPrincipal = new ClaimsPrincipal();
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }

        public void ExitAccountAsync()
            => NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal())));

        public string GetUsername()
            => _userId != 0 ? _userService.GetUsername(_userId) : throw new Exception("Authentication error.");

        private static ClaimsIdentity CreateIdentityFromUser(User user)
            => new ClaimsIdentity(new Claim[] {
                    new(ClaimTypes.Name, user.Username),
                    new(ClaimTypes.NameIdentifier, user.Id.ToString()), },
                                 "Authentication");

        private (User?, bool) LookUpUser(User? user)
            => user == null ? (user, false) : (user, !_userService.IsUserData(user));
    }
}
