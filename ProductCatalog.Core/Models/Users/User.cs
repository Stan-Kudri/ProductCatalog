using System;

namespace ProductCatalog.Core.Models.Users
{
    public class User : Entity, IEquatable<User>
    {
        private User()
        {
        }

        public User(string username, string passwordHash)
        {
            ArgumentException.ThrowIfNullOrEmpty(username);
            ArgumentException.ThrowIfNullOrEmpty(passwordHash);

            Username = username;
            PasswordHash = passwordHash;
        }

        public User(string username, string passwordHash, UserRole userRole)
            : this(username, passwordHash) => UserRole = userRole;

        /// <summary>
        /// User login.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Password Hash.
        /// </summary>
        public string PasswordHash { get; set; } = string.Empty;

        /// <summary>
        /// User role in the app.
        /// </summary>
        public UserRole UserRole { get; set; } = UserRole.Basic;

        public bool Equals(User user)
            => user is not null && user.Username == Username && user.PasswordHash == PasswordHash;

        public override bool Equals(object obj) => Equals(obj as User);

        public override int GetHashCode() => HashCode.Combine(UserRole, Username, PasswordHash);
    }
}
