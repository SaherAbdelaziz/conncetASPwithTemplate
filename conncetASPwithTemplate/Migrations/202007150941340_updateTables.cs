namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EldahanPresets", newName: "Web_Preset");
            RenameTable(name: "dbo.WebMenuItems", newName: "Web_Menu_Item");
            AddColumn("dbo.Item", "WebOrder", c => c.Boolean(nullable: false , defaultValue: true));
            AddColumn("dbo.Orders", "OrderState", c => c.Int(nullable: false , defaultValue: 0));
            AddColumn("dbo.Orders", "OrderPrepare", c => c.Int(nullable: false , defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderPrepare");
            DropColumn("dbo.Orders", "OrderState");
            DropColumn("dbo.Item", "WebOrder");
            RenameTable(name: "dbo.Web_Menu_Item", newName: "WebMenuItems");
            RenameTable(name: "dbo.Web_Preset", newName: "EldahanPresets");
        }
    }
}
