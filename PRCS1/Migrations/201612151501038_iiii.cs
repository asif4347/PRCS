namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iiii : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BloodDonorInfoes", "StartTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "StartTime", c => c.DateTime());
        }
    }
}
