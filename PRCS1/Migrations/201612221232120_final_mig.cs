namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final_mig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "Other", c => c.String());
            DropColumn("dbo.BloodDonorInfoes", "Haematioma");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "Haematioma", c => c.String());
            DropColumn("dbo.BloodDonorInfoes", "Other");
        }
    }
}
