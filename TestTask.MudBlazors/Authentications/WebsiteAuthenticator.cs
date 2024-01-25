using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Newtonsoft.Json;
using System.Security.Claims;
using TestTask.Core.Models.Users;

namespace TestTask.MudBlazors.Authentications
{
    public class WebsiteAuthenticator : AuthenticationStateProvider
    {
        private readonly ProtectedLocalStorage _localStorage;
        private readonly UserService _userService;

        public WebsiteAuthenticator(ProtectedLocalStorage protectedLocalStorage, UserService userService)
        {
            _localStorage = protectedLocalStorage;
            _userService = userService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var claimsPrincipal = new ClaimsPrincipal();

            try
            {
                var storedPrincipal = await _localStorage.GetAsync<string>("identity");

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
            }

            catch
            {
            }

            return new AuthenticationState(claimsPrincipal);
        }

        public async Task LoginAsync(User userModel)
        {
            var claimsPrincipal = new ClaimsPrincipal();

            if (!_userService.IsUserData(userModel))
            {
                var identity = CreateIdentityFromUser(userModel);
                claimsPrincipal = new ClaimsPrincipal(identity);
                await _localStorage.SetAsync("identity", JsonConvert.SerializeObject(userModel));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }

        public async Task LogoutAsync()
        {
            await _localStorage.DeleteAsync("identity");
            var claimsPrincipal = new ClaimsPrincipal();
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }

        private static ClaimsIdentity CreateIdentityFromUser(User user)
        {
            return new ClaimsIdentity(new Claim[]
            {
            new (ClaimTypes.Name, user.Username),
            new (ClaimTypes.Hash, user.PasswordHash),
            }, "Authentication");
        }

        private (User?, bool) LookUpUser(User? user)
            => user == null ? (user, false) : (user, _userService.IsUserData(user));
    }
}
