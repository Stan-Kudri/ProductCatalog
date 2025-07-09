using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Model;

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

        public async Task<string> LoginAsync(UserModel userModel)
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
                    new Claim(ClaimTypes.Role, user.UserRole.ToString(), ClaimValueTypes.String)
                };

            var token = JwtTokenHelper.MakeToken(authClaims, _configuration);

            return token;
        }

        private (bool, User?) ValidUserService(UserModel userModel)
            => !_userService.IsUserData(userModel.Username, userModel.Password)
                ? (false, null)
                : (true, _userService.GetUser(userModel.Username, userModel.Password));
    }
}
