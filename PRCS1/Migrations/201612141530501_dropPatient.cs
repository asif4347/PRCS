namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropPatient : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BloodDonorInfoes", "PatientName");
            DropColumn("dbo.BloodDonorInfoes", "PresBy");
            DropColumn("dbo.BloodDonorInfoes", "cause");
            DropColumn("dbo.BloodDonorInfoes", "crossMatch");
            DropColumn("dbo.BloodDonorInfoes", "issueDate");
            DropColumn("dbo.BloodDonorInfoes", "issueTime");
            DropColumn("dbo.BloodDonorInfoes", "AdverseReaction");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "AdverseReaction", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "issueTime", c => c.DateTime());
            AddColumn("dbo.BloodDonorInfoes", "issueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BloodDonorInfoes", "crossMatch", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "cause", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "PresBy", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "PatientName", c => c.String());
        }
    }
}
