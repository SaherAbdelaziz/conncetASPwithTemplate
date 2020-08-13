namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEldahanTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 150),
                        Name2 = c.String(maxLength: 150),
                        BarCode = c.String(maxLength: 50),
                        CrossCode = c.Int(),
                        Taxable = c.Boolean(),
                        Assimbly = c.Boolean(),
                        EldahanPresetId = c.Int(nullable: false),
                        IsModifier = c.Boolean(),
                        StandAlone = c.Boolean(),
                        PrintOnChick = c.Boolean(),
                        PrintOnReport = c.Boolean(),
                        FollowItem = c.Boolean(),
                        Image_Item = c.Binary(storeType: "image"),
                        BackColor = c.String(maxLength: 50),
                        fontColor = c.String(maxLength: 50),
                        Cost = c.Double(),
                        OpenPrice = c.Boolean(),
                        StaticPrice = c.Double(),
                        Description1 = c.String(maxLength: 200),
                        Description2 = c.String(maxLength: 200),
                        Description3 = c.String(maxLength: 200),
                        Description4 = c.String(maxLength: 200),
                        ModPrice_0 = c.Boolean(),
                        ItemFont = c.String(maxLength: 50),
                        UseItemTimer = c.Boolean(),
                        ItemTimerValue = c.Int(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        NoServiceCharge = c.Boolean(),
                        Market_Price = c.Boolean(),
                        Item_Track = c.Boolean(),
                        PrintItemOnCheck = c.Boolean(),
                        IsParent = c.Boolean(),
                        Rest_ID_Active = c.Int(),
                        Open_Food = c.Boolean(),
                        Mod_Price = c.Double(),
                        Pre_Paid_Card = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EldahanPresets", t => t.EldahanPresetId, cascadeDelete: true)
                .Index(t => t.EldahanPresetId);
            
            CreateTable(
                "dbo.EldahanPresets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 50),
                        ImagePreset = c.Binary(storeType: "image"),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        UserId = c.Int(),
                        RestIdActive = c.Int(),
                        OutLetIdActive = c.Int(),
                        ByTime = c.Boolean(),
                        StartTime = c.Int(),
                        EndTime = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "EldahanPresetId", "dbo.EldahanPresets");
            DropIndex("dbo.Item", new[] { "EldahanPresetId" });
            DropTable("dbo.EldahanPresets");
            DropTable("dbo.Item");
        }
    }
}
