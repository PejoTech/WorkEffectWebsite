using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WorkEffect.Website.Data
{
    class WorkEffectDbContext : IdentityDbContext<AppUser>
    {
        public WorkEffectDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
