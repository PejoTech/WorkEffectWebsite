namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypesSiteContent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CmsContents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.Int(nullable: false),
                        Content = c.String(),
                        Deleted = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CmsPages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Deleted = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CmsParts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CmsParts");
            DropTable("dbo.CmsPages");
            DropTable("dbo.CmsContents");
        }
    }
}
