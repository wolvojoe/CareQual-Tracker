namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDeleteToQual : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Qualifications", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Qualifications", "IsDeleted");
        }
    }
}
