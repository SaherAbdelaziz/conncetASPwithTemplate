namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactorDataBase2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CartItems", "ItemId", "dbo.Items");
            DropIndex("dbo.CartItems", new[] { "ItemId" });
            RenameColumn(table: "dbo.Items", name: "EldahanPresetId", newName: "WebPresetId");
            RenameIndex(table: "dbo.Items", name: "IX_EldahanPresetId", newName: "IX_WebPresetId");
            DropTable("dbo.CartItems");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        Quantity = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Removed = c.Boolean(nullable: false),
                        Details = c.String(),
                        HasModifiers = c.Boolean(nullable: false),
                        Ordered = c.Boolean(nullable: false),
                        ItemId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            RenameIndex(table: "dbo.Items", name: "IX_WebPresetId", newName: "IX_EldahanPresetId");
            RenameColumn(table: "dbo.Items", name: "WebPresetId", newName: "EldahanPresetId");
            CreateIndex("dbo.CartItems", "ItemId");
            AddForeignKey("dbo.CartItems", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
    }
}
