using System.Linq;

namespace TestTask.Core.Extension
{
    public static class StringUsernameExtension
    {
        public const int MinLengthUsername = 3;

        public static bool ValidFormatUsername(this string username, out string message)
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
    }
}
