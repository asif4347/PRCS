namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BloodDonorInfoes", "PatientName");
            DropColumn("dbo.BloodDonorInfoes", "PresBy");
            DropColumn("dbo.BloodDonorInfoes", "Cause");
            DropColumn("dbo.BloodDonorInfoes", "crossMatch");
            DropColumn("dbo.BloodDonorInfoes", "issueDate");
            DropColumn("dbo.BloodDonorInfoes", "StartTime");
            DropColumn("dbo.BloodDonorInfoes", "AdverseReaction");
            DropColumn("dbo.BloodDonorInfoes", "Details");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "Details", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "AdverseReaction", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "StartTime", c => c.DateTime());
            AddColumn("dbo.BloodDonorInfoes", "issueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BloodDonorInfoes", "crossMatch", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "Cause", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "PresBy", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "PatientName", c => c.String());
        }
    }
}
