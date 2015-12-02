using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using WorkEffect.Website.Types;

namespace WorkEffect.Website.Data
{
    public class WorkEffectDbContext : IdentityDbContext<AppUser>
    {
        public Guid SystemGuid { get; } = Guid.Parse("67DDEA4E-4E01-4736-A971-3D3106CF61B7");

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
            var entities = ChangeTracker.Entries().Where(c => c.State != EntityState.Modified || c.State != EntityState.Added);

            foreach (var entity in entities)
            {
                var baseEntity = entity.Entity as BaseEntity;

                if (entity.State == EntityState.Modified)
                {
                    baseEntity.UpdatedById = SystemGuid;
                    baseEntity.UpdatedOn = DateTime.UtcNow;
                }
                else
                {
                    baseEntity.CreatedById = SystemGuid;
                    baseEntity.CreatedOn = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();
        }
    }
}
