namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactorDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EldahanItems", "EldahanPresetId", "dbo.Web_Preset");
            DropForeignKey("dbo.Items", "SubCategory_Id", "dbo.SubCategories");
            DropForeignKey("dbo.ItemsModifiers", "EldahanItemsId", "dbo.EldahanItems");
            DropForeignKey("dbo.Modifiers", "EldahanItemsId", "dbo.EldahanItems");
            DropForeignKey("dbo.MyCartItems", "EldahanItemId", "dbo.EldahanItems");
            DropForeignKey("dbo.OrderedItems", "ItemId", "dbo.EldahanItems");
            DropForeignKey("dbo.OrderedItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.SelectedModifiers", "ItemModifierId", "dbo.EldahanItems");
            DropIndex("dbo.EldahanItems", new[] { "EldahanPresetId" });
            DropIndex("dbo.Items", new[] { "SubCategory_Id" });
            DropIndex("dbo.ItemsModifiers", new[] { "EldahanItemsId" });
            DropIndex("dbo.Modifiers", new[] { "EldahanItemsId" });
            DropIndex("dbo.MyCartItems", new[] { "EldahanItemId" });
            DropIndex("dbo.OrderedItems", new[] { "ItemId" });
            DropIndex("dbo.OrderedItems", new[] { "OrderId" });
            DropIndex("dbo.SelectedModifiers", new[] { "ItemModifierId" });
            DropPrimaryKey("dbo.ItemsModifiers");
            DropPrimaryKey("dbo.Modifiers");
            AddColumn("dbo.Items", "EldahanPresetId", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "WebOrder", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "Listed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "Available", c => c.Int(nullable: false));
            AddColumn("dbo.ItemsModifiers", "ItemId", c => c.Int(nullable: false));
            AddColumn("dbo.Modifiers", "ItemId", c => c.Int(nullable: false));
            AddColumn("dbo.MyCartItems", "ItemId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ItemsModifiers", new[] { "ItemId", "ModifiersGroupId" });
            AddPrimaryKey("dbo.Modifiers", new[] { "ModifiersGroupId", "ItemId" });
            CreateIndex("dbo.Items", "EldahanPresetId");
            CreateIndex("dbo.ItemsModifiers", "ItemId");
            CreateIndex("dbo.Modifiers", "ItemId");
            CreateIndex("dbo.MyCartItems", "ItemId");
            AddForeignKey("dbo.Items", "EldahanPresetId", "dbo.Web_Preset", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemsModifiers", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Modifiers", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MyCartItems", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            DropColumn("dbo.Items", "SubCategryId");
            DropColumn("dbo.Items", "SubCategory_Id");
            DropColumn("dbo.ItemsModifiers", "EldahanItemsId");
            DropColumn("dbo.Modifiers", "EldahanItemsId");
            DropColumn("dbo.MyCartItems", "EldahanItemId");
            DropTable("dbo.OrderedItems");
            DropTable("dbo.SelectedModifiers");
        }
        
        public override void Down()
        {
            
            
            CreateTable(
                "dbo.SelectedModifiers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        EldahanItemsId = c.Int(nullable: false),
                        ItemModifierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderedItems",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Ordered = c.Boolean(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => new { t.ItemId, t.OrderId });
            
            
            AddColumn("dbo.MyCartItems", "EldahanItemId", c => c.Int(nullable: false));
            AddColumn("dbo.Modifiers", "EldahanItemsId", c => c.Int(nullable: false));
            AddColumn("dbo.ItemsModifiers", "EldahanItemsId", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "SubCategory_Id", c => c.Int());
            AddColumn("dbo.Items", "SubCategryId", c => c.Int());
            DropForeignKey("dbo.MyCartItems", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Modifiers", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemsModifiers", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "EldahanPresetId", "dbo.Web_Preset");
            DropIndex("dbo.MyCartItems", new[] { "ItemId" });
            DropIndex("dbo.Modifiers", new[] { "ItemId" });
            DropIndex("dbo.ItemsModifiers", new[] { "ItemId" });
            DropIndex("dbo.Items", new[] { "EldahanPresetId" });
            DropPrimaryKey("dbo.Modifiers");
            DropPrimaryKey("dbo.ItemsModifiers");
            DropColumn("dbo.MyCartItems", "ItemId");
            DropColumn("dbo.Modifiers", "ItemId");
            DropColumn("dbo.ItemsModifiers", "ItemId");
            DropColumn("dbo.Items", "Available");
            DropColumn("dbo.Items", "Listed");
            DropColumn("dbo.Items", "WebOrder");
            DropColumn("dbo.Items", "EldahanPresetId");
            AddPrimaryKey("dbo.Modifiers", new[] { "ModifiersGroupId", "EldahanItemsId" });
            AddPrimaryKey("dbo.ItemsModifiers", new[] { "EldahanItemsId", "ModifiersGroupId" });
            CreateIndex("dbo.SelectedModifiers", "ItemModifierId");
            CreateIndex("dbo.OrderedItems", "OrderId");
            CreateIndex("dbo.OrderedItems", "ItemId");
            CreateIndex("dbo.MyCartItems", "EldahanItemId");
            CreateIndex("dbo.Modifiers", "EldahanItemsId");
            CreateIndex("dbo.ItemsModifiers", "EldahanItemsId");
            CreateIndex("dbo.Items", "SubCategory_Id");
            CreateIndex("dbo.EldahanItems", "EldahanPresetId");
            AddForeignKey("dbo.SelectedModifiers", "ItemModifierId", "dbo.EldahanItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderedItems", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderedItems", "ItemId", "dbo.EldahanItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MyCartItems", "EldahanItemId", "dbo.EldahanItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Modifiers", "EldahanItemsId", "dbo.EldahanItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemsModifiers", "EldahanItemsId", "dbo.EldahanItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Items", "SubCategory_Id", "dbo.SubCategories", "Id");
            AddForeignKey("dbo.EldahanItems", "EldahanPresetId", "dbo.Web_Preset", "Id", cascadeDelete: true);
        }
    }
}
