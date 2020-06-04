namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeModifierToModieverGrpoupAsIunderstand : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemsModifiers", new[] { "Modifier_ModifiersGroupId", "Modifier_ItemId" }, "dbo.Modifiers");
            DropIndex("dbo.ItemsModifiers", new[] { "Modifier_ModifiersGroupId", "Modifier_ItemId" });
            DropPrimaryKey("dbo.ItemsModifiers");
            AddColumn("dbo.ItemsModifiers", "ModifiersGroupId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ItemsModifiers", new[] { "ItemId", "ModifiersGroupId" });
            CreateIndex("dbo.ItemsModifiers", "ModifiersGroupId");
            AddForeignKey("dbo.ItemsModifiers", "ModifiersGroupId", "dbo.ModifiersGroups", "Id", cascadeDelete: true);
            DropColumn("dbo.ItemsModifiers", "ModifierId");
            DropColumn("dbo.ItemsModifiers", "Modifier_ModifiersGroupId");
            DropColumn("dbo.ItemsModifiers", "Modifier_ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemsModifiers", "Modifier_ItemId", c => c.Int());
            AddColumn("dbo.ItemsModifiers", "Modifier_ModifiersGroupId", c => c.Int());
            AddColumn("dbo.ItemsModifiers", "ModifierId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ItemsModifiers", "ModifiersGroupId", "dbo.ModifiersGroups");
            DropIndex("dbo.ItemsModifiers", new[] { "ModifiersGroupId" });
            DropPrimaryKey("dbo.ItemsModifiers");
            DropColumn("dbo.ItemsModifiers", "ModifiersGroupId");
            AddPrimaryKey("dbo.ItemsModifiers", new[] { "ItemId", "ModifierId" });
            CreateIndex("dbo.ItemsModifiers", new[] { "Modifier_ModifiersGroupId", "Modifier_ItemId" });
            AddForeignKey("dbo.ItemsModifiers", new[] { "Modifier_ModifiersGroupId", "Modifier_ItemId" }, "dbo.Modifiers", new[] { "ModifiersGroupId", "ItemId" });
        }
    }
}
