using TestTask.Core.Models.Users;

namespace TestTask.BindingItem
{
    public class UserModel : ModelBase
    {
        private string _username = string.Empty;
        private string _password = string.Empty;

        public UserModel(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Username
        {
            get => _username;
            set => SetField(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetField(ref _password, value);
        }

        public User ToUser() => new User(_username, _password);
    }
}
