namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thalasimai : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThalassimiaInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        ThelesemiaStatus = c.String(),
                        RegOrIrreg = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThalassimiaInfoes");
        }
    }
}
