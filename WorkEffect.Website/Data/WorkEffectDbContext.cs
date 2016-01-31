using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Data
{
    public class WorkEffectDbContext : DbContext
    {
        static readonly SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\AppData\WorkEffect.sqlite");

        public WorkEffectDbContext() : base("name=MyDbCS")
        {
            
        }
        
        public DbSet<Section> Sections { get; set; }

        public DbSet<Content> Contents { get; set; }
    }
}
