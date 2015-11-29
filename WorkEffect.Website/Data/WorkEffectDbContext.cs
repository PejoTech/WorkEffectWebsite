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
        public DbSet<CmsPage> Pages{ get; set; }
        public DbSet<CmsPart> Parts { get; set; }
        public DbSet<CmsContent> Contents { get; set; }

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

        public void DeleteById<T>(Guid? id) where T : BaseEntity
        {
            var entity = Set<T>().First(a => a.Id == id);
            Set<T>().Remove(entity);
            SaveChanges();
        }
    }
}
