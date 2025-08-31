using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace ProductCatalog.MudBlazors.Authenticate
{
    public class BlazorAuthStateProvider(BlazorAppLoginService blazorAppLoginService)
        : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var claims = await blazorAppLoginService.GetLoginInfoAsync();
            ClaimsIdentity claimsIdentity = claims.Count != 0 ? new ClaimsIdentity(claims, "Bearer") : new ClaimsIdentity();
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            return new AuthenticationState(claimsPrincipal);
        }
    }
}
