using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TestTask.Core.Models.Users;

namespace TestTask.MudBlazors.Authenticate
{
    public class UsersAuthenticateService : IUsersAuthenticate
    {
        private readonly IConfiguration _configuration;
        private readonly UserService _userService;

        public UsersAuthenticateService(IConfiguration configuration, UserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }

        public async Task<string> LoginAsync(User userModel)
        {
            await Task.CompletedTask;
            var (isUserDate, user) = ValidUserService(userModel);

            if (!isUserDate)
            {
                return string.Empty;
            }

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

            var token = JwtTokenHelper.MakeToken(authClaims, _configuration);

            return token;
        }

        private (bool, User) ValidUserService(User user)
        {
            if (!_userService.IsUserData(user))
            {
                return (false, user);
            }

            return (true, _userService.GetUser(user.Username, user.PasswordHash));
        }
    }
}
