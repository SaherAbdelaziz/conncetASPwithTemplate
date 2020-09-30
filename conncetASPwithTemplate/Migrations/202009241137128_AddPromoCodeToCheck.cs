namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPromoCodeToCheck : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Checks", "PromoCodeId", c => c.Int());
            AddColumn("dbo.Checks", "HasPromoCode", c => c.Boolean(nullable: false , defaultValue:false));
            CreateIndex("dbo.Checks", "PromoCodeId");
            AddForeignKey("dbo.Checks", "PromoCodeId", "dbo.Promoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Checks", "PromoCodeId", "dbo.Promoes");
            DropIndex("dbo.Checks", new[] { "PromoCodeId" });
            DropColumn("dbo.Checks", "HasPromoCode");
            DropColumn("dbo.Checks", "PromoCodeId");
        }
    }
}
