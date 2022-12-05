namespace BilDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateV1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bil", "kM", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bil", "kM", c => c.Int(nullable: false));
        }
    }
}
