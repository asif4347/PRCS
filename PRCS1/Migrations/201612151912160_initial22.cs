namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial22 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.PatientInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PatientInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientName = c.String(nullable: false),
                        PresBy = c.String(nullable: false),
                        Cause = c.String(nullable: false),
                        crossMatch = c.String(nullable: false),
                        issueDate = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        AdverseReaction = c.String(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
