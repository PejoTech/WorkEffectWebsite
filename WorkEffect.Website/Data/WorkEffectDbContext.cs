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
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Data
{
    public class WorkEffectDbContext : DbContext
    {
        private static readonly string FileName = HttpRuntime.AppDomainAppPath + @"App_Data\WorkEffect.sqlite";
        
        public WorkEffectDbContext() 
            : base(new SQLiteConnection() { ConnectionString =
            new SQLiteConnectionStringBuilder()
                { DataSource = FileName, ForeignKeys = true }
            .ConnectionString }, true)
        {
        }
        
        public DbSet<Section> Sections { get; set; }

        public DbSet<Layout> Layouts { get; set; }
    }
}
