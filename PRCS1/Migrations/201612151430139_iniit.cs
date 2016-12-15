namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iniit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "crossMatch", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "issueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BloodDonorInfoes", "StartTime", c => c.DateTime());
            AddColumn("dbo.BloodDonorInfoes", "AdverseReaction", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "Details", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodDonorInfoes", "Details");
            DropColumn("dbo.BloodDonorInfoes", "AdverseReaction");
            DropColumn("dbo.BloodDonorInfoes", "StartTime");
            DropColumn("dbo.BloodDonorInfoes", "issueDate");
            DropColumn("dbo.BloodDonorInfoes", "crossMatch");
        }
    }
}
