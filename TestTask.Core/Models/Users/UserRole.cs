using Ardalis.SmartEnum;

namespace TestTask.Core.Models.Users
{
    public class UserRole(string name, int value) : SmartEnum<UserRole>(name, value)
    {
        /// <summary>
        /// Пользователь.
        /// </summary>
        public static UserRole Basic { get; private set; } = new(Role.User, 0);

        /// <summary>
        /// Администратор.
        /// </summary>
        public static UserRole Admin { get; private set; } = new(Role.Admin, 1);

        public override string ToString() => Name;
    }

    public class Role
    {
        public const string Admin = "Administration";
        public const string User = "Basic Role";
    }
}
