using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using ProductCatalog.Core.Models.Users;
using ProductCatalog.MudBlazors.Model;

namespace ProductCatalog.MudBlazors.Authenticate
{
    public class UsersAuthenticateService(IConfiguration configuration, UserService userService) : IUsersAuthenticate
    {
        public async Task<string> LoginAsync(UserModel userModel)
        {
            await Task.CompletedTask;
            var (isVerifyUserData, user) = await ValidUserService(userModel);

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

        private async Task<(bool, User?)> ValidUserService(UserModel userModel)
            => !await userService.IsDataVerifyUser(userModel.Username, userModel.Password)
                ? (false, null)
                : (true, userService.GetUser(userModel.Username, userModel.Password));
    }
}
