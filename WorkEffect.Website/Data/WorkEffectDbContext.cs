using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WorkEffect.Website.Types;

namespace WorkEffect.Website.Data
{
    public class WorkEffectDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<CmsPage> CmsPages{ get; set; }
        public DbSet<CmsGrid> CmsGrids { get; set; }
        public DbSet<CmsRow> CmsRows { get; set; }
        public DbSet<CmsCell> CmsCells { get; set; }
        public DbSet<CmsPart> CmsParts { get; set; }
        public DbSet<CmsResource> CmsResources { get; set; }

        public WorkEffectDbContext()
            : base("DefaultConnection")
        {
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(c => c.State != EntityState.Modified).Select(a => a.Entity as BaseEntity);

            foreach (var entity in entities)
            {
                entity.UpdatedById = Guid.Parse(HttpContext.Current.User.Identity.GetUserId());
                entity.UpdatedOn = DateTime.UtcNow;
            }

            var newEntities = ChangeTracker.Entries().Where(c => c.State != EntityState.Modified).Select(a => a.Entity as BaseEntity);

            foreach (var entity in newEntities)
            {
                entity.CreatedById = Guid.Parse(HttpContext.Current.User.Identity.GetUserId());
                entity.CreatedOn = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }
    }
}
