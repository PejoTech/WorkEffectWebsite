using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Data
{
    public class WorkEffectDbContext : DbContext
    {
        public DbSet<ContentLayout> ContentLayouts { get; set; }
        public DbSet<ContentSection> ContentSections { get; set; }
        public DbSet<ContentSite> ContentSites { get; set; }
    }
}