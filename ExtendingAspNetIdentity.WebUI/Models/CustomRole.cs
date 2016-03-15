﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingAspNetIdentity.WebUI.Models
{
    public class CustomRole : IdentityRole<int,CustomUserRole>
    {
        public CustomRole()
        {
        }

        public CustomRole(string name)
        {
            this.Name = name;
        }
    }
}
