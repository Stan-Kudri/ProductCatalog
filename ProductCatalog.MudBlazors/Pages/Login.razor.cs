using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using ProductCatalog.Core.Models.Users;
using ProductCatalog.MudBlazors.Authenticate;
using ProductCatalog.MudBlazors.Model;

namespace ProductCatalog.MudBlazors.Pages
{
    public partial class Login
    {
        [Inject] private UserService UserService { get; set; } = null!;
        [Inject] private IUserValidator UserValidator { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;
        [Inject] private BlazorAppLoginService BlazorAppLoginService { get; set; } = null!;
        [Inject] private ISnackbar Snackbar { get; set; } = null!;

        [CascadingParameter] protected Task<AuthenticationState>? AuthState { get; set; }

        private UserModel UserModel { get; set; } = new UserModel();
        private string matchPassword = string.Empty;
        private string[] errors = [];

        [Parameter] public bool IsSignIn { get; set; } = false;

        private void SignInPage() => Navigation.NavigateTo($"/login/{true}");

        private void RegistrationPage() => Navigation.NavigateTo($"/login/{false}");

#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        private void ClearField() => UserModel.Password = UserModel.Username = matchPassword = string.Empty;
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.

        private async Task SignIn()
        {
            var loginResult = await BlazorAppLoginService.LoginAsync(UserModel);

            if (!loginResult)
            {
                Snackbar.Add($"Account login failed.", Severity.Warning);
                return;
            }

            Snackbar.Add($"Sign in account : {UserModel.Username}", Severity.Success);
            Navigation.NavigateTo("/table", true);
        }

        private async Task AddUser()
        {
            if (errors.Length != 0)
            {
                return;
            }

            await UserService.AddAsync(UserModel.Username, UserModel.Password);
            Snackbar.Add($"Account registered", Severity.Success);
            SignInPage();
        }

        private IEnumerable<string> ValidFormatPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                yield return "Password is required!";
                yield break;
            }

            if (!UserValidator.ValidatePassword(password, out var message))
            {
                yield return message;
                yield break;
            }
        }

        private IEnumerable<string> ValidFormatUsername(string username)
        {
            if (!IsSignIn && !UserService.IsFreeUsername(UserModel.Username))
            {
                yield return string.Format($"{UserModel.Username} username is taken.");
                yield break;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                yield return "Username is required!";
                yield break;
            }

            if (!UserValidator.ValidateUsername(username, out var message))
            {
                yield return message;
                yield break;
            }
        }

        private string? MatchPassword(string arg)
        {
            if (UserModel.Password != arg)
            {
                return "Passwords don't match";
            }

            return null;
        }
    }
}
