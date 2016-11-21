namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BloodDonorInfoes", "RegNo", c => c.String(nullable: false));
            AlterColumn("dbo.BloodDonorInfoes", "DonorNo", c => c.String(nullable: false));
            AlterColumn("dbo.BloodDonorInfoes", "SonOf", c => c.String(nullable: false));
            AlterColumn("dbo.BloodDonorInfoes", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.BloodDonorInfoes", "BloodGroup", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BloodDonorInfoes", "BloodGroup", c => c.String());
            AlterColumn("dbo.BloodDonorInfoes", "Gender", c => c.String());
            AlterColumn("dbo.BloodDonorInfoes", "SonOf", c => c.String());
            AlterColumn("dbo.BloodDonorInfoes", "DonorNo", c => c.String());
            AlterColumn("dbo.BloodDonorInfoes", "RegNo", c => c.String());
        }
    }
}
