using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Authenticate
{
    public class UsersAuthenticateService(IConfiguration configuration, UserService userService) : IUsersAuthenticate
    {
        public async Task<string> LoginAsync(UserModel userModel)
        {
            await Task.CompletedTask;
            var (isVerifyUserData, user) = ValidUserService(userModel);

            if (!isVerifyUserData || user == null)
            {
                return string.Empty;
            }

            var authClaims = new List<Claim>
                {
                    new (ClaimTypes.Name, user.Username),
                    new (ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new (ClaimTypes.Role, user.UserRole.ToString(), ClaimValueTypes.String)
                };

            var token = JwtTokenHelper.MakeToken(authClaims, configuration);

            return token;
        }

        private (bool, User?) ValidUserService(UserModel userModel)
            => !userService.IsDataVerifyUser(userModel.Username, userModel.Password)
                ? (false, null)
                : (true, userService.GetUser(userModel.Username, userModel.Password));
    }
}
