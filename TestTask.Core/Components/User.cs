using System;
using System.Security.Cryptography;
using System.Text;
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
            PasswordHash = GetPaswordHash(password);
        }

        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        private string GetPaswordHash(string password)
        {
            MD5 MD5Hash = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = MD5Hash.ComputeHash(inputBytes);
            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}
