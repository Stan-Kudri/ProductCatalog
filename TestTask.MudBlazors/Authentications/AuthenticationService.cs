using System.Security.Claims;

namespace TestTask.MudBlazors.Authentications
{
    public class AuthenticationService
    {
        public event Action<ClaimsPrincipal>? UserChanged;

        private ClaimsPrincipal? currentUser;

        public ClaimsPrincipal CurrentUser
        {
            get => currentUser ?? new();
            set
            {
                currentUser = value;

                if (UserChanged is not null)
                {
                    UserChanged(currentUser);
                }
            }
        }
    }
}
