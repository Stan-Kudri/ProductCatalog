using Ardalis.SmartEnum;

namespace TestTask.Core.Models.Users
{
    public class UserRole : SmartEnum<UserRole>
    {
        /// <summary>
        /// Пользователь.
        /// </summary>
        public static UserRole Basic = new(Role.User, 0);

        /// <summary>
        /// Администратор.
        /// </summary>
        public static UserRole Admin = new(Role.Admin, 1);

        public UserRole(string name, int value)
            : base(name, value)
        {
        }

        public override string ToString() => Name;
    }

    public class Role
    {
        public const string Admin = "Administration";
        public const string User = "Basic Role";
    }
}
