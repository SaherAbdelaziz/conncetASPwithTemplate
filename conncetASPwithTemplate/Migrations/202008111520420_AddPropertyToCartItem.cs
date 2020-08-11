namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyToCartItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyCartItems", "Serial", c => c.Int(nullable: false));
            AddColumn("dbo.MyCartItems", "ModifiersCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyCartItems", "ModifiersCount");
            DropColumn("dbo.MyCartItems", "Serial");
        }
    }
}
