namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPromosTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Promoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        DiscountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Discounts", t => t.DiscountId, cascadeDelete: true)
                .Index(t => t.DiscountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Promoes", "DiscountId", "dbo.Discounts");
            DropIndex("dbo.Promoes", new[] { "DiscountId" });
            DropTable("dbo.Promoes");
        }
    }
}
