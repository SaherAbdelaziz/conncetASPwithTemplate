namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModifersTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HD_Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Services = c.Double(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        UserID = c.Int(),
                        RestIDActive = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HD_Areas_Services",
                c => new
                    {
                        AreaId = c.Int(nullable: false),
                        OutLetId = c.Int(nullable: false),
                        Services = c.Double(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.AreaId, t.OutLetId })
                .ForeignKey("dbo.HD_Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.OutLets", t => t.OutLetId, cascadeDelete: true)
                .Index(t => t.AreaId)
                .Index(t => t.OutLetId);
            
            CreateTable(
                "dbo.OutLets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        RestId = c.Int(),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        UserId = c.Int(),
                        IpAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemsModifiers",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        ModifierId = c.Int(nullable: false),
                        Active = c.Boolean(),
                        Serial = c.Int(),
                        Modifier_ModifiersGroupId = c.Int(),
                        Modifier_ItemId = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItemId, t.ModifierId })
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Modifiers", t => new { t.Modifier_ModifiersGroupId, t.Modifier_ItemId })
                .Index(t => t.ItemId)
                .Index(t => new { t.Modifier_ModifiersGroupId, t.Modifier_ItemId });
            
            CreateTable(
                "dbo.Modifiers",
                c => new
                    {
                        ModifiersGroupId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        IndexItem = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        UserID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ModifiersGroupId, t.ItemId })
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.ModifiersGroups", t => t.ModifiersGroupId, cascadeDelete: true)
                .Index(t => t.ModifiersGroupId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.ModifiersGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        MultiPick = c.Boolean(),
                        AllawNoPick = c.Boolean(),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        MaxPick = c.Int(),
                        Pick_Follow_Item_Qty = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemsModifiers", new[] { "Modifier_ModifiersGroupId", "Modifier_ItemId" }, "dbo.Modifiers");
            DropForeignKey("dbo.Modifiers", "ModifiersGroupId", "dbo.ModifiersGroups");
            DropForeignKey("dbo.Modifiers", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemsModifiers", "ItemId", "dbo.Items");
            DropForeignKey("dbo.HD_Areas_Services", "OutLetId", "dbo.OutLets");
            DropForeignKey("dbo.HD_Areas_Services", "AreaId", "dbo.HD_Areas");
            DropIndex("dbo.Modifiers", new[] { "ItemId" });
            DropIndex("dbo.Modifiers", new[] { "ModifiersGroupId" });
            DropIndex("dbo.ItemsModifiers", new[] { "Modifier_ModifiersGroupId", "Modifier_ItemId" });
            DropIndex("dbo.ItemsModifiers", new[] { "ItemId" });
            DropIndex("dbo.HD_Areas_Services", new[] { "OutLetId" });
            DropIndex("dbo.HD_Areas_Services", new[] { "AreaId" });
            DropTable("dbo.ModifiersGroups");
            DropTable("dbo.Modifiers");
            DropTable("dbo.ItemsModifiers");
            DropTable("dbo.OutLets");
            DropTable("dbo.HD_Areas_Services");
            DropTable("dbo.HD_Areas");
        }
    }
}
