namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "Sr", c => c.Int(nullable: false));
            DropColumn("dbo.BloodDonorInfoes", "SerialNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "SerialNo", c => c.String());
            DropColumn("dbo.BloodDonorInfoes", "Sr");
        }
    }
}
