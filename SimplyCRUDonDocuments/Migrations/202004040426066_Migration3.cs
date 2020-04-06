namespace SimplyCRUDonDocuments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentPositions", "DocumentId", c => c.Int(nullable: false));
            CreateIndex("dbo.DocumentPositions", "DocumentId");
            AddForeignKey("dbo.DocumentPositions", "DocumentId", "dbo.DocumentHeader", "DocumentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentPositions", "DocumentId", "dbo.DocumentHeader");
            DropIndex("dbo.DocumentPositions", new[] { "DocumentId" });
            DropColumn("dbo.DocumentPositions", "DocumentId");
        }
    }
}
