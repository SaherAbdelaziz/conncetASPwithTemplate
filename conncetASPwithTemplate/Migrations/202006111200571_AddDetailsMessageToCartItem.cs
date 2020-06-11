namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDetailsMessageToCartItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartItems", "Details", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartItems", "Details");
        }
    }
}
