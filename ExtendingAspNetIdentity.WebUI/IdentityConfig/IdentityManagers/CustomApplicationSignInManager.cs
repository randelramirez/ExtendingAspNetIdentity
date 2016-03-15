using ExtendingAspNetIdentity.WebUI.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingAspNetIdentity.WebUI.IdentityConfig.IdentityManagers
{
    public class CustomApplicationSignInManager : SignInManager<CustomUser, int>
    {
        public CustomApplicationSignInManager(CustomApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(CustomUser user)
        {
            return user.GenerateUserIdentityAsync((CustomApplicationUserManager)UserManager);
        }

        public static CustomApplicationSignInManager Create(IdentityFactoryOptions<CustomApplicationSignInManager> options, IOwinContext context)
        {
            return new CustomApplicationSignInManager(context.GetUserManager<CustomApplicationUserManager>(), context.Authentication);
        }
    }
}
