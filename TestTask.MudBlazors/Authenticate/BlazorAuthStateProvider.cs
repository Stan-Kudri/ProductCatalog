using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace TestTask.MudBlazors.Authenticate
{
    public class BlazorAuthStateProvider : AuthenticationStateProvider
    {
        private readonly BlazorAppLoginService blazorAppLoginService;

        public BlazorAuthStateProvider(BlazorAppLoginService blazorAppLoginService)
        {
            this.blazorAppLoginService = blazorAppLoginService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var claims = await blazorAppLoginService.GetLoginInfoAsync();
            ClaimsIdentity claimsIdentity;
            if (claims.Any())
            {
                claimsIdentity = new ClaimsIdentity(claims, "Bearer");
            }
            else
            {
                claimsIdentity = new ClaimsIdentity();
            }
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            return new AuthenticationState(claimsPrincipal);
        }
    }
}
