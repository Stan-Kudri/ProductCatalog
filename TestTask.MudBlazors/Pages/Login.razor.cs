using Microsoft.AspNetCore.Components;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages
{
    public partial class Login
    {
        [Inject] UserService UserService { get; set; }
        [Inject] UserValidator UserValidator { get; set; }
        [Inject] NavigationManager Navigation { get; set; }

        private UserModel userModel { get; set; } = new UserModel();
        private string matchPassword = string.Empty;
        private string[] errors = { };

        [Parameter] public bool IsSignIn { get; set; } = false;

        private void SignInPage() => Navigation.NavigateTo($"/login/{true}");
        private void RegistrationPage() => Navigation.NavigateTo($"/login/{false}");

        private void ClearField() => userModel.Password = userModel.Username = matchPassword = string.Empty;

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
            if (!UserService.IsFreeUsername(userModel.Username))
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
                return "Passwords don't match";
            return null;
        }
    }
}
