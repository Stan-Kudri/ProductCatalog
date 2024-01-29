using System;
using System.Linq;

namespace TestTask.Core.Models.Users
{
    public class UserService
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("The received parameters are not correct.");
            }

            if (_dbContext.Users.Any(e => e.Username == user.Username))
            {
                throw new ArgumentException("This username exists.");
            }

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public bool IsFreeUsername(string username) =>
            _dbContext.Users.FirstOrDefault(e => e.Username == username) == null;

        public bool IsUserData(User user) =>
            _dbContext.Users.FirstOrDefault(e => e.Username == user.Username && e.PasswordHash == user.PasswordHash) != null;

        public string GetUsername(int id)
            => _dbContext.Users.FirstOrDefault(e => e.Id == id).Username;

        public int GetIdUser(User user)
            => _dbContext.Users.FirstOrDefault(e => e.Username == user.Username && e.PasswordHash == user.PasswordHash).Id;
    }
}
