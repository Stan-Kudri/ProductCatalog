namespace ProductCatalog.Core.Models.Users
{
    /// <summary>
    /// BCrypt Password Hasher.
    /// </summary>
    public sealed class BCryptPasswordHasher : IPasswordHasher
    {
        private const int WorkFactor = 10;

        /// <inheritdoc/>
        public string Hash(string password)
            => BCrypt.Net.BCrypt.HashPassword(password, WorkFactor);

        /// <inheritdoc/>
        public bool Verify(string password, string hash)
            => BCrypt.Net.BCrypt.Verify(password, hash);
    }
}
