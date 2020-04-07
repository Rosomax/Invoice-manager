namespace SimplyCRUDonDocuments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationAddColumsRazem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentPositions", "RazemNetto", c => c.Double(nullable: false));
            AddColumn("dbo.DocumentPositions", "RazemBrutto", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DocumentPositions", "RazemBrutto");
            DropColumn("dbo.DocumentPositions", "RazemNetto");
        }
    }
}
