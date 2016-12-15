namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "PatientName", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "PresBy", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "cause", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "crossMatch", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "issueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BloodDonorInfoes", "issueTime", c => c.DateTime());
            AddColumn("dbo.BloodDonorInfoes", "AdverseReaction", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodDonorInfoes", "AdverseReaction");
            DropColumn("dbo.BloodDonorInfoes", "issueTime");
            DropColumn("dbo.BloodDonorInfoes", "issueDate");
            DropColumn("dbo.BloodDonorInfoes", "crossMatch");
            DropColumn("dbo.BloodDonorInfoes", "cause");
            DropColumn("dbo.BloodDonorInfoes", "PresBy");
            DropColumn("dbo.BloodDonorInfoes", "PatientName");
        }
    }
}
