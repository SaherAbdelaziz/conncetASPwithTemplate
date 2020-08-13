namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addItemToCheckItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChecksItems", "ItemId", c => c.Int());
            CreateIndex("dbo.ChecksItems", "ItemId");
            AddForeignKey("dbo.ChecksItems", "ItemId", "dbo.Item", "Id");
            DropColumn("dbo.ChecksItems", "Item_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ChecksItems", "Item_ID", c => c.Int());
            DropForeignKey("dbo.ChecksItems", "ItemId", "dbo.Item");
            DropIndex("dbo.ChecksItems", new[] { "ItemId" });
            DropColumn("dbo.ChecksItems", "ItemId");
        }
    }
}
