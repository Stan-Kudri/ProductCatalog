using System.Linq;
using System.Threading;
using TestTask.Core.DBContext;
using TestTask.Core.Exeption;

namespace TestTask.Core.Models.Users
{
    public class UserService(AppDbContext dbContext, IUserValidator userValidator, IPasswordHasher passwordHasher)
    {
        public void Add(string username, string password, CancellationToken cancellationToken = default)
        {
            BusinessLogicException.ThrowIfNull(username);
            BusinessLogicException.ThrowIfNull(password);

            if (!userValidator.ValidateUsername(username, out var messageValidUsername))
            {
                throw new BusinessLogicException(messageValidUsername);
            }

            if (!userValidator.ValidatePassword(password, out var messageValidPass))
            {
                throw new BusinessLogicException(messageValidPass);
            }

            if (dbContext.Users.Any(e => e.Username == username))
            {
                throw new BusinessLogicException($"This username {username} exists.");
            }

            var passwordHash = Hash(password);
            var user = new User(username, passwordHash);

            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public bool IsFreeUsername(string username)
            => dbContext.Users.FirstOrDefault(e => e.Username == username) == null;

        public bool IsUserData(string username, string password)
        {
            var user = dbContext.Users.FirstOrDefault(e => e.Username == username);

            if (user == null && !Verify(password, user.PasswordHash))
            {
                return false;
            }

            return true;
        }

        public User GetUser(string username, string password)
        {
            var user = dbContext.Users.FirstOrDefault(e => e.Username == username);

            if (user == null && !Verify(password, user.PasswordHash))
            {
                return null;
            }

            return new User(username, user.PasswordHash);
        }

        public IQueryable<User> GetQueryableAll() => dbContext.Users.Select(e => e);

        private string Hash(string password) => passwordHasher.Hash(password);

        private bool Verify(string password, string hash) => passwordHasher.Verify(password, hash);
    }
}
