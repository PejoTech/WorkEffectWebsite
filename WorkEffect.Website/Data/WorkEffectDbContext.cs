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

        private static readonly string FileName = HttpRuntime.AppDomainAppPath + "WorkEffect.sqlite";
        private static readonly SQLiteConnection sqliteConnection = new SQLiteConnection()
        {
            ConnectionString =
                new SQLiteConnectionStringBuilder
                {
                    DataSource = FileName,
                    ForeignKeys = true
                }.ConnectionString
        };

        public WorkEffectDbContext() 
            : base(sqliteConnection, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<WorkEffectDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }

    public class WorkEffectDbInitializer : SqliteCreateDatabaseIfNotExists<WorkEffectDbContext>
    {
        public WorkEffectDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        {
            Seed(new WorkEffectDbContext());
        }

        protected sealed override void Seed(WorkEffectDbContext context)
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