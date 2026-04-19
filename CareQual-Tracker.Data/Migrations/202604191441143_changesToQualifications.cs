namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesToQualifications : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Qualifications", "Name", c => c.String());
            AddColumn("dbo.Qualifications", "AwardingBody", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Qualifications", "AwardingBody");
            DropColumn("dbo.Qualifications", "Name");
        }
    }
}
