namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CmsConstraints : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CmsContents", "CmsPartId", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsParts", "CmsPageId", c => c.Guid(nullable: false));
            CreateIndex("dbo.CmsContents", "CmsPartId");
            CreateIndex("dbo.CmsParts", "CmsPageId");
            AddForeignKey("dbo.CmsParts", "CmsPageId", "dbo.CmsPages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CmsContents", "CmsPartId", "dbo.CmsParts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CmsContents", "CmsPartId", "dbo.CmsParts");
            DropForeignKey("dbo.CmsParts", "CmsPageId", "dbo.CmsPages");
            DropIndex("dbo.CmsParts", new[] { "CmsPageId" });
            DropIndex("dbo.CmsContents", new[] { "CmsPartId" });
            DropColumn("dbo.CmsParts", "CmsPageId");
            DropColumn("dbo.CmsContents", "CmsPartId");
        }
    }
}
