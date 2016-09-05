namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContentLayoutParameter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContentLayoutParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Index = c.Int(nullable: false),
                        Name = c.String(),
                        ContentLayoutId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContentLayouts", t => t.ContentLayoutId, cascadeDelete: true)
                .Index(t => t.ContentLayoutId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContentLayoutParameters", "ContentLayoutId", "dbo.ContentLayouts");
            DropIndex("dbo.ContentLayoutParameters", new[] { "ContentLayoutId" });
            DropTable("dbo.ContentLayoutParameters");
        }
    }
}
