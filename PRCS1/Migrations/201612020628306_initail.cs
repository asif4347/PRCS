namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "Haematioma", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "Nausia", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "Vom", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "Dizziness", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "Fainting", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "Convulsions", c => c.String());
            AlterColumn("dbo.BloodDonorInfoes", "DonorReaction", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BloodDonorInfoes", "DonorReaction", c => c.String(nullable: false));
            DropColumn("dbo.BloodDonorInfoes", "Convulsions");
            DropColumn("dbo.BloodDonorInfoes", "Fainting");
            DropColumn("dbo.BloodDonorInfoes", "Dizziness");
            DropColumn("dbo.BloodDonorInfoes", "Vom");
            DropColumn("dbo.BloodDonorInfoes", "Nausia");
            DropColumn("dbo.BloodDonorInfoes", "Haematioma");
        }
    }
}
