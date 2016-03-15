using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingAspNetIdentity.WebUI.Models
{
    public class CustomApplicationDbContext : IdentityDbContext<CustomUser, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public CustomApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static CustomApplicationDbContext Create()
        {
            return new CustomApplicationDbContext();
        }
    }
}
