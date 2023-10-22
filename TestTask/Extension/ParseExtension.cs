using System;

namespace TestTask.Extension
{
    public static class ParseExtension
    {
        public static int ParseInt(this string str) =>
            int.TryParse(str, out var value) ? value : throw new InvalidOperationException("Invalid cast.");
    }
}
