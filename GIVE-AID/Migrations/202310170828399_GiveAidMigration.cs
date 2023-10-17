namespace GIVE_AID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GiveAidMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Causes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CauseName = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonationDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        CauseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Causes", t => t.CauseId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CauseId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Avatar = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NGOes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FullName = c.String(),
                        Gender = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Address = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.UsersRolesMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 255),
                        ImagePath = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        Author = c.String(nullable: false, maxLength: 255),
                        TypeOfNews = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "UserId", "dbo.Users");
            DropForeignKey("dbo.Donations", "CauseId", "dbo.Causes");
            DropForeignKey("dbo.Donations", "UserId", "dbo.Users");
            DropForeignKey("dbo.UsersRolesMappings", "UserId", "dbo.Users");
            DropForeignKey("dbo.UsersRolesMappings", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserDetails", "Id", "dbo.Users");
            DropForeignKey("dbo.NGOes", "UserId", "dbo.Users");
            DropIndex("dbo.News", new[] { "UserId" });
            DropIndex("dbo.UsersRolesMappings", new[] { "RoleId" });
            DropIndex("dbo.UsersRolesMappings", new[] { "UserId" });
            DropIndex("dbo.UserDetails", new[] { "Id" });
            DropIndex("dbo.NGOes", new[] { "UserId" });
            DropIndex("dbo.Donations", new[] { "CauseId" });
            DropIndex("dbo.Donations", new[] { "UserId" });
            DropTable("dbo.News");
            DropTable("dbo.Roles");
            DropTable("dbo.UsersRolesMappings");
            DropTable("dbo.UserDetails");
            DropTable("dbo.NGOes");
            DropTable("dbo.Users");
            DropTable("dbo.Donations");
            DropTable("dbo.Causes");
        }
    }
}
