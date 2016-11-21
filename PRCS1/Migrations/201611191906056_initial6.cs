namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BloodDonorInfoes", "RegNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "RegNo", c => c.String(nullable: false));
        }
    }
}
