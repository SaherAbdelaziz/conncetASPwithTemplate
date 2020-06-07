namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModifiersItemToCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "CartItem_Id", c => c.Int());
            CreateIndex("dbo.Items", "CartItem_Id");
            AddForeignKey("dbo.Items", "CartItem_Id", "dbo.CartItems", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "CartItem_Id", "dbo.CartItems");
            DropIndex("dbo.Items", new[] { "CartItem_Id" });
            DropColumn("dbo.Items", "CartItem_Id");
        }
    }
}
