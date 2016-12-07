namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodDonorInfoes", "isSelected", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodDonorInfoes", "isSelected");
        }
    }
}
