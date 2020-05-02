namespace T1809E.SEM3.P102_Team05.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.String(),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        OrderNumber = c.Double(nullable: false),
                        ShippingAddress = c.String(),
                        Total = c.Double(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            AddColumn("dbo.Products", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.Products", "UpdateAt", c => c.DateTime());
            AlterColumn("dbo.Products", "DeleteAt", c => c.DateTime());
            DropColumn("dbo.Products", "CreateAt");
            DropColumn("dbo.Products", "InStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "InStock", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "CreateAt", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            AlterColumn("dbo.Products", "DeleteAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "UpdateAt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "CreatedAt");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
        }
    }
}
