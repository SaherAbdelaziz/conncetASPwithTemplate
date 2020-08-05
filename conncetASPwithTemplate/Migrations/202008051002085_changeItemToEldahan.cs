namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeItemToEldahan : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemsModifiers", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Modifiers", "ItemId", "dbo.Items");
            DropIndex("dbo.ItemsModifiers", new[] { "ItemId" });
            DropIndex("dbo.Modifiers", new[] { "ItemId" });
            DropPrimaryKey("dbo.ItemsModifiers");
            DropPrimaryKey("dbo.Modifiers");
            AddColumn("dbo.ItemsModifiers", "EldahanItemsId", c => c.Int(nullable: false));
            AddColumn("dbo.Modifiers", "EldahanItemsId", c => c.Int(nullable: false));
            AddColumn("dbo.SelectedModifiers", "EldahanItemsId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ItemsModifiers", new[] { "EldahanItemsId", "ModifiersGroupId" });
            AddPrimaryKey("dbo.Modifiers", new[] { "ModifiersGroupId", "EldahanItemsId" });
            CreateIndex("dbo.ItemsModifiers", "EldahanItemsId");
            CreateIndex("dbo.Modifiers", "EldahanItemsId");
            AddForeignKey("dbo.ItemsModifiers", "EldahanItemsId", "dbo.EldahanItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Modifiers", "EldahanItemsId", "dbo.EldahanItems", "Id", cascadeDelete: true);
            DropColumn("dbo.ItemsModifiers", "ItemId");
            DropColumn("dbo.Modifiers", "ItemId");
            DropColumn("dbo.SelectedModifiers", "ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SelectedModifiers", "ItemId", c => c.Int(nullable: false));
            AddColumn("dbo.Modifiers", "ItemId", c => c.Int(nullable: false));
            AddColumn("dbo.ItemsModifiers", "ItemId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Modifiers", "EldahanItemsId", "dbo.EldahanItems");
            DropForeignKey("dbo.ItemsModifiers", "EldahanItemsId", "dbo.EldahanItems");
            DropIndex("dbo.Modifiers", new[] { "EldahanItemsId" });
            DropIndex("dbo.ItemsModifiers", new[] { "EldahanItemsId" });
            DropPrimaryKey("dbo.Modifiers");
            DropPrimaryKey("dbo.ItemsModifiers");
            DropColumn("dbo.SelectedModifiers", "EldahanItemsId");
            DropColumn("dbo.Modifiers", "EldahanItemsId");
            DropColumn("dbo.ItemsModifiers", "EldahanItemsId");
            AddPrimaryKey("dbo.Modifiers", new[] { "ModifiersGroupId", "ItemId" });
            AddPrimaryKey("dbo.ItemsModifiers", new[] { "ItemId", "ModifiersGroupId" });
            CreateIndex("dbo.Modifiers", "ItemId");
            CreateIndex("dbo.ItemsModifiers", "ItemId");
            AddForeignKey("dbo.Modifiers", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemsModifiers", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
    }
}
