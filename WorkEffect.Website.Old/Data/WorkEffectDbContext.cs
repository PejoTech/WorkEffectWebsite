using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SQLite.CodeFirst;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Data
{
    public class WorkEffectDbContext : DbContext
    {
        public DbSet<Section> Sections { get; set; }

        public DbSet<Layout> Layouts { get; set; }
    }
}