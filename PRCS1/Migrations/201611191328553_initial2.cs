namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "Adress", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "District", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "PermanentDonor", c => c.String());
            AddColumn("dbo.BloodDonorInfoes", "TTIScreening", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodDonorInfoes", "TTIScreening");
            DropColumn("dbo.BloodDonorInfoes", "PermanentDonor");
            DropColumn("dbo.BloodDonorInfoes", "District");
            DropColumn("dbo.BloodDonorInfoes", "Adress");
        }
    }
}
