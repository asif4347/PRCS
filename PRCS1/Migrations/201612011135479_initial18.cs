namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "DonorReaction", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodDonorInfoes", "DonorReaction");
        }
    }
}
