namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodCampusInfoes", "NoOfBagsDay1", c => c.Int(nullable: false));
            AddColumn("dbo.BloodCampusInfoes", "NoOfBagsDay2", c => c.Int(nullable: false));
            DropColumn("dbo.BloodCampusInfoes", "NoOfBags");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodCampusInfoes", "NoOfBags", c => c.Int(nullable: false));
            DropColumn("dbo.BloodCampusInfoes", "NoOfBagsDay2");
            DropColumn("dbo.BloodCampusInfoes", "NoOfBagsDay1");
        }
    }
}
