namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBaseTypesLetsSee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContentLayouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Css = c.String(),
                        Html = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContentSections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        ContentLayoutId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContentLayouts", t => t.ContentLayoutId, cascadeDelete: true)
                .Index(t => t.ContentLayoutId);
            
            CreateTable(
                "dbo.ContentSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ContentSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContentSections", t => t.ContentSectionId, cascadeDelete: true)
                .Index(t => t.ContentSectionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContentSites", "ContentSectionId", "dbo.ContentSections");
            DropForeignKey("dbo.ContentSections", "ContentLayoutId", "dbo.ContentLayouts");
            DropIndex("dbo.ContentSites", new[] { "ContentSectionId" });
            DropIndex("dbo.ContentSections", new[] { "ContentLayoutId" });
            DropTable("dbo.ContentSites");
            DropTable("dbo.ContentSections");
            DropTable("dbo.ContentLayouts");
        }
    }
}
