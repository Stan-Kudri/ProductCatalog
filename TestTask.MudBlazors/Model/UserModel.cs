using Microsoft.AspNetCore.Components;

namespace TestTask.MudBlazors.Model
{
    public class UserModel
    {
        private string _username = string.Empty;
        private string _password = string.Empty;

        public UserModel()
        {
        }

        public UserModel(string username, string password)
        {
            _username = username;
            _password = password;
        }

        [Parameter]
        public string Username
        {
            get => _username;
            set => _username = value;
        }

        [Parameter]
        public string Password
        {
            get => _password;
            set => _password = value;
        }
    }
}
