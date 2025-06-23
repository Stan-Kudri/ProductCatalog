using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.MudBlazors.Authenticate;

namespace TestTask.MudBlazors.Shared
{
    public partial class MainLayout
    {
        private const string MessageLogout = "User logout";

        [Inject] private NavigationManager Navigation { get; set; } = null!;
        [Inject] private BlazorAppLoginService BlazorAppLoginService { get; set; } = null!;
        [Inject] private ISnackbar Snackbar { get; set; } = null!;

        private bool _drawerOpen = false;

        private void DrawerToggle() => _drawerOpen = !_drawerOpen;

        private void SignInPage() => Navigation.NavigateTo($"/login/{true}");

        private async Task LogoutAsync()
        {
            await BlazorAppLoginService.LogoutAsync();
            Snackbar.Add(MessageLogout, Severity.Info);
        }
    }
}
