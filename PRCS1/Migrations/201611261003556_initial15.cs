namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "HBsAg", c => c.String(nullable: false));
            AddColumn("dbo.BloodDonorInfoes", "HCV", c => c.String(nullable: false));
            AddColumn("dbo.BloodDonorInfoes", "HIV", c => c.String(nullable: false));
            AddColumn("dbo.BloodDonorInfoes", "Syphilis", c => c.String(nullable: false));
            AddColumn("dbo.BloodDonorInfoes", "Malaria", c => c.String(nullable: false));
            DropColumn("dbo.BloodDonorInfoes", "TTIScreening");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "TTIScreening", c => c.String(nullable: false));
            DropColumn("dbo.BloodDonorInfoes", "Malaria");
            DropColumn("dbo.BloodDonorInfoes", "Syphilis");
            DropColumn("dbo.BloodDonorInfoes", "HIV");
            DropColumn("dbo.BloodDonorInfoes", "HCV");
            DropColumn("dbo.BloodDonorInfoes", "HBsAg");
        }
    }
}
