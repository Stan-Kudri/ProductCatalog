using System;
using System.Security.Cryptography;
using System.Text;

namespace TestTask.Core.Models.Users
{
    public class User : Entity
    {
        private User()
        {
        }

        public User(string username, string password)
        {
            var validator = new UserValidator();

            if (!validator.ValidFormatPassword(password, out var messageValidPass))
            {
                throw new ArgumentException(messageValidPass, nameof(password));
            }

            if (!validator.ValidFormatUsername(username, out var messageValidUsername))
            {
                throw new ArgumentException(messageValidUsername, nameof(username));
            }

            Username = username;
            PasswordHash = GetPaswordHash(password);
        }

        public User(string username, string passwordHash, UserRole userRole)
            : this(username, passwordHash) => UserRole = userRole;

        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public UserRole UserRole { get; set; } = UserRole.Basic;

        private string GetPaswordHash(string password)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = MD5.HashData(inputBytes);
            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}
