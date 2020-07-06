namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCartTableAndUpdateCartItemTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(maxLength: 128),
                        SessionId = c.String(),
                        TotalPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            AddColumn("dbo.MyCartItems", "ShoppingCartId", c => c.Int(nullable: false));
            CreateIndex("dbo.MyCartItems", "ShoppingCartId");
            AddForeignKey("dbo.MyCartItems", "ShoppingCartId", "dbo.Carts", "Id", cascadeDelete: true);
            DropColumn("dbo.MyCartItems", "CartId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MyCartItems", "CartId", c => c.String());
            DropForeignKey("dbo.MyCartItems", "ShoppingCartId", "dbo.Carts");
            DropForeignKey("dbo.Carts", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.MyCartItems", new[] { "ShoppingCartId" });
            DropIndex("dbo.Carts", new[] { "ApplicationUserId" });
            DropColumn("dbo.MyCartItems", "ShoppingCartId");
            DropTable("dbo.Carts");
        }
    }
}
