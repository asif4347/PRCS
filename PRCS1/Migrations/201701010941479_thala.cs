namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thala : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ThalassimiaInfoes", "DonorNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ThalassimiaInfoes", "DonorNumber");
        }
    }
}
