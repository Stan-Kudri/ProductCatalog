using Microsoft.AspNetCore.Components.Authorization;

namespace TestTask.MudBlazors.Authentications
{
    public class AuthenticationUser
    {
        public string? Username { get; private set; }

        public bool IsAuthenticated { get; private set; }

        public async Task AccountAsync(AuthenticationStateProvider authStateProvider)
        {
            var authState = await authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity is not null && user.Identity.IsAuthenticated)
            {
                Username = user.Identity.Name;
                IsAuthenticated = true;
                return;
            }

            Username = null;
            IsAuthenticated = false;
        }

    }
}
