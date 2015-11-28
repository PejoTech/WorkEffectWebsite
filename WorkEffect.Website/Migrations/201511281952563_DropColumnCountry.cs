namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumnCountry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            DropColumn("dbo.AspNetUsers", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Country", c => c.String());
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
