using WorkEffect.Website.Models;

namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WorkEffect.Website.Data.WorkEffectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WorkEffect.Website.Data.WorkEffectDbContext";
        }

        protected override void Seed(WorkEffect.Website.Data.WorkEffectDbContext context)
        {
            context.Set<Layout>().Add(new Layout
            {
                HtmlContainer = "asd",
                LayoutType = 0,
                Name = "123"
            });
            context.SaveChanges();
        }
    }
}
