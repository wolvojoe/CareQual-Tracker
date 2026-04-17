namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        CareHomeId = c.Int(nullable: false),
                        Forename = c.String(),
                        Surname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        AnnualSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "RoleId", "dbo.Roles");
            DropIndex("dbo.Staffs", new[] { "RoleId" });
            DropTable("dbo.Roles");
            DropTable("dbo.Staffs");
        }
    }
}
