using System.Linq;

namespace TestTask.Core.Extension
{
    public static class StringUsernameExtension
    {
        private const int MinLengthUsername = 3;

        public static bool ValidFormatUsername(this string password, out string message)
        {
            message = string.Empty;

            if (password.Length < MinLengthUsername)
            {
                message = "Your username isn’t strong enough, try making it longer.";
            }

            if (!password.All(e => char.IsLetterOrDigit(e)))
            {
                message = "Illegal characters in string.";
                return false;
            }

            return true;
        }
    }
}
