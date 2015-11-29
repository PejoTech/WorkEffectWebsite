namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeakConstraints : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CmsContents", "PartId", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsParts", "CmsPageId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CmsParts", "CmsPageId");
            DropColumn("dbo.CmsContents", "PartId");
        }
    }
}
