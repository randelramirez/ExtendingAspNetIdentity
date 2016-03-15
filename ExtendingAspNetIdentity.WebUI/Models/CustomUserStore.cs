using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingAspNetIdentity.WebUI.Models
{
    public class CustomUserStore : UserStore<CustomUser, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public CustomUserStore(CustomApplicationDbContext context) : base(context)
        {
        }
    }
}
