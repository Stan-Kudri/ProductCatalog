using TestTask.Core.Models.Users;

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

        public string Username { get; set; }

        public string Password { get; set; }

        public User ToUser() => new User(_username, _password);
    }
}
