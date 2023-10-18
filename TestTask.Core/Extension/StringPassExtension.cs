using System.Linq;

namespace TestTask.Core.Extension
{
    public static class StringPassExtension
    {
        private const int MinLengthPass = 6;

        public static bool ValidFormatPassword(this string password, out string message)
        {
            message = string.Empty;

            if (password.Length < MinLengthPass)
            {
                message = "Your password isn’t strong enough, try making it longer.";
            }

            if (!password.All(e => char.IsLetterOrDigit(e)))
            {
                message = "Illegal characters in string.";
                return false;
            }

            if (!password.Any(e => char.IsDigit(e)) || !password.Any(e => char.IsLetter(e)))
            {
                message = "Invalid string format";
                return false;
            }

            return true;
        }
    }
}
