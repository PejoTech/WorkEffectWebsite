using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using WorkEffect.Website.Types;

namespace WorkEffect.Website.Data
{
    class WorkEffectDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<CmsPage> Pages{ get; set; }
        public DbSet<CmsPart> Parts { get; set; }
        public DbSet<CmsContent> Contents { get; set; }

        public WorkEffectDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
