namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        CustomerPhone = c.String(),
                        DateCreated = c.DateTime(),
                        Price = c.Double(nullable: false),
                        Delivery = c.Double(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        OutLetId = c.Int(nullable: false),
                        HdAreasId = c.Int(nullable: false),
                        ServicesId = c.Int(nullable: false),
                        CartId = c.String(),
                        Details = c.String(),
                        Services_AreaId = c.Int(),
                        Services_OutLetId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HD_Areas", t => t.HdAreasId, cascadeDelete: true)
                .ForeignKey("dbo.OutLets", t => t.OutLetId, cascadeDelete: true)
                .ForeignKey("dbo.HD_Areas_Services", t => new { t.Services_AreaId, t.Services_OutLetId })
                .Index(t => t.OutLetId)
                .Index(t => t.HdAreasId)
                .Index(t => new { t.Services_AreaId, t.Services_OutLetId });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", new[] { "Services_AreaId", "Services_OutLetId" }, "dbo.HD_Areas_Services");
            DropForeignKey("dbo.Orders", "OutLetId", "dbo.OutLets");
            DropForeignKey("dbo.Orders", "HdAreasId", "dbo.HD_Areas");
            DropIndex("dbo.Orders", new[] { "Services_AreaId", "Services_OutLetId" });
            DropIndex("dbo.Orders", new[] { "HdAreasId" });
            DropIndex("dbo.Orders", new[] { "OutLetId" });
            DropTable("dbo.Orders");
        }
    }
}
