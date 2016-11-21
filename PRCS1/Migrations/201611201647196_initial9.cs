namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial9 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BloodDonorInfoes", "DonorReaction");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodDonorInfoes", "DonorReaction", c => c.String(nullable: false));
        }
    }
}
