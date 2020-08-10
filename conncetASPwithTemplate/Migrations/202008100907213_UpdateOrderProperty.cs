namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderProperty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "HdAreasId", "dbo.HD_Areas");
            DropForeignKey("dbo.Orders", "OutLetId", "dbo.OutLets");
            DropForeignKey("dbo.Orders", new[] { "Services_AreaId", "Services_OutLetId" }, "dbo.HD_Areas_Services");
            DropIndex("dbo.Orders", new[] { "OutLetId" });
            DropIndex("dbo.Orders", new[] { "HdAreasId" });
            DropIndex("dbo.Orders", new[] { "Services_AreaId", "Services_OutLetId" });
            AddColumn("dbo.Orders", "ApplicationUserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Orders", "DeliveryTypeIndex", c => c.String());
            CreateIndex("dbo.Orders", "ApplicationUserId");
            AddForeignKey("dbo.Orders", "ApplicationUserId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Orders", "CustomerName");
            DropColumn("dbo.Orders", "CustomerPhone");
            DropColumn("dbo.Orders", "CustomerAddress1");
            DropColumn("dbo.Orders", "CustomerAddress2");
            DropColumn("dbo.Orders", "CustomerStreet");
            DropColumn("dbo.Orders", "CustomerBuilding");
            DropColumn("dbo.Orders", "CustomerFloor");
            DropColumn("dbo.Orders", "CustomerApartment");
            DropColumn("dbo.Orders", "CustomerSpecialMark");
            DropColumn("dbo.Orders", "OutLetId");
            DropColumn("dbo.Orders", "HdAreasId");
            DropColumn("dbo.Orders", "ServicesId");
            DropColumn("dbo.Orders", "Services_AreaId");
            DropColumn("dbo.Orders", "Services_OutLetId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Services_OutLetId", c => c.Int());
            AddColumn("dbo.Orders", "Services_AreaId", c => c.Int());
            AddColumn("dbo.Orders", "ServicesId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "HdAreasId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OutLetId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "CustomerSpecialMark", c => c.String());
            AddColumn("dbo.Orders", "CustomerApartment", c => c.String());
            AddColumn("dbo.Orders", "CustomerFloor", c => c.String());
            AddColumn("dbo.Orders", "CustomerBuilding", c => c.String());
            AddColumn("dbo.Orders", "CustomerStreet", c => c.String());
            AddColumn("dbo.Orders", "CustomerAddress2", c => c.String());
            AddColumn("dbo.Orders", "CustomerAddress1", c => c.String());
            AddColumn("dbo.Orders", "CustomerPhone", c => c.String());
            AddColumn("dbo.Orders", "CustomerName", c => c.String());
            DropForeignKey("dbo.Orders", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Orders", new[] { "ApplicationUserId" });
            DropColumn("dbo.Orders", "DeliveryTypeIndex");
            DropColumn("dbo.Orders", "ApplicationUserId");
            CreateIndex("dbo.Orders", new[] { "Services_AreaId", "Services_OutLetId" });
            CreateIndex("dbo.Orders", "HdAreasId");
            CreateIndex("dbo.Orders", "OutLetId");
            AddForeignKey("dbo.Orders", new[] { "Services_AreaId", "Services_OutLetId" }, "dbo.HD_Areas_Services", new[] { "AreaId", "OutLetId" });
            AddForeignKey("dbo.Orders", "OutLetId", "dbo.OutLets", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "HdAreasId", "dbo.HD_Areas", "Id", cascadeDelete: true);
        }
    }
}
