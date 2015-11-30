namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderIndex : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CmsContents", new[] { "CmsPageId" });
            CreateIndex("dbo.CmsPages", "Index", unique: true);
            CreateIndex("dbo.CmsContents", "CmsPageId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.CmsContents", new[] { "CmsPageId" });
            DropIndex("dbo.CmsPages", new[] { "Index" });
            CreateIndex("dbo.CmsContents", "CmsPageId");
        }
    }
}
