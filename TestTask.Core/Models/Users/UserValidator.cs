using System;
using System.Linq;

namespace TestTask.Core.Models.Users
{
    public class UserValidator
    {
        public const int MinLengthUsername = 3;

        public bool ValidFormatUsername(string username, out string message)
        {
            message = string.Empty;

            if (username.Length < MinLengthUsername)
            {
                message = "Your username isn’t strong enough, try making it longer.";
                return false;
            }

            if (!username.All(e => char.IsLetterOrDigit(e)))
            {
                message = "Illegal characters in string.";
                return false;
            }

            return true;
        }

        public const int MinLengthPass = 6;

        public bool ValidFormatPassword(string password, out string message)
        {
            message = string.Empty;

            if (password == null)
            {
                message = "Password should not be empty.";
                return false;
            }

            if (password.Length < MinLengthPass)
            {
                message = "Your password isn’t strong enough, try making it longer.";
                return false;
            }

            if (!password.All(e => char.IsLetterOrDigit(e)))
            {
                message = "Illegal characters in string.";
                return false;
            }

            if (!password.Any(e => char.IsDigit(e)))
            {
                message = string.Format("{0}{1}{2}", "Invalid string format.", Environment.NewLine, "The password does not contain a number.");
                return false;
            }

            if (!password.Any(e => char.IsLetter(e)))
            {
                message = string.Format("{0}{1}{2}", "Invalid string format.", Environment.NewLine, "The password does not contain a latter.");
                return false;
            }

            return true;
        }
    }
}
