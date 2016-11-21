namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BloodDonorInfoes", "Adress", c => c.String(nullable: false));
            AlterColumn("dbo.BloodDonorInfoes", "District", c => c.String(nullable: false));
            AlterColumn("dbo.BloodDonorInfoes", "PermanentDonor", c => c.String(nullable: false));
            AlterColumn("dbo.BloodDonorInfoes", "TTIScreening", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BloodDonorInfoes", "TTIScreening", c => c.String());
            AlterColumn("dbo.BloodDonorInfoes", "PermanentDonor", c => c.String());
            AlterColumn("dbo.BloodDonorInfoes", "District", c => c.String());
            AlterColumn("dbo.BloodDonorInfoes", "Adress", c => c.String());
        }
    }
}
