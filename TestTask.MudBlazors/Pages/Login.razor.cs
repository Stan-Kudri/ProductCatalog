using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Authentications;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages
{
    public partial class Login
    {
        [Inject] private ISnackbar Snackbar { get; set; } = null!;
        [Inject] UserService UserService { get; set; } = null!;
        [Inject] UserValidator UserValidator { get; set; } = null!;
        [Inject] NavigationManager Navigation { get; set; } = null!;
        [Inject] WebsiteAuthenticator WebsiteAuthenticator { get; set; } = null!;

        private UserModel userModel { get; set; } = new UserModel();
        private string matchPassword = string.Empty;
        private string[] errors = { };

        [Parameter] public bool IsSignIn { get; set; } = false;

        private void SignInPage() => Navigation.NavigateTo($"/login/{true}");

        private void RegistrationPage() => Navigation.NavigateTo($"/login/{false}");

        private void ClearField() => userModel.Password = userModel.Username = matchPassword = string.Empty;

        private async Task SignIn()
        {
            if (errors.Length != 0)
            {
                return;
            }

            var user = userModel.ToUser();

            if (user == null)
            {
                throw new Exception("User not found in database.");
            }

            await WebsiteAuthenticator.LoginAsync(user);
            Navigation.NavigateTo("/table");
            Snackbar.Add($"Sign in account : {user.Username}", Severity.Success);
        }

        private void AddUser()
        {
            if (errors.Length != 0)
            {
                return;
            }

            var user = userModel.ToUser();

            UserService.Add(user);
            SignInPage();
        }

        private IEnumerable<string> ValidFormatPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                yield return "Password is required!";
                yield break;
            }

            if (!UserValidator.ValidFormatPassword(password, out var message))
            {
                yield return message;
                yield break;
            }
        }

        private IEnumerable<string> ValidFormatUsername(string username)
        {
            if (!IsSignIn && !UserService.IsFreeUsername(userModel.Username))
            {
                yield return string.Format($"{userModel.Username} username is taken.");
                yield break;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                yield return "Username is required!";
                yield break;
            }

            if (!UserValidator.ValidFormatUsername(username, out var message))
            {
                yield return message;
                yield break;
            }
        }

        private string? MatchPassword(string arg)
        {
            if (userModel.Password != arg)
            {
                return "Passwords don't match";
            }

            return null;
        }
    }
}
