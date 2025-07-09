namespace TestTask.Core.Models.Users
{
    /// <summary>
    /// Password hasher.
    /// </summary>
    public interface IPasswordHasher
    {
        /// <summary>
        /// Hash password.
        /// </summary>
        /// <param name="password">Password.</param>
        /// <returns>Hash.</returns>
        string Hash(string password);

        /// <summary>
        /// Verify password.
        /// </summary>
        /// <param name="password">Password.</param> 
        /// <param name="hash">Hash account.</param>
        /// <returns>Verify password.</returns>
        bool Verify(string password, string hash);
    }
}
