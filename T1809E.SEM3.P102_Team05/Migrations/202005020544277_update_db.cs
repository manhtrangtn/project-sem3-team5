namespace T1809E.SEM3.P102_Team05.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_db : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "InStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "InStock");
        }
    }
}
