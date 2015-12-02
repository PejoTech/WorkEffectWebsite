using Microsoft.AspNet.Identity;

namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddCmsBaseTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CmsCells",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    CmsRowId = c.Guid(nullable: false),
                    Html = c.String(),
                    Css = c.String(),
                    JavaScript = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedOn = c.DateTime(nullable: false),
                    CreatedById = c.Guid(nullable: false),
                    UpdatedOn = c.DateTime(nullable: false),
                    UpdatedById = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CmsRows", t => t.CmsRowId, cascadeDelete: true)
                .Index(t => t.CmsRowId);

            CreateTable(
                "dbo.CmsParts",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    CmsCellId = c.Guid(nullable: false),
                    Index = c.Int(nullable: false),
                    ContentType = c.Int(nullable: false),
                    Hidden = c.Boolean(nullable: false),
                    Name = c.String(maxLength: 160),
                    Html = c.String(),
                    Css = c.String(),
                    JavaScript = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedOn = c.DateTime(nullable: false),
                    CreatedById = c.Guid(nullable: false),
                    UpdatedOn = c.DateTime(nullable: false),
                    UpdatedById = c.Guid(nullable: false),
                    CmsResource_Id = c.Guid(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CmsResources", t => t.CmsResource_Id)
                .ForeignKey("dbo.CmsCells", t => t.CmsCellId, cascadeDelete: true)
                .Index(t => t.CmsCellId)
                .Index(t => t.Index, unique: true)
                .Index(t => t.CmsResource_Id);

            CreateTable(
                "dbo.CmsResources",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    Content = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedOn = c.DateTime(nullable: false),
                    CreatedById = c.Guid(nullable: false),
                    UpdatedOn = c.DateTime(nullable: false),
                    UpdatedById = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.CmsGrids",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    CmsGridId = c.Guid(nullable: false),
                    Html = c.String(),
                    Css = c.String(),
                    JavaScript = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedOn = c.DateTime(nullable: false),
                    CreatedById = c.Guid(nullable: false),
                    UpdatedOn = c.DateTime(nullable: false),
                    UpdatedById = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CmsGrids", t => t.CmsGridId)
                .Index(t => t.CmsGridId);

            CreateTable(
                "dbo.CmsRows",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    CmsGridId = c.Guid(nullable: false),
                    Html = c.String(),
                    Css = c.String(),
                    JavaScript = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedOn = c.DateTime(nullable: false),
                    CreatedById = c.Guid(nullable: false),
                    UpdatedOn = c.DateTime(nullable: false),
                    UpdatedById = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CmsGrids", t => t.CmsGridId, cascadeDelete: true)
                .Index(t => t.CmsGridId);

            CreateTable(
                "dbo.CmsPages",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    CmsGridId = c.Guid(nullable: false),
                    Name = c.String(maxLength: 160),
                    Html = c.String(),
                    Css = c.String(),
                    JavaScript = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedOn = c.DateTime(nullable: false),
                    CreatedById = c.Guid(nullable: false),
                    UpdatedOn = c.DateTime(nullable: false),
                    UpdatedById = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CmsGrids", t => t.CmsGridId, cascadeDelete: true)
                .Index(t => t.CmsGridId);

            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(),
                    Email = c.String(maxLength: 256),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false, maxLength: 128),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                {
                    LoginProvider = c.String(nullable: false, maxLength: 128),
                    ProviderKey = c.String(nullable: false, maxLength: 128),
                    UserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            var pwHash = new PasswordHasher();
            var password = pwHash.HashPassword("123456");

            Sql(
                "INSERT INTO[dbo].[AspNetUsers]" +
                "([Id]" +
                ",[Name]" +
                ",[Email]" +
                ",[EmailConfirmed]" +
                ",[UserName]" +
                ",[PhoneNumberConfirmed]" +
                ",[TwoFactorEnabled]" +
                ",[LockoutEnabled]" +
                ",[AccessFailedCount]" +
                ",[PasswordHash]" +
                ")" +
                "VALUES" +
                "('" + Guid.NewGuid() + "'" +
                ", 'Admin'" +
                ", 'admin@asd.ch'" +
                ", 1" +
                ", 'Admin'" +
                ", 1" +
                ", 0" +
                ", 0" +
                ", 0" +
                ", '" + password + "'" +
                ")");

            Sql("INSERT INTO[dbo].[AspNetUsers]" +
                "([Id]" +
                ",[Name]" +
                ",[Email]" +
                ",[EmailConfirmed]" +
                ",[UserName]" +
                ",[PhoneNumberConfirmed]" +
                ",[TwoFactorEnabled]" +
                ",[LockoutEnabled]" +
                ",[AccessFailedCount]" +
                ")" +
                "VALUES" +
                "('" + Guid.NewGuid() + "'" +
                ", 'System'" +
                ", 'systen@asd.ch'" +
                ", 1" +
                ", 'System'" +
                ", 1" +
                ", 0" +
                ", 0" +
                ", 0" +
                ")");
        }

        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.CmsPages", "CmsGridId", "dbo.CmsGrids");
            DropForeignKey("dbo.CmsRows", "CmsGridId", "dbo.CmsGrids");
            DropForeignKey("dbo.CmsCells", "CmsRowId", "dbo.CmsRows");
            DropForeignKey("dbo.CmsGrids", "CmsGridId", "dbo.CmsGrids");
            DropForeignKey("dbo.CmsParts", "CmsCellId", "dbo.CmsCells");
            DropForeignKey("dbo.CmsParts", "CmsResource_Id", "dbo.CmsResources");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.CmsPages", new[] { "CmsGridId" });
            DropIndex("dbo.CmsRows", new[] { "CmsGridId" });
            DropIndex("dbo.CmsGrids", new[] { "CmsGridId" });
            DropIndex("dbo.CmsParts", new[] { "CmsResource_Id" });
            DropIndex("dbo.CmsParts", new[] { "Index" });
            DropIndex("dbo.CmsParts", new[] { "CmsCellId" });
            DropIndex("dbo.CmsCells", new[] { "CmsRowId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.CmsPages");
            DropTable("dbo.CmsRows");
            DropTable("dbo.CmsGrids");
            DropTable("dbo.CmsResources");
            DropTable("dbo.CmsParts");
            DropTable("dbo.CmsCells");
        }
    }
}
