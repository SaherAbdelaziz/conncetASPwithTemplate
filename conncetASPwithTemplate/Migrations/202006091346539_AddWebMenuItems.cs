namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWebMenuItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebMenuItems",
                c => new
                    {
                        SerialId = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(),
                        SortNumber = c.Int(),
                        PresetId = c.Int(),
                        ModifiedDate = c.DateTime(),
                        UserId = c.Int(),
                        RestIdActive = c.Int(),
                        OutLetIdActive = c.Int(),
                    })
                .PrimaryKey(t => t.SerialId)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .ForeignKey("dbo.WebPresets", t => t.PresetId)
                .Index(t => t.ItemId)
                .Index(t => t.PresetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WebMenuItems", "PresetId", "dbo.WebPresets");
            DropForeignKey("dbo.WebMenuItems", "ItemId", "dbo.Items");
            DropIndex("dbo.WebMenuItems", new[] { "PresetId" });
            DropIndex("dbo.WebMenuItems", new[] { "ItemId" });
            DropTable("dbo.WebMenuItems");
        }
    }
}
