namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CareGroups",
                c => new
                    {
                        CareGroupId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CareGroupId);
            
            CreateTable(
                "dbo.CareHomes",
                c => new
                    {
                        CareHomeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CareHomeId);
            
            CreateTable(
                "dbo.CareQualTrackerUsers",
                c => new
                    {
                        CareQualTrackerUserId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CareQualTrackerUserId);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        QualificationId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.QualificationId);
            
            CreateTable(
                "dbo.SalaryFrequencies",
                c => new
                    {
                        SalaryFrequencyId = c.Int(nullable: false, identity: true),
                        SalaryFrequencyName = c.String(),
                    })
                .PrimaryKey(t => t.SalaryFrequencyId);
            
            CreateTable(
                "dbo.StaffQualifications",
                c => new
                    {
                        StaffQualificationId = c.Int(nullable: false, identity: true),
                        Grade = c.String(),
                        CertificateDocument = c.String(),
                        AttainmentDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        StaffId = c.Int(nullable: false),
                        QualificationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaffQualificationId)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.QualificationId);
            
            CreateTable(
                "dbo.StaffSalaries",
                c => new
                    {
                        StaffSalaryId = c.Int(nullable: false, identity: true),
                        SalaryAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StaffId = c.Int(nullable: false),
                        SalaryFrequencyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaffSalaryId)
                .ForeignKey("dbo.SalaryFrequencies", t => t.SalaryFrequencyId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.SalaryFrequencyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaffSalaries", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.StaffSalaries", "SalaryFrequencyId", "dbo.SalaryFrequencies");
            DropForeignKey("dbo.StaffQualifications", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.StaffQualifications", "QualificationId", "dbo.Qualifications");
            DropIndex("dbo.StaffSalaries", new[] { "SalaryFrequencyId" });
            DropIndex("dbo.StaffSalaries", new[] { "StaffId" });
            DropIndex("dbo.StaffQualifications", new[] { "QualificationId" });
            DropIndex("dbo.StaffQualifications", new[] { "StaffId" });
            DropTable("dbo.StaffSalaries");
            DropTable("dbo.StaffQualifications");
            DropTable("dbo.SalaryFrequencies");
            DropTable("dbo.Qualifications");
            DropTable("dbo.CareQualTrackerUsers");
            DropTable("dbo.CareHomes");
            DropTable("dbo.CareGroups");
        }
    }
}
