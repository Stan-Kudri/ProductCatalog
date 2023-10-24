using System.Linq;

namespace TestTask.Core.Extension
{
    public static class StringPassExtension
    {
        public const int MinLengthPass = 6;

        public static bool ValidFormatPassword(this string password, out string message)
        {
            message = string.Empty;

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
                message = string.Format("{0}\n{1}", "Invalid string format.", "The password does not contain a number.");
                return false;
            }

            if (!password.Any(e => char.IsLetter(e)))
            {
                message = string.Format("{0}\n{1}", "Invalid string format.", "The password does not contain a latter.");
                return false;
            }

            return true;
        }
    }
}
