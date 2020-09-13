namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPromoCoulToCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "HasPromoCode", c => c.Boolean(nullable: false));
            AddColumn("dbo.Carts", "PromoId", c => c.Int());
            CreateIndex("dbo.Carts", "PromoId");
            AddForeignKey("dbo.Carts", "PromoId", "dbo.Promoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "PromoId", "dbo.Promoes");
            DropIndex("dbo.Carts", new[] { "PromoId" });
            DropColumn("dbo.Carts", "PromoId");
            DropColumn("dbo.Carts", "HasPromoCode");
        }
    }
}
