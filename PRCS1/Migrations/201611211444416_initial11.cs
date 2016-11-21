namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodCampusInfoes", "StartTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodCampusInfoes", "StartTime");
        }
    }
}
