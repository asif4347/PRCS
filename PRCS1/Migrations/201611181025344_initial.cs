namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BloodDonorInfoes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BloodDonorInfoes", "Name", c => c.String());
        }
    }
}
