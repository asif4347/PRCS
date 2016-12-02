namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial16 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BloodDonorInfoes", "TelResidance");
            DropColumn("dbo.BloodDonorInfoes", "FAX");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "FAX", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "TelResidance", c => c.String());
        }
    }
}
