using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace TestTask.MudBlazors.Authenticate
{
    public class BlazorAuthStateProvider : AuthenticationStateProvider
    {
        private readonly BlazorAppLoginService _blazorAppLoginService;

        public BlazorAuthStateProvider(BlazorAppLoginService blazorAppLoginService)
            => _blazorAppLoginService = blazorAppLoginService;

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var claims = await _blazorAppLoginService.GetLoginInfoAsync();
            ClaimsIdentity claimsIdentity = claims.Count != 0 ? new ClaimsIdentity(claims, "Bearer") : new ClaimsIdentity();
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            return new AuthenticationState(claimsPrincipal);
        }
    }
}
