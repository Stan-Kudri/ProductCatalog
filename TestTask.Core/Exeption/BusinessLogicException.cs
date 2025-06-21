using System;
using System.Diagnostics.CodeAnalysis;

namespace TestTask.Core.Exeption
{
    public class BusinessLogicException : ApplicationException
    {
        public BusinessLogicException(string message)
            : base(message)
        {
        }

        public BusinessLogicException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public static void ThrowUniqueIDPropertyError<T>(object property) =>
            throw new BusinessLogicException($"{typeof(T).Name} \"{property}\" property with such an identifier exists.");

        public static BusinessLogicException EnsureValueLessThenZero<T>(string propertyName, object value) =>
            throw new BusinessLogicException($"The {typeof(T).Name} {propertyName} \"{value}\" is less than zero.");

        public static BusinessLogicException EnsureIdLessThenZero<T>(int id) =>
            throw new BusinessLogicException($"The {typeof(T).Name} ID \"{id}\" is less than zero.");

        public static void EnsureRangeDate<T>(DateTime date, string propertyName, DateTime minDateTime)
        {
            if (date > minDateTime)
            {
                return;
            }

            OutOfRangeMinDate<T>(propertyName, minDateTime);
        }

        public static void ThrowIfNull([NotNull] object? obj)
        {
            if (obj is null)
            {
                throw new BusinessLogicException("The passed object is empty.");
            }
        }

        public static void ThrowIfNullOrEmpty([NotNull] string? str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new BusinessLogicException("The passed string is empty.");
            }
        }

        public static void EnsureUniqueProperty<T>(string property) => ThrowUniquePropertyError<T>(property);

        private static void ThrowUniquePropertyError<T>(object property) =>
            throw new BusinessLogicException($"{typeof(T).Name} \"{property}\" must be unique. A record with this value already exists.");

        private static BusinessLogicException OutOfRangeMinDate<T>(string property, DateTime minDateTime)
            => new BusinessLogicException($"The {property} {typeof(T).Name} is less than expected {minDateTime}.");
    }
}
