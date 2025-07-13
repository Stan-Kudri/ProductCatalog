using Ardalis.SmartEnum;

namespace TestTask.Core.Models.Users
{
    public class UserRole(string name, int value) : SmartEnum<UserRole>(name, value)
    {
        /// <summary>
        /// User.
        /// </summary>
        public static UserRole Basic { get; private set; } = new(RoleNames.Basic, 0);

        /// <summary>
        /// Admin.
        /// </summary>
        public static UserRole Admin { get; private set; } = new(RoleNames.Admin, 1);

        public override string ToString() => Name;
    }

    public static class RoleNames
    {
        public const string Admin = "Administration";
        public const string Basic = "Basic Role";
    }
}
