namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CareQualUsers",
                c => new
                    {
                        CareQualUserId = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        PasswordHash = c.String(),
                        PasswordSalt = c.String(),
                    })
                .PrimaryKey(t => t.CareQualUserId);
            
            DropTable("dbo.CareGroups");
            DropTable("dbo.CareQualTrackerUsers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CareQualTrackerUsers",
                c => new
                    {
                        CareQualTrackerUserId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CareQualTrackerUserId);
            
            CreateTable(
                "dbo.CareGroups",
                c => new
                    {
                        CareGroupId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CareGroupId);
            
            DropTable("dbo.CareQualUsers");
        }
    }
}
