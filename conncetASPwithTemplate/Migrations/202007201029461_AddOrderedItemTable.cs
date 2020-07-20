namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderedItemTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderedItems",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Ordered = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.ItemId, t.OrderId })
                .ForeignKey("dbo.EldahanItems", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderedItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderedItems", "ItemId", "dbo.EldahanItems");
            DropIndex("dbo.OrderedItems", new[] { "OrderId" });
            DropIndex("dbo.OrderedItems", new[] { "ItemId" });
            DropTable("dbo.OrderedItems");
        }
    }
}
