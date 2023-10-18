using System;
using TestTask.Core.Extension;

namespace TestTask.Core.Components
{
    public class User : Entity
    {
        private User()
        {
        }

        public User(string username, string password)
        {
            if (!password.ValidFormatPassword(out var messageValidPass))
            {
                throw new ArgumentException(messageValidPass, nameof(password));
            }

            if (!username.ValidFormatUsername(out var messageValidUsername))
            {
                throw new ArgumentException(messageValidUsername, nameof(username));
            }

            Username = username;
            Password = password;
        }

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;


    }
}
