namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarehomeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CareHomes", "CareHomeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CareHomes", "CareHomeName");
        }
    }
}
