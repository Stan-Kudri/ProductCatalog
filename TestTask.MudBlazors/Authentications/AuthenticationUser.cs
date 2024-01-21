using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using TestTask.Core.Models.Users;

namespace TestTask.MudBlazors.Authentications
{
    public class AuthenticationUser : AuthenticationStateProvider
    {
        private readonly UserService _userService;

        private User? _user = null;

        public AuthenticationUser(IServiceProvider serviceProvider)
            => _userService = serviceProvider.GetRequiredService<UserService>();

        public User? User => _user;

        public async Task Initialization(User user)
        {
            if (!_userService.IsUserData(user))
            {
                return;
            }

            _user = user;
            await GetAuthenticationStateAsync();
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsIdentity(authenticationType: _user?.Username);
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(user)));
        }
    }
}
