using DB;
using Microsoft.AspNetCore.Identity;

namespace LoginManager
{
    public class AuthService
    {

        private readonly SignInManager<AppIdentityUser> _signInManager;
        private readonly UserManager<AppIdentityUser> _userManager;

        public AuthService(SignInManager<AppIdentityUser> signInManager, UserManager<AppIdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        
        public async Task<SignInResult> LoginAsync(string userName, string password)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) { return SignInResult.Failed; }

            SignInResult Result = await _signInManager.PasswordSignInAsync(user, password, isPersistent: false, lockoutOnFailure: false);
            return Result;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

    }
}
