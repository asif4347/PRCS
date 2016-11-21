namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BloodCampusInfoes", "BloodCampus", c => c.String(nullable: false));
            AlterColumn("dbo.BloodCampusInfoes", "InstituteName", c => c.String(nullable: false));
            AlterColumn("dbo.BloodCampusInfoes", "InstituteAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BloodCampusInfoes", "InstituteAddress", c => c.String());
            AlterColumn("dbo.BloodCampusInfoes", "InstituteName", c => c.String());
            AlterColumn("dbo.BloodCampusInfoes", "BloodCampus", c => c.String());
        }
    }
}
