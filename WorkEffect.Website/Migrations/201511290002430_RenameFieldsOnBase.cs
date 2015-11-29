namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameFieldsOnBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CmsContents", "CreatedById", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsContents", "UpdatedById", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsPages", "CreatedById", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsPages", "UpdatedById", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsParts", "CreatedById", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsParts", "UpdatedById", c => c.Guid(nullable: false));
            DropColumn("dbo.CmsContents", "CreatedBy");
            DropColumn("dbo.CmsContents", "UpdatedBy");
            DropColumn("dbo.CmsPages", "CreatedBy");
            DropColumn("dbo.CmsPages", "UpdatedBy");
            DropColumn("dbo.CmsParts", "CreatedBy");
            DropColumn("dbo.CmsParts", "UpdatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CmsParts", "UpdatedBy", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsParts", "CreatedBy", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsPages", "UpdatedBy", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsPages", "CreatedBy", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsContents", "UpdatedBy", c => c.Guid(nullable: false));
            AddColumn("dbo.CmsContents", "CreatedBy", c => c.Guid(nullable: false));
            DropColumn("dbo.CmsParts", "UpdatedById");
            DropColumn("dbo.CmsParts", "CreatedById");
            DropColumn("dbo.CmsPages", "UpdatedById");
            DropColumn("dbo.CmsPages", "CreatedById");
            DropColumn("dbo.CmsContents", "UpdatedById");
            DropColumn("dbo.CmsContents", "CreatedById");
        }
    }
}
