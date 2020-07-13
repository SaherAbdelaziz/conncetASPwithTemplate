namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CustomerAddress1", c => c.String());
            AddColumn("dbo.Orders", "CustomerAddress2", c => c.String());
            AddColumn("dbo.Orders", "CustomerStreet", c => c.String());
            AddColumn("dbo.Orders", "CustomerBuilding", c => c.String());
            AddColumn("dbo.Orders", "CustomerFloor", c => c.String());
            AddColumn("dbo.Orders", "CustomerApartment", c => c.String());
            AddColumn("dbo.Orders", "CustomerSpecialMark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "CustomerSpecialMark");
            DropColumn("dbo.Orders", "CustomerApartment");
            DropColumn("dbo.Orders", "CustomerFloor");
            DropColumn("dbo.Orders", "CustomerBuilding");
            DropColumn("dbo.Orders", "CustomerStreet");
            DropColumn("dbo.Orders", "CustomerAddress2");
            DropColumn("dbo.Orders", "CustomerAddress1");
        }
    }
}
