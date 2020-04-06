namespace SimplyCRUDonDocuments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracja2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentHeader", "NumerKlienta", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DocumentHeader", "NumerKlienta");
        }
    }
}
