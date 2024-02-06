using Ardalis.SmartEnum;

namespace TestTask.Core.Models.Users
{
    public class UserRole : SmartEnum<UserRole>
    {
        public static UserRole Basic = new UserRole("Basic Role", 0);

        public static UserRole Admin = new UserRole("Administration", 2);


        public UserRole(string name, int value)
            : base(name, value)
        {
        }
    }
}
