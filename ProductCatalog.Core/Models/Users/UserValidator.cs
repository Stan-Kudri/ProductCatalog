using System;
using System.Linq;

namespace ProductCatalog.Core.Models.Users
{
    public class UserValidator : IUserValidator
    {
        public const int MinLengthUsername = 3;

        public bool ValidateUsername(string username, out string message)
        {
            message = string.Empty;

            if (username.Length < MinLengthUsername)
            {
                message = "Your username isn’t strong enough, try making it longer.";
                return false;
            }

            if (!username.All(char.IsLetterOrDigit))
            {
                message = "Illegal characters in string.";
                return false;
            }

            return true;
        }

        public const int MinLengthPass = 6;

        public bool ValidatePassword(string password, out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(password))
            {
                message = "Password should not be empty.";
                return false;
            }

            if (password.Length < MinLengthPass)
            {
                message = "Your password isn’t strong enough, try making it longer.";
                return false;
            }

            if (!password.All(char.IsLetterOrDigit))
            {
                message = "Illegal characters in string.";
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                message = string.Format("{0}{1}{2}", "Invalid string format.", Environment.NewLine, "The password does not contain a number.");
                return false;
            }

            if (!password.Any(char.IsLetter))
            {
                message = string.Format("{0}{1}{2}", "Invalid string format.", Environment.NewLine, "The password does not contain a letter.");
                return false;
            }

            return true;
        }
    }
}
