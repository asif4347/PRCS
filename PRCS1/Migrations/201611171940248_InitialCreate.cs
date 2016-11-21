namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodDonorInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RegNo = c.String(),
                        DonorNo = c.String(),
                        SerialNo = c.String(),
                        Name = c.String(),
                        SonOf = c.String(),
                        Gender = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Weight = c.Single(nullable: false),
                        BloodGroup = c.String(),
                        LastDonation = c.DateTime(nullable: false),
                        NoOfDonation = c.Int(nullable: false),
                        Institute = c.String(),
                        Class = c.String(),
                        TelResidance = c.String(),
                        TelOffice = c.String(),
                        FAX = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BloodDonorInfoes");
        }
    }
}
