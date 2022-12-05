namespace BilDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bil",
                c => new
                    {
                        RegNr = c.String(nullable: false, maxLength: 128),
                        Mærke = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Aargang = c.Int(nullable: false),
                        kM = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegNr);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bil");
        }
    }
}
