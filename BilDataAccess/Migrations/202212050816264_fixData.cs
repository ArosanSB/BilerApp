namespace BilDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixData : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bil");
            AlterColumn("dbo.Bil", "RegNr", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Bil", "Mærke", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Bil", "Model", c => c.String(nullable: false, maxLength: 120));
            AddPrimaryKey("dbo.Bil", "RegNr");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bil");
            AlterColumn("dbo.Bil", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.Bil", "Mærke", c => c.String(nullable: false));
            AlterColumn("dbo.Bil", "RegNr", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Bil", "RegNr");
        }
    }
}
