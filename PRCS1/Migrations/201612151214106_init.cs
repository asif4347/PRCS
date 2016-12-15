namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "PatientName", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "PresBy", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "Cause", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodDonorInfoes", "Cause");
            DropColumn("dbo.BloodDonorInfoes", "PresBy");
            DropColumn("dbo.BloodDonorInfoes", "PatientName");
        }
    }
}
