namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropCmsPart : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CmsParts", "CmsPageId", "dbo.CmsPages");
            DropForeignKey("dbo.CmsContents", "CmsPartId", "dbo.CmsParts");
            DropIndex("dbo.CmsContents", new[] { "CmsPartId" });
            DropIndex("dbo.CmsParts", new[] { "CmsPageId" });
            AddColumn("dbo.CmsContents", "CmsPageId", c => c.Guid(nullable: false));
            CreateIndex("dbo.CmsContents", "CmsPageId");
            AddForeignKey("dbo.CmsContents", "CmsPageId", "dbo.CmsPages", "Id", cascadeDelete: true);
            DropColumn("dbo.CmsContents", "CmsPartId");
            DropTable("dbo.CmsParts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CmsParts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CmsPageId = c.Guid(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedById = c.Guid(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedById = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CmsContents", "CmsPartId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.CmsContents", "CmsPageId", "dbo.CmsPages");
            DropIndex("dbo.CmsContents", new[] { "CmsPageId" });
            DropColumn("dbo.CmsContents", "CmsPageId");
            CreateIndex("dbo.CmsParts", "CmsPageId");
            CreateIndex("dbo.CmsContents", "CmsPartId");
            AddForeignKey("dbo.CmsContents", "CmsPartId", "dbo.CmsParts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CmsParts", "CmsPageId", "dbo.CmsPages", "Id", cascadeDelete: true);
        }
    }
}
