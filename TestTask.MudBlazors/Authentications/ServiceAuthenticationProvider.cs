using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using System.Security.Claims;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Authentications
{
    public class ServiceAuthenticationProvider : AuthenticationStateProvider
    {
        private readonly ISnackbar _snackbar;
        private readonly NavigationManager _navigationManager;
        private readonly UserService _userService;
        private readonly AuthenticationUser _authenticationUser;

        private AuthenticationState _authenticationState;

        public ServiceAuthenticationProvider(AuthenticationService service, UserService userService, ISnackbar snackbar, NavigationManager navigationManager, AuthenticationUser authenticationUser)
        {
            _snackbar = snackbar;
            _navigationManager = navigationManager;
            _userService = userService;
            _authenticationUser = authenticationUser;
            _authenticationState = new AuthenticationState(service.CurrentUser);

            service.UserChanged += (newUser) =>
            {
                _authenticationState = new AuthenticationState(newUser);

                NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(newUser)));
            };
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
            => Task.FromResult(_authenticationState);

        public void LoginAsync(User userModel)
        {
            var userClaimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity());
            var (isUserDate, user) = ValidUserService(userModel);

            if (!isUserDate)
            {
                _snackbar.Add($"Account login failed.", Severity.Warning);
                NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(userClaimsPrincipal)));
                return;
            }


            var identity = GetUserClaimsIdentity(user);
            userClaimsPrincipal = new ClaimsPrincipal(identity);
            _authenticationState = new AuthenticationState(userClaimsPrincipal);
            NotifyAuthenticationStateChanged(Task.FromResult(_authenticationState));

            _snackbar.Add($"Sign in account : {userModel.Username}", Severity.Success);
            _navigationManager.NavigateTo("/table");
        }

        public async Task ExitAccountAsync()
        {
            _authenticationState = new AuthenticationState(new ClaimsPrincipal());
            NotifyAuthenticationStateChanged(Task.FromResult(_authenticationState));
            await _authenticationUser.AccountAsync(this);
        }

        private (bool, User) ValidUserService(User user)
        {
            if (!_userService.IsUserData(user))
            {
                return (false, user);
            }

            return (true, _userService.GetUser(user.Username, user.PasswordHash));
        }

        private ClaimsIdentity GetUserClaimsIdentity(User user)
            => new ClaimsIdentity(new[]{
                                    new Claim(ClaimTypes.Name, user.Username),
                                    new Claim(ClaimTypes.NameIdentifier, _userService.GetIdUser(user).ToString())},
                                  StorageConstants.IdentyToken);

    }
}
