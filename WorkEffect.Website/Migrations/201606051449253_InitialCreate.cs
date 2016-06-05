namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Layouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HtmlContainer = c.String(),
                        LayoutType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Order = c.Int(nullable: false),
                        Content = c.String(),
                        Image = c.String(),
                        LayoutId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Layouts", t => t.LayoutId, cascadeDelete: true)
                .Index(t => t.LayoutId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sections", "LayoutId", "dbo.Layouts");
            DropIndex("dbo.Sections", new[] { "LayoutId" });
            DropTable("dbo.Sections");
            DropTable("dbo.Layouts");
        }
    }
}
