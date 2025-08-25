using System;

namespace TestTask.Extension
{
    public static class ParseExtension
    {
        public static decimal ParseDecimal(this string str)
            => decimal.TryParse(str, out var value)
                ? value
                : throw new InvalidOperationException("Invalid cast.");

        public static Guid ParseGuid(this string str)
            => Guid.TryParse(str, out var value)
                ? value
                : throw new InvalidOperationException("Invalid cast.");
    }
}
