using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Repositories
{
    public class UserRepository
    {
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly UserManager<User> _userManager;

        public UserRepository(AuthenticationStateProvider authenticationStateProvider,
            UserManager<User> userManager)
        {
            _authenticationStateProvider = authenticationStateProvider;
            _userManager = userManager;
        }

        public async Task<User> GetUserLoggedIn()
        {
            var claimsPrincipal = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = await _userManager.GetUserAsync(claimsPrincipal.User);
            return user;
        }
    }
}
