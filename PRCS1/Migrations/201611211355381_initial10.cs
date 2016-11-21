namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodCampusInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BloodCampus = c.String(),
                        OrganizedDate = c.DateTime(nullable: false),
                        InstituteName = c.String(),
                        InstituteAddress = c.String(),
                        InstituteDistrict = c.String(),
                        DeansContact = c.String(),
                        SocietyContact = c.String(),
                        NoOfBags = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BloodCampusInfoes");
        }
    }
}
